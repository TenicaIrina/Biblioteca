using System.Data.SqlClient;
using System.Data;
using Common.cache;

namespace DataAccesLayer
{
    public class UserData
    {
        private readonly ConnectionSql connection = new ConnectionSql();
        public bool Login(string user, string pass)
        {
         
                using (var command = new SqlCommand())
                {
                    command.Connection = connection.OpenConnection();

                    command.CommandText = "select * from Users  where UserName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;//tipul  comenzii

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FullName = reader.GetString(3);
                            UserLoginCache.Position = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                        }
                        return true;//tabela exista
                    }
                    else
                        return false;

                }
        }

      

    }
}
