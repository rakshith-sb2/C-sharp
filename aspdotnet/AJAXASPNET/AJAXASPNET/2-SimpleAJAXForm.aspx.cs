using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AJAXASPNET
{
    public partial class _2_SimpleAJAXForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(FirstNumberTextBox.Text);
            int num2 = int.Parse(SecondNumberTextBox.Text);
            int result = num1 + num2;
            Label3.Text = result.ToString();
            Label3.Visible = true;
        }
    }
}