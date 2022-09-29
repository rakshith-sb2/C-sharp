using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ApplicationServices;
namespace FormsAuthenticationDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
          // FormsAuthentication.

            /**
            if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
            {

            }
            else
            {
                lblMessage.Text = "Invalid User Name and/or password";
            }
            **/
        }
    }
}