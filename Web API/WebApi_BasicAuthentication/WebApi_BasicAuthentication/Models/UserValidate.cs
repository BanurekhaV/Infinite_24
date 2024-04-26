using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_BasicAuthentication.Models
{
    public class UserValidate
    {
        public static bool Login(string username, string password)
        {
            UserBL userBL = new UserBL();
            var UserList = userBL.GetUsers();
            return UserList.Any(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
    }
}