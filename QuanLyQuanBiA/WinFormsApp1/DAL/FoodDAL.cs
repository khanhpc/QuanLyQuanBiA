using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAL
{
    public class FoodDAL
    {
        public static List<Food> GetListFoodDAL()
        {
            List<Food> listFood = new List<Food>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = "Select * from Food";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Food food = new Food();
                            food.id = reader.GetInt32(0);
                            food.name = reader.GetString(1);
                            food.idCategory = reader.GetInt32(2);
                            food.price = (float)reader.GetDouble(3);
                            food.url = reader["url"].ToString();
                            listFood.Add(food);
                        }
                    }
                }
            }
            return listFood;
        }

        public static bool ThemMonVaoBill(int idBill, int idFood, int count)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = @"IF EXISTS (SELECT 1 FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood)
                                BEGIN
                                    UPDATE BillInfo 
                                    SET count = count + @count 
                                    WHERE idBill = @idBill AND idFood = @idFood
                                    DELETE FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood AND count <= 0
                                END
                                ELSE
                                BEGIN
                                    INSERT INTO BillInfo (idBill, idFood, count) 
                                    VALUES (@idBill, @idFood, @count)
                                END";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idBill", idBill);
                    cmd.Parameters.AddWithValue("@idFood", idFood);
                    cmd.Parameters.AddWithValue("@count", count);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
