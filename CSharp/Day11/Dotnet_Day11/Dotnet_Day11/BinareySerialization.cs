using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dotnet_Day11
{
    [Serializable]  //data annotation/attribute/metadata
    class Employee
    {       
        public int EID;
        public string EName;
        [NonSerialized]
        public double ESal;

        public Employee(int id, string name, double sal)
        {
            EID = id;
            EName = name;
            ESal = sal;
        }
        static void Main(string[] args)
        {
            Employee empobj = new Employee(1,"Sahana",35000);           

            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"Employeefile.txt", FileMode.Create,
                FileAccess.Write);

            formatter.Serialize(stream, empobj);
            stream.Close();

            //Deserializing 

            stream = new FileStream(@"Employeefile.txt", FileMode.Open,
                FileAccess.Read);

            Employee empdobj = (Employee)formatter.Deserialize(stream);

            Console.WriteLine(empdobj.EID + " "+empdobj.EName+ " "+empdobj.ESal);

            Console.Read();
        }
    }

}
    
