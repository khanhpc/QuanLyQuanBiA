using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WinFormsApp1.DAL
{
    internal class GetConnection
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanBia;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
