using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_BasicAuthentication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
    }
}