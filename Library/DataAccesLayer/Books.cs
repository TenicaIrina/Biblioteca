using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class Books
    {
        private readonly ConnectionSql connection = new ConnectionSql();
        readonly DataTable table = new DataTable();//pt a stoca liniile
        readonly SqlCommand command = new SqlCommand();

        public DataTable ShowBooksDataTableProp(string search)
        {
            SqlDataReader reader;
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


