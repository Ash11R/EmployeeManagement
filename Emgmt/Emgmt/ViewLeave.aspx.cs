using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Emgmt
{
    public partial class ViewLeave : System.Web.UI.Page
    {
        string connetionString;
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {

            

            connetionString = @"Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True";

            conn = new SqlConnection(connetionString);

            conn.Open();


            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                ViewState["dt"] = dt;
                this.BindGrid();
            }

        }


        private void BindGrid()
        {
            string constr = "Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username, Purpose, StartDate, EndDate FROM LeaveRequests where StatusNotif='Unread'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            ViewState["dt"] = dt;
                            sda.Fill(dt);
                            GridView1.DataSource = ViewState["dt"] as DataTable;// dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
    }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument);

            //Reference the GridView Row.
            GridViewRow row = GridView1.Rows[rowIndex];

            
            string username = row.Cells[0].Text;
            string purpose = row.Cells[1].Text;

            if (e.CommandName == "Accept")
            {
              

                //conn.Open();
               
                SqlCommand cmd = new SqlCommand("update LeaveRequests Set StatusNotif = @notif where username = @username and Purpose=@purpose", conn);  
                cmd.Parameters.AddWithValue("@notif","Accept");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@purpose", purpose);
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                //Response.Write(rowIndex.ToString());

                BindGrid();
            
            }

            if(e.CommandName == "Decline")
            {

                //conn.Open();

                SqlCommand cmd = new SqlCommand("update LeaveRequests Set StatusNotif = @notif where username = @username and Purpose=@purpose", conn);
                cmd.Parameters.AddWithValue("@notif", "Decline");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@purpose", purpose);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                conn.Close();
                //Response.Write(rowIndex.ToString()+"Decline");

                BindGrid();
            }
        }


    }
}