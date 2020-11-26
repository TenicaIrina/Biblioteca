using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class Books
    {
        private ConnectionSql connection = new ConnectionSql();
        SqlDataReader reader;
        DataTable table = new DataTable();//pt a stoca liniile
        SqlCommand command = new SqlCommand();

        public DataTable ShowBooksDataTableProp(string search)
        {

            command.Connection = connection.OpenConnection();
            command.CommandText = "RetriveBookFromTables";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@title", search);
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CloseConnection();
            return table;  


        }
    }
}


