using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class StateForm1 : System.Web.UI.Page
    {
        string name;
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            
         }

        protected void Submit_Click(object sender, EventArgs e)
        {
            // name = UserNameTextBox.Text;
            // password = PasswordTextBox.Text;
            //ViewState["user"]=UserNameTextBox.Text;
            //ViewState["password"]=PasswordTextBox.Text; 
            Session.Add("user", UserNameTextBox.Text);
            Session["password"]= PasswordTextBox.Text;
            Application["user"] = UserNameTextBox.Text;
            Response.Redirect("StateForm2.aspx");
            UserNameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        protected void Restore_Click(object sender, EventArgs e)
        {
            //  UserNameTextBox.Text = name;
            //  PasswordTextBox.Text = password;

            if (ViewState["user"] != null)
            { 
                UserNameTextBox.Text = ViewState["user"].ToString();
            }
            if (ViewState["password"] != null) { 
                PasswordTextBox.Text = ViewState["password"].ToString() ;
            }
        }
    }
}