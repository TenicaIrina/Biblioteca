using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.cache;
using DataAccesLayer;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();

        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

        public void RoleUser()
        {
            if (UserLoginCache.Position == RoleUsers.Administrator)
            {
                //doar administratorii pot modifica baza de date
            }
            else if (UserLoginCache.Position == RoleUsers.Utilizator)
            {

            }

        }

    }
}
