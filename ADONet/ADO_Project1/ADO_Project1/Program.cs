using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Project1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
            
        static void Main(string[] args)
        {
            InsertData();
            SelectData();
            Console.Read();
        }

        //common method for getting databse connection for 
        //all activities
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=Laptop-tjj7d977;initial catalog=Trainingdb;" +
                "integrated security=true");
            con.Open();
            return con;
        }

        //method for selecting data from table
        public static void SelectData()
        {
            con = getConnection();
            //cmd = new SqlCommand("select * from tblemployee", con);
            //or
            cmd = new SqlCommand("select * from tblemployee");
            cmd.Connection = con;

            dr=cmd.ExecuteReader();

            while(dr.Read())
            {
               // Console.WriteLine(dr[0]+ " " +dr[1]+ " "+dr[2]+ " "+dr[3]);
                Console.WriteLine("Employee Number : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Salary : " + dr[3]);
                Console.WriteLine("Employee Gender : " + dr[2]);
            }
        }

        //method for inserting a row
        public static void InsertData()
        {
            con = getConnection();
            //hardcoded values will result in violation of pk
            // cmd = new SqlCommand("insert into tblemployee(Empid,Empname,Salary,Phone) values(300,'Banurekha',12000,'11223344')", con);

            // Instead of hardcoding, we will send parameters
            int eid, edeptid;
            float esal;
            string ename, egen, ecity, ephone;
            try
            {
                Console.WriteLine("Enter Employee ID,NAME,GENDER,SALARY,DEPT,PHONE,CITY : ");
                eid = Convert.ToInt32(Console.ReadLine());
                ename = Console.ReadLine();
                egen = Console.ReadLine();
                esal = Convert.ToSingle(Console.ReadLine());
                edeptid = Convert.ToInt32(Console.ReadLine());
                ephone = Console.ReadLine();
                ecity = Console.ReadLine();

                cmd = new SqlCommand("insert into tblemployee " +
                    "values(@code,@name,@gen,@sal,@did,@ph,@city)", con);

                cmd.Parameters.AddWithValue("@code", eid);
                cmd.Parameters.AddWithValue("@name", ename);
                cmd.Parameters.AddWithValue("@gen", egen);
                cmd.Parameters.AddWithValue("@sal", esal);
                cmd.Parameters.AddWithValue("@did", edeptid);
                cmd.Parameters.AddWithValue("@ph", ephone);
                cmd.Parameters.AddWithValue("@city", ecity);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Inserted Data..");
                else
                    Console.WriteLine("Ran into some Error..");
            }
            catch(SqlException se)
            {
                Console.WriteLine("Some SQl error occured..");
            }
        }
    }
}
