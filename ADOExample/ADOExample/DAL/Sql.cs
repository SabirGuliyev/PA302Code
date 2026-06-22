using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample.DAL
{
    internal class Sql
    {
        private const string _connectionString = "server=MSI;database=ADOPA302;trusted_connection=true;integrated security=true;";

        private readonly SqlConnection _sqlConnection= new SqlConnection(_connectionString);



        public void ExecuteCommand(string command)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(command, _sqlConnection);
            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public DataTable ExecuteQuery(string query)
        {
            _sqlConnection.Open();
            SqlDataAdapter data = new SqlDataAdapter(query, _sqlConnection);
            DataTable dataTable = new DataTable();

            data.Fill(dataTable);
            _sqlConnection.Close();

            return dataTable;

        }

    }
}
