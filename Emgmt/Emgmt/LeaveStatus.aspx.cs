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
    public partial class LeaveStatus : System.Web.UI.Page
    {

        string connetionString;
        SqlConnection conn;
        string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
                username = Session["UserName"].ToString();


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
                using (SqlCommand cmd = new SqlCommand("SELECT username, Purpose, StartDate, EndDate,StatusNotif FROM LeaveRequests where username='"+username+"'"))
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