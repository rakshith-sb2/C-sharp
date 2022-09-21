using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_GettingStarted_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string  name = NameTextBox.Text;
            string email = EMailTextBox.Text;
            string password = PasswordTextBox.Text;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful')</script>");
        }
    }
}