using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CachingPrj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductByName("All");
            }
            //else
            //{
            //    Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); //duration 
            //    Response.Cache.VaryByParams["None"] = true;   //cache options
            //    Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location of cache
            //}
            lbldata.Text = "This Page is Cached @" + " " + DateTime.Now.ToString();
        }

        private void GetProductByName(string ProductName)
        {
            SqlConnection con = new SqlConnection("Data Source=Laptop-tjj7d977;" +
                "initial catalog=trainingdb;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("spGetProductbyname", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlparam = new SqlParameter();
            sqlparam.ParameterName = "@ProductName";
            sqlparam.Value = ProductName;

            da.SelectCommand.Parameters.Add(sqlparam);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void dplist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(dplist1.SelectedValue);
        }
    }
}