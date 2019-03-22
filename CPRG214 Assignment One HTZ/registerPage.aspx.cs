using EntityClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214_Assignment_One_HTZ
{
    public partial class registerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxOK_Click(object sender, EventArgs e)
        {
            int ID = CustomerManager.LogIn(uxFirstName.Text, uxLastName.Text);
            if (ID!=-1)
            {
                Session["customer"] = ID;
                Response.Write("Logged in");
            }
            else
            {
                Response.Redirect("~/registerPage.aspx");
            }
        }
    }
}