using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ep
{
    public partial class ApplyLeave : System.Web.UI.Page
    {
        string username;

        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
                username = Session["UserName"].ToString();

            if (Session["Username"] == null)
                Response.Redirect("LoginWebForm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            if (DropDownList2.SelectedValue == "Select Type Of Leave")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Select appropriate type of leave')", true);

            }

            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=sample2;Integrated Security=True");
                con.Open();
                int flag = 0;
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                da = new SqlDataAdapter("select * from LeaveRequests where username='" + username + "'", con);
                da.Fill(dt);


                if(Convert.ToDateTime(TextBox1.Text)>= Convert.ToDateTime(TextBox2.Text))
                {

                    flag = 4;
                }

                if (flag == 4)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('End Date should be after start date ')", true);
                    //Response.Redirect("ApplyLeave.aspx");
                }

                // dr = dt.Rows[0];
                //Response.Write(Convert.ToDateTime(TextBox1.Text)+"<br/>");
                // Response.Write(Convert.ToDateTime(dr[2]));

                for (int i = 0; i <=(dt.Rows.Count - 1); i++)
                {
                    dr = dt.Rows[i];
                    


                    if ((Convert.ToDateTime(TextBox1.Text) >= Convert.ToDateTime(dr[2]) )&& (Convert.ToDateTime(TextBox2.Text) <= Convert.ToDateTime(dr[3])))
                     {
                         flag = 1;
                         break;
                     }

                     if (Convert.ToDateTime(TextBox1.Text) <= Convert.ToDateTime(dr[2]) && Convert.ToDateTime(TextBox2.Text) <= Convert.ToDateTime(dr[3]) && Convert.ToDateTime(TextBox2.Text) >= Convert.ToDateTime(dr[2]))
                     {
                         flag = 1;
                         break;

                     }

                     if (Convert.ToDateTime(TextBox2.Text) >= Convert.ToDateTime(dr[3]) && Convert.ToDateTime(TextBox1.Text) <= Convert.ToDateTime(dr[3]) && Convert.ToDateTime(TextBox1.Text) >= Convert.ToDateTime(dr[2]))
                     {
                         flag = 1;
                         break;

                     }


                }


                //String str = "select * from LeaveRequests where username='"+username+"' ";
                //com = new SqlCommand(str, con);
                //SqlDataReader reader = com.ExecuteReader();
                //if (reader.Read())
                //{




                //}


                if (flag == 1)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have already applied for a leave in this period. Select different dates. ')", true);
                }

               
                if(flag==0)
                {
                    SqlCommand cmd = new SqlCommand("insert_Leave_Requests", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Purpose", DropDownList2.SelectedValue);
                    cmd.Parameters.AddWithValue("StartDate", (TextBox1.Text));
                    cmd.Parameters.AddWithValue("EndDate", (TextBox2.Text));

                    cmd.Parameters.AddWithValue("StatusNotif", "Unread");
                    cmd.Parameters.AddWithValue("username", username);

                    int k = cmd.ExecuteNonQuery();



                    Label3.Text = "Leave Applied Successfully";

                    con.Close();
                }
            }

        }

    

    }
}