using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_BasicAuthentication.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            List<User> userlist = new List<User>();
            userlist.Add(new User()
            {
                ID = 100,
                UserName = "MaleUser",
                Password = "aaaaa"
            });
            userlist.Add(new User()
            {
                ID = 100,
                UserName = "FemaleUser",
                Password = "bbbbb"
            });
            return userlist;
        }
    }
}