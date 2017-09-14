using NovelDemo.Models.Repositories.Interface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NovelDemo.Models.Repositories.Implement
{
    public class DatabaseConnectionFactory : IDbConnectionFactory
    {
        private string _connectionString = String.Empty;

        public DatabaseConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }


        public IDbConnection Create()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            return conn;
        }
    }
}
