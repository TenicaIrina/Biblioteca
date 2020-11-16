using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.cache;

namespace DataAccesLayer
{
    public class UserData:ConnectionSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())//pt a obtine conexiunea din clasa de  baza
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

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
                            //UserLoginCache.UserName = reader.GetString(1);
                            //UserLoginCache.Password = reader.GetString(2);
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

        public void RoleUser()
        {
            if(UserLoginCache.Position == RoleUsers.Administrator)
            {
            //doar administratorii pot modifica baza de date
            }
            else if (UserLoginCache.Position == RoleUsers.Utilizator)
            {

            }

        }


    }
}
