using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ep
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            string CS = "data source = .; database = sample2; integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd1 = new SqlCommand("select salary from emp_tb where username=@username", con);
                SqlCommand cmd2 = new SqlCommand("select sum(Attendance_Status) from Att where username=@username and Emp_Name!='NULL'", con);

                cmd1.Parameters.AddWithValue("@username", Session["username"]);
                cmd2.Parameters.AddWithValue("@username", Session["username"]);
                con.Open();
                double i = Convert.ToDouble(cmd1.ExecuteScalar());
                TextBox2.Text = i.ToString();
                double j = Convert.ToDouble(cmd2.ExecuteScalar());
                Response.Write(((j / 2) ).ToString());
                TextBox1.Text = ((j / 2) * (i / 30)).ToString();
              

            }
        }
    }
}