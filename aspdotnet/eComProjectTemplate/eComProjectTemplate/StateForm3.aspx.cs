using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class StateForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
                Session["password"] = null;
                Response.Redirect("StateForm1.aspx");
            }
        }
    }
}