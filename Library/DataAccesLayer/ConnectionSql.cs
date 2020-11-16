using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public abstract class ConnectionSql
    {
        private readonly string connectionString;
        public ConnectionSql()
        {
            connectionString = "Server=DESKTOP-66L68LO\\IRINA;DataBase = Biblioteca;integrated security = true";// se pune conexiunea cu serverul, baza de date si faptul ca est e autentofiacre de  tip windows
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
