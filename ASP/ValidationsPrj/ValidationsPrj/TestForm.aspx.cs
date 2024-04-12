﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] fruits = new string[] { "Select", "Apples", "Mangoes", "Bananas", "Grapes", "Oranges" };
                for(int i=0; i<fruits.Length;i++)
                {
                    DropDownList1.Items.Add(fruits[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jpg";
            //for(int i=0; i<DropDownList1.Items.Count;i++)
            //{
            //    switch(DropDownList1.Items[i].Text)
            //    {
            //        case "Select":
            //            Response.Write("Plesae select a Fruit");
            //            break;
            //        case "Apples":
            //            imageUrl = "~/Images/Apples.jpg";
            //            break;
            //        case "Bananas":
            //            imageUrl = "~/Images/Bananas.jpg";
            //            break;
            //        case "Oranges":
            //            imageUrl = "~/Images/Oranges.jpg";
            //            break;
            //        case "Grapes":
            //            imageUrl = "~/Images/Grapes.jpg";
            //            break;
            //        case "Mangoes":
            //            imageUrl = "~/Images/Mangoes.jpg";
            //            break;
            //    }
          //  }

        }
    }
}