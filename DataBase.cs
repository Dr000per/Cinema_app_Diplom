using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Cinema_app_Diplom
{
    public class DataBase : IDisposable
    {
        private string _connectionstring = @"Data Source = DESKTOP-BBAJL13\SQLEXPRESS; Initial Catalog = Cinema_app; Integrated Security = True";
        public SqlConnection _connection;

        public DataBase()
        {
            _connection = new SqlConnection(_connectionstring);
            OpenConnection();
        }

        public void OpenConnection()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }

        public void CloseConnection() 
        {
            _connection.Close();
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(sql, _connection);
            table.Load(command.ExecuteReader());

            return table;
        }

        public void ExecuteNonQuery(string sql) 
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
