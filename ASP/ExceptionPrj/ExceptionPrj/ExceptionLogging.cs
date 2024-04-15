using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using context = System.Web.HttpContext;

namespace ExceptionPrj
{
    public static class ExceptionLogging
    {
        static string exurl;
        static SqlConnection con;

        private static void getConnection()
        {
            con = new SqlConnection("Data Source=Laptop-tjj7d977;initial catalog=trainingdb; integrated security=true;");
            con.Open();
        }

        public static void LogExceptionDB(Exception exdb)
        {
            getConnection();
            exurl = context.Current.Request.Url.ToString();

            SqlCommand cmd = new SqlCommand("ExLog", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@exmsg", exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@extype", exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@exsrc", exdb.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@exurl", exurl);

            cmd.ExecuteNonQuery();
        }
    }
}