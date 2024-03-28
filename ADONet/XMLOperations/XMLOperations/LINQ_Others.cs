using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLOperations
{
    class Person
    {
        public int PID { get; set; }
        public string PName { get; set; }
    }

    class Course
    {
        public int CID { get; set; }
        public string CName { get; set; }
    }
    class LINQ_Others
    {
        public static void GrpJoinEg()
        {
            Person[] p = new Person[]
            {
                new Person{PID=1, PName="Riya" },
                new Person{PID=2, PName="Sankalp" },
                new Person{PID=2, PName="Ramya" },
                new Person{PID=1, PName="Divya" },
                new Person{PID=3, PName="Vikash" },
            };

            Course[] c = new Course[]
            {
                new Course{CID=1,CName="ADO.Net"},
                new Course{CID=2,CName="CSharp"},
                new Course{CID=5,CName="SQL"}
            };

            var result = c.GroupJoin(p, crs => crs.CID, pers => pers.PID, (cr, pr) => new
            {
                key = cr.CName,
                s = pr
            });
            Console.WriteLine( "Group-Joined List of Persons who have either taken ADO or C#");
            foreach(var course in result)
            {
                foreach(var person in course.s)
                {
                    Console.WriteLine(course.key + " " + person.PName);
                }
            }
        }

        public static void SimpleJoin()
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Korea", "UK", "India", "Japan" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s1);
            Console.WriteLine("Post Joining..");

            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
        }
        public static void Main()
        {
            GrpJoinEg();
            Console.WriteLine("------------");
            SimpleJoin();
            Console.Read();
        }
    }
}
