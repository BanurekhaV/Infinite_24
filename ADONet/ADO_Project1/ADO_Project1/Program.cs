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
            //  InsertData();
            // DeleteData();
            // SelectData();
            //StoredProc_WithParameter();
            //StoredProc_With_Output();
             getScalar();
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

        //for deletion

        public static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter Empid : ");
            int eid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select * from tblemployee where empid=@eid");
            cmd.Parameters.AddWithValue("@eid", eid);
            cmd.Connection = con;

            dr = cmd.ExecuteReader();
           // dr.HasRows
            while(dr.Read())
            {
                for(int i=0;i<dr.FieldCount;i++)
                {
                    Console.WriteLine(dr[i]);
                }
            }
            if(dr.HasRows)
            { 
             
            Console.WriteLine("Are you sure to delete this Employee ? Y/N");
            string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y")
                {
                    con.Close();
                    SqlCommand cmd1 = new SqlCommand("delete from tblemployee where empid=@eid", con);
                    cmd1.Parameters.AddWithValue("@eid", eid);
                    con.Open();
                    int ctr= cmd1.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        Console.WriteLine("Record Deleted Successfully..");
                    }
                else
                    Console.WriteLine("Could not delete..");
                }
               
            }
            else
            {
                Console.WriteLine("Employee with id {0} does not exists",eid);
            }
        }

        //calling procedures with input parameter
        public static void StoredProc_WithParameter()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("Enter The Employee Id :");
                int eid = int.Parse(Console.ReadLine());
                cmd = new SqlCommand("getsal", con); //cmdtext here takes only the name of the procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", eid);

                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine($"Employee Named {dr[0]} earns Rs. {dr[1]}");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some Sql error occured..");
            }
            catch (Exception e)
            {
                Console.WriteLine("Data error occured..");
            }
            
        }
        //calling procedure with output value
        public static void StoredProc_With_Output()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee Name :");
            string empname = Console.ReadLine();
            cmd = new SqlCommand();
            cmd.CommandText = "getEmpSalary";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //we shall use a class called SqlParameter for input output values
            SqlParameter param1 = new SqlParameter
            {
                ParameterName="@ename",
                SqlDbType=SqlDbType.NVarChar,
                Value=empname,
                Direction=ParameterDirection.Input
            };
            cmd.Parameters.Add(param1);

            //for output parameter
            SqlParameter outparam = new SqlParameter
            {
                ParameterName = "@sal",
                SqlDbType = SqlDbType.Float,
                Direction = ParameterDirection.Output
            };

            cmd.Parameters.Add(outparam);

            cmd.ExecuteScalar();
            Console.WriteLine("Salary of Employee : {0} is : {1}", empname,outparam.Value);
        }

        //method with scalar info. (one data of any type)
        public static void getScalar()
        {
            con = getConnection();
            cmd = new SqlCommand("Select count(Empid) from tblemployee", con);
            int empcount=(int)cmd.ExecuteScalar(); //or

            int ecount = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No. of employees : {0}", empcount);
        }
    }
}
