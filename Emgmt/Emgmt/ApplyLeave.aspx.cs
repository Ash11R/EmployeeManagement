using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Emgmt
{
    public partial class ApplyLeave : System.Web.UI.Page
    {
        string username;

        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Username"]!=null)
                username = Session["UserName"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_Leave_Requests", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Purpose", DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("StartDate", ChangeDateFormat(TextBox1.Text.ToString()));
            cmd.Parameters.AddWithValue("EndDate", ChangeDateFormat(TextBox2.Text.ToString()));
            cmd.Parameters.AddWithValue("StatusNotif", "Unread");
            cmd.Parameters.AddWithValue("username", username);
            con.Open();
            int k = cmd.ExecuteNonQuery();


                  con.Close();


        }

        


        public string ChangeDateFormat(String s)
        {
            string[] arr= s.Split('/');
           
            string a= arr[2]+"-"+arr[0]+"-"+arr[1];

            System.Diagnostics.Debug.WriteLine(a);

            return a;
        }

    }
}