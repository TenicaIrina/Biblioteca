using DataAccesLayer;

namespace Domain
{
    public class UserModel
    {
        readonly UserData userData = new UserData();

        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }


    }
}
