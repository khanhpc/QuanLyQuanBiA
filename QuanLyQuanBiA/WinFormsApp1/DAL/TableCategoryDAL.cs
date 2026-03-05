using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAL
{
    public class TableCategoryDAL
    {
        public static List<TableCategory> GetListTableCategoryDAL()
        {
            List<TableCategory> list = new List<TableCategory>();
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = "SELECT * FROM TableCategory";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            TableCategory category = new TableCategory();
                            category.id = read.GetInt32(0);
                            category.name = read.GetString(1);
                            category.price = (float)Convert.ToDouble(read[2]);
                            list.Add(category);
                        }
                    }
                }
            }
            return list;
        }
    }
}
