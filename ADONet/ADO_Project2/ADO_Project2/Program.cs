using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Project2
{
    //Business layer
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public void AddRegion()
        {
            Console.WriteLine("Enter Region ID :");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description :");
            RegionDescription = Console.ReadLine();
            DataAccess.AddRegion(RegionID, RegionDescription);
        }

        public void ShowAllRegions()
        {
            DataAccess.DisplayRegion();
        }

        public int GetRegionCount()
        {
            int count = DataAccess.GetRegionCount();
            return count;
        }
    }

    //Data layer to handle all database activities
    class DataAccess
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=Laptop-tjj7d977; initial catalog=Northwind;" +
                "trusted_connection=true");
            con.Open();
            return con;
        }

        //adding a region
        public static void AddRegion(int rid, string rdesc)
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("insert into Region values(@rid,@rdesc)", con);
                cmd.Parameters.AddWithValue("@rid", rid);
                cmd.Parameters.AddWithValue("@rdesc", rdesc);

               int rowsaffected = cmd.ExecuteNonQuery();
                if(rowsaffected > 0)
                {
                    Console.WriteLine("Inserted a row.");
                }
                else
                    Console.WriteLine("Could not Insert. Some Problem..");
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DisplayRegion()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from Region", con);

                dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"] + " "+dr["RegionDescription"]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static int GetRegionCount()
        {
            con = getConnection();
            cmd = new SqlCommand("select count(regionid) from region", con);
            int regioncount = (int)cmd.ExecuteScalar();
            return regioncount;
        }
    }

    //Client
    class Program
    {
        static void Main(string[] args)
        {
            Region region = new Region();
            Console.WriteLine("Adding a new Region");
            region.AddRegion();
            Console.WriteLine("Region Tables Data ");
            region.ShowAllRegions();
            Console.WriteLine("Region Count");
            int rno = region.GetRegionCount();
            Console.WriteLine("The Total Number of Regions are : {0}", rno);
            Console.Read();
        }
    }
}
