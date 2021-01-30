using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class BooksOp
    {
        private readonly ConnectionSql connection = new ConnectionSql();
        readonly DataTable table = new DataTable();
        readonly SqlCommand command = new SqlCommand();


        public DataTable ShowData()
        {
            //SQL
                SqlDataReader reader;
                command.Connection = connection.OpenConnection();
                command.CommandText = "Select *from Book";
                reader = command.ExecuteReader();
                table.Load(reader);
                connection.CloseConnection();
                return table; 
        }

        

        public void InsertBook(string isbn, string datePublishing, string title, string bookPublishing)
        {
             
                command.Connection = connection.OpenConnection();
                command.CommandText = "InsertBooks";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@datePublishing", datePublishing);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@bookPublishing", bookPublishing);
                command.ExecuteNonQuery();
                command.Parameters.Clear();//pt a nu folosi de fiecare data un obiect de tipul SqlCommandpt a nu duplica codul
                connection.CloseConnection();

        }

        public void EditBook(string isbn, string datePublishing, string title, string bookPublishing)
        {
           
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditDataBooks";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@datePublishing", datePublishing);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@bookPublishing", bookPublishing);
            command.Parameters.AddWithValue("@isbn", isbn);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void DeleteBook(string title)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "DeleteBook";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@title", title);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
