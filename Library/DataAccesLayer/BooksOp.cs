using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class BooksOp
    {
        private ConnectionSql connection = new ConnectionSql();
        SqlDataReader reader;
        DataTable table = new DataTable();//pt a stoca liniile
        SqlCommand command = new SqlCommand();


        public DataTable ShowData()
        {
            //SQL
                
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
