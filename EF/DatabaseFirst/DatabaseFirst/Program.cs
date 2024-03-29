using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        //create an object of the context class and instantiate it
        static TrainingDBEntities db = new TrainingDBEntities();
        static EMP emp = new EMP();
        static void Main(string[] args)
        {
            EMP emp1 = new EMP();
            Console.WriteLine($"State of a newly created Object : {db.Entry(emp1).State}");
            emp.empno = 8000;
            emp.ename = "Infinite";
            emp.job = "Manager";
            emp.mgr_id = 7389;
            emp.hiredate = Convert.ToDateTime("1995/03/29");
            emp.sal = 4500;
            emp.comm = 0;
            emp.deptno = 40;

             AddEmp(emp);
            Console.WriteLine("---------------");
             UpdEmp();
            Console.WriteLine("---------------");
            DeleteEmp();
           // ShowEmployees();
            Console.Read();
        }

        public static void ShowEmployees()
        {
            var empdata = db.EMPs.ToList();
            foreach(var e in empdata)
            {
                Console.WriteLine($"{e.empno},{e.ename},{e.job},{e.mgr_id}");
            }
        }

        public static void AddEmp(EMP e)
        {
            Console.WriteLine($"Before add, the Entity State : {db.Entry(emp).State}");
            db.EMPs.Add(e);
            Console.WriteLine($"Before Save and after Add, the Entity State : {db.Entry(emp).State}");
            db.SaveChanges();
            Console.WriteLine($"After Save changes, the Entity State : {db.Entry(emp).State}");
        }

        public static void UpdEmp()
        {
            Console.WriteLine("enter employee no to update :");
            int eno = int.Parse(Console.ReadLine());
            EMP e = db.EMPs.Find(eno);
            Console.WriteLine($"Before update, the Entity State : {db.Entry(emp).State}");
            if (e!=null)
            {
                e.mgr_id = 7839;
                Console.WriteLine($"After Update, the Entity State : {db.Entry(emp).State}");
                db.SaveChanges();
                Console.WriteLine($"After Save changes, the Entity State : {db.Entry(emp).State}");
            }
            else
                Console.WriteLine("Match not found");
        }

        public static void DeleteEmp()
        {
            emp = db.EMPs.Find(8000);
            Console.WriteLine($"Before Deleting, the Entity State : {db.Entry(emp).State}");
            db.EMPs.Remove(emp);
            Console.WriteLine($"Before Save changes and after delete, the Entity State : {db.Entry(emp).State}");
            db.SaveChanges();
            Console.WriteLine($"After Save changes, the Entity State : {db.Entry(emp).State}");
        }
    }
}
