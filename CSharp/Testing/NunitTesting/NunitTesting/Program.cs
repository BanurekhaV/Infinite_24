using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    public class Program
    {
        public string Login(string UserId, string Password)
        {
            if(string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "UserId or Password Cannot be blank";
            }
            else
            {
                if(UserId=="Admin" && Password=="Admin@123")
                {
                    return "Welcome Admin";
                }
                return "Incorrect UserId or Password";
            }
        }

        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> empdetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails { ID = 100, Name = "Avinash", Salary = 26000 },
                new EmployeeDetails { ID = 101, Name = "Yuvraj", Salary = 26000 },
                new EmployeeDetails { ID = 102, Name = "Aakash", Salary = 26000 },
                new EmployeeDetails { ID = 103, Name = "Sahana", Salary = 26000 },
            };
            return empdetails;
        }

        //public List<EmployeeDetails> GetEmployee(int id)
        //{
        //    List<EmployeeDetails> elist = new List<EmployeeDetails>();
        //}
        static void Main(string[] args)
        {
        }
    }
}
