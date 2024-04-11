using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnapp_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(Application["visits"]!=null)
            {
                count = Convert.ToInt32(Application["visits"].ToString());
            }
            count = count + 1;
            Application["visits"] = count;
            //to avoid deadlock like situation where the clients 
            //accessing the appplications overlap, we can use the unlock()
            Application.UnLock();
            lbl.Text = "Total Vists to the Application = " + count.ToString();

        }
    }
}