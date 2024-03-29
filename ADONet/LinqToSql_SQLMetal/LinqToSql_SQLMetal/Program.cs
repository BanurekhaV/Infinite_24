using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LinqToSql_SQLMetal
{
    class Program
    {
        static string connstr = ConfigurationManager.ConnectionStrings["NwindConnstr"].ConnectionString;

        static NorthwindContext db = new NorthwindContext(connstr);
        static void Main(string[] args)
        {
            var cust = from c in db.Customers
                       orderby c.ContactName
                       select c;

            foreach (var item in cust)
            {
                Console.WriteLine($"{item.CustomerID},{item.ContactName}");
            }
            Console.Read();
        }
    }
}
