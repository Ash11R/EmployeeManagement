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
    public partial class LeaveStatus : System.Web.UI.Page
    {

        string connetionString;
        SqlConnection conn;
        string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
                username = Session["UserName"].ToString();

            if (Session["Username"] == null)
                Response.Redirect("LoginWebForm.aspx");

            connetionString = @"Data Source=.;Initial Catalog=sample2;Integrated Security=True";

            conn = new SqlConnection(connetionString);

            conn.Open();


            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                ViewState["dt"] = dt;
                this.BindGrid();
            }


        }



        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.RowIndex);
            GridViewRow row = GridView1.Rows[rowIndex];


            string username = row.Cells[1].Text;
         
            string purpose = row.Cells[2].Text;

            string startdate = row.Cells[3].Text;

           // Response.Write(date1);
           
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("delete from LeaveRequests where username = @username and Purpose=@purpose and StartDate=@startdate"))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@purpose", purpose);
                   cmd.Parameters.AddWithValue("@StartDate", startdate);
                    cmd.Connection = conn;
                    //conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
               
                }
            }
            this.BindGrid();
           

        }

        private void BindGrid()
        {
            string constr = "Data Source=.;Initial Catalog=sample2;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username, Purpose, StartDate, EndDate,StatusNotif FROM LeaveRequests where username='" + username + "' order by lid desc"))
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



    }
}