using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAL
{
    public class BillDAL
    {
        public static bool MoBanVaBamGio(int idBan, int idAccount)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                String query = @"INSERT INTO Bill (idTable, DateCheckIn, status, idAccount) 
                                VALUES (@idTable, GETDATE(), 0,@idAccount);
                                UPDATE BilliardTable 
                                            SET status = N'Đang Sử Dụng'
                                            WHERE id = @idTable;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTable", idBan);
                    cmd.Parameters.AddWithValue("@idAccount", idAccount);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public static bool DongBan(int idBan)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"UPDATE Bill Set DateCheckOut = GETDATE()
                                 Where idTable = @idTable";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTable", idBan);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public static List<MenuDTO> GetListMenuTable(int idTable)
        {
            List<MenuDTO> list = new List<MenuDTO>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"select f.name, bf.count, f.price, (bf.count*f.price) as TotalPrice
                                from Bill b
                                join BillInfo bf on b.id = bf.idBill
                                join Food f on bf.idFood = f.id
                                where b.idTable = @idTable and b.status = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenuDTO m = new MenuDTO();
                            m.FoodName = reader.GetString(0);
                            m.Count = reader.GetInt32(1);
                            m.Price = Convert.ToInt32(reader.GetDouble(2));
                            m.TotalPrice = reader.GetDouble(3);
                            list.Add(m);
                        }
                    }
                    return list;
                }
            }
        }

        public static List<Bill> GetDateIn_DateOut(int idBan)
        {
            List<Bill> list = new List<Bill>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"select idTable, DateCheckIn,DateCheckOut, bt.name, tc.price
                                from Bill b
                                join BilliardTable bt on bt.id = b.idTable
                                join TableCategory tc on tc.id = bt.idCategory
                                where idTable = @idBan AND b.status = 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idBan", idBan);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bill b = new Bill();
                            b.idTable = reader.GetInt32(0);
                            b.dateCheckIn = reader.GetDateTime(1);
                            b.dateCheckOut = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2);
                            b.Table.name = reader.GetString(3);
                            b.Table.Category.price = (float)reader.GetDouble(4);
                            list.Add(b);
                        }
                    }
                }
            }
            return list;
        }

        public static int GetUncheckBillIDByTableID(int idTable)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();

                string query = "SELECT id FROM Bill WHERE idTable = @idTable AND status = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTable", idTable);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1;
                }
            }
        }

        public static bool ThanhToanBill(int idBan, double totalPrice)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"UPDATE [dbo].[Bill]
                                   SET 
                                      [status] = 1
                                      ,[totalPrice] = @totalPrice
                                 WHERE idTable = @idBan
                                 UPDATE [dbo].[BilliardTable]
                                   SET [status] = N'Trống'
                                 WHERE id = @idBan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@totalPrice", Math.Round(totalPrice));
                    cmd.Parameters.AddWithValue("@idBan", idBan);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public static bool ChuyenBan(int idBanCu, int idBanMoi)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();

                string query = @"
                    DECLARE @idBill INT;
                    SELECT @idBill = id FROM Bill WHERE idTable = @idBanCu AND status = 0;

                    IF (@idBill IS NOT NULL)
                    BEGIN
                        UPDATE Bill SET idTable = @idBanMoi WHERE id = @idBill;
                
                        UPDATE BilliardTable SET status = N'Trống' WHERE id = @idBanCu;
                        UPDATE BilliardTable SET status = N'Đang Sử Dụng' WHERE id = @idBanMoi;
                    END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idBanCu", idBanCu);
                    cmd.Parameters.AddWithValue("@idBanMoi", idBanMoi);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }

}


