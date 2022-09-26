using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class StateForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("Welcome " + Session["user"].ToString());
            }
            else
            {
                Response.Redirect("StateForm1.aspx");
            }
            if (Session["password"] != null)
            {
                Response.Write("Welcome " + Session["password"].ToString());
            }
            else
            {
                Response.Redirect("StateForm1.aspx");
            }
        }
    }
}