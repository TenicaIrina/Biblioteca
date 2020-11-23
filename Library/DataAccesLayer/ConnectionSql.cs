using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccesLayer
{
    public class ConnectionSql
    {
        private SqlConnection connectionString = new SqlConnection("Server=DESKTOP-66L68LO\\IRINA;DataBase = Biblioteca;integrated security = true");// se pune conexiunea cu serverul, baza de date si faptul ca est e autentofiacre de  tip windows

        public SqlConnection OpenConnection()
        {
            if (connectionString.State == ConnectionState.Closed)
                connectionString.Open();
            return connectionString;
        }
        public SqlConnection CloseConnection()
        {
            if (connectionString.State == ConnectionState.Open)
                connectionString.Close();
            return connectionString;
        }


        //protected SqlConnection GetConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}
    }
}
