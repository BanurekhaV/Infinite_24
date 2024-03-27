using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Disconnected_ADO1
{
    class ConnectionPooling
    {
        public static string connectstr = "Data Source=laptop-tjj7d977;initial catalog=Northwind;" +
        "integrated security=true;Pooling=true;";

        public static void Main()
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for(int i=0; i<1000;i++)
            {
                SqlConnection con = new SqlConnection(connectstr);
                con.Open();
                con.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"Pooling =true, Time Taken : {stopwatch.ElapsedMilliseconds} ms");
            //Transactioneg(connectstr);
            Console.Read();
        }

        public static void Transactioneg(string str)
        {
            using(SqlConnection con= new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlTransaction tran;

                tran = con.BeginTransaction();
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "insert into region values(100,'FirstRegion')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update region set regiondescription='LastRegion' where regionid=10";
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    Console.WriteLine("2 transaction successfull");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception e2)
                    {
                        Console.WriteLine(e2.Message);
                    }
                }
            }
        }
    }
}
