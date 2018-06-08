using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ep
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["sample2ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select Photo from emp_tb where Username=@Username",con);
                cmd.Parameters.AddWithValue("@Username", Session["Username"]);
                con.Open();
                string c = cmd.ExecuteScalar().ToString();
                Image1.ImageUrl = "~/"+ c;
            }
            Label1.Text = (string)Session["Username"];
           

        }
    }
}