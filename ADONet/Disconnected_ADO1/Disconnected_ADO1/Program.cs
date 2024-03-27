using System;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_ADO1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            getRegions();
            Console.Read();
        }


        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=laptop-tjj7d977;database=Northwind;integrated security=true");
            con.Open();
            return con;
        }

        public static void getRegions()
        {
            con = getConnection();
            try
            {
                //using only the dataadapter object to execute the command
                da = new SqlDataAdapter("select * from Region", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "nRegion");
                DataTable dt = ds.Tables["nRegion"];

                //to access the data in the data table
                foreach(DataRow drow in dt.Rows)
                {
                    foreach(DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //let us now add one row into the Region Table
                // da.Fill(ds, "nRegion"); // refresh the dataset

                //1. Create a data Row object under a specific data table
                DataRow row = ds.Tables["nRegion"].NewRow();

                //2. give values to the columns of the new row
                Console.WriteLine("Enter Region ID and Description :");
                int rid = Convert.ToInt32(Console.ReadLine());
                string rdesc = Console.ReadLine();

                row["RegionID"] = rid;
                row["RegionDescription"] = rdesc;

                //3. add the newly created row with data to the data table
                ds.Tables["nRegion"].Rows.Add(row);

                //4. now we need to update the database to reflect the new row added
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.InsertCommand = scb.GetInsertCommand();
                da.Update(ds, "nRegion");
                Console.WriteLine("--------After Insertion---------");
                da.Fill(ds, "nRegion");
               // dt = ds.Tables["nregion"];

                //reading the data after inserting one row
                foreach (DataRow drow1 in dt.Rows)
                {
                    foreach (DataColumn dcol1 in dt.Columns)
                    {
                        Console.Write(drow1[dcol1]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //adding one more table to the dataset
                Console.WriteLine("--------------");
                da = new SqlDataAdapter("select customerid,companyname,country from customers", con);
                da.Fill(ds, "nCustomers");
                dt = ds.Tables["nCustomers"];

                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write(row1[col1]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}
