using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;
using WinFormsApp1.DTO;
namespace WinFormsApp1.DAL
{
    public class BilliardTableDAL
    {

        public static List<BilliardTable> LoadListTableDAL()
        {
            List<BilliardTable> listTable = new List<BilliardTable>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = "SELECT * FROM BilliardTable b Join TableCategory t On b.idCategory = t.id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BilliardTable billiardTable = new BilliardTable();
                            billiardTable.id = reader.GetInt32(0);
                            billiardTable.name = reader.GetString(1);
                            billiardTable.status = reader.GetString(2);
                            billiardTable.idCategory = reader.GetInt32(3);
                            billiardTable.Category.price = (float)Convert.ToDouble(reader[6]);
                            listTable.Add(billiardTable);
                        }
                    }
                }
            }
            return listTable;
        }

        public static List<BilliardTable> LoadListTableChuyenBanDAL()
        {
            List<BilliardTable> listTable = new List<BilliardTable>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM BilliardTable b Join TableCategory t On b.idCategory = t.id
                                   where status = N'Trống'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BilliardTable billiardTable = new BilliardTable();
                            billiardTable.id = reader.GetInt32(0);
                            billiardTable.name = reader.GetString(1);
                            billiardTable.status = reader.GetString(2);
                            billiardTable.idCategory = reader.GetInt32(3);
                            billiardTable.Category.price = (float)Convert.ToDouble(reader[6]);
                            listTable.Add(billiardTable);
                        }
                    }
                }
            }
            return listTable;
        }
    }
}
