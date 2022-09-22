using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchDataTable
{
    public partial class SearchForm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGridView();
        }

        void bindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from student";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        void searchByMale()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from student where sex =@male";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@male", Male.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            if (Male.Checked == true)
            {
               // Response.Write("<script>alert ('male');</script>");
                searchByMale();
            }
            else if (Female.Checked == true)
            {

            }
            else
            {
                bindGridView();
            }
        }

        protected void Male_CheckedChanged(object sender, EventArgs e)
        {
            searchByMale();
        }

        protected void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void All_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}