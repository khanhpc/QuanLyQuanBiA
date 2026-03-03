using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WinFormsApp1.DTO;

namespace WinFormsApp1.DAL
{
    public class LoginDAL
    {
        public static Account CheckLoginDAL(String userName, String passWord)
        {
            using (SqlConnection conn = GetConnection.GetSqlConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Account Where UserName = @userName AND PassWord = @Password ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", userName);
                    cmd.Parameters.AddWithValue("password", passWord);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Account account = new Account();

                            account.id = reader.GetInt32(0);
                            account.userName = reader.GetString(1);
                            account.displayName = reader.GetString(2);
                            account.password = reader.GetString(3);
                            account.type = reader.GetInt32(4);
                            return account;
                        }
                    }
                }
            }
            return null;
        }
    }
}
