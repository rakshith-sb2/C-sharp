using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eComProjectTemplate
{
    public partial class CookieForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user");
            cookie["username"]=NameTextBox.Text;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("CookieForm2.aspx");
        }
    }
}