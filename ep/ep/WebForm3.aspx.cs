using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ep
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source = .; database = sample2; integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Att where Emp_Name != 'NULL'", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string CS = "data source = .; database = sample2; integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd1 = new SqlCommand("select * from Att where Emp_Name != 'NULL' and Emp_ID like @Emp_ID", con);
                cmd1.Parameters.AddWithValue("@Emp_ID", TextBox1.Text + "%");
                con.Open();
                GridView1.DataSource = cmd1.ExecuteReader();
                GridView1.DataBind();

            }
            TextBox1.Text = "";
        }
    }
}