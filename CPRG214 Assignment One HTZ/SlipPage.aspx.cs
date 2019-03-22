using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityClassLibrary;

namespace CPRG214_Assignment_One_HTZ
{
    public partial class SlipPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                uxSlipGridView.DataSource = SlipManager.AvailSlips();
                uxSlipGridView.DataBind();
                //DataBind();
            }
        }
    }
}