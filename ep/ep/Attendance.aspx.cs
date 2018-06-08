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
    public partial class Attendance : System.Web.UI.Page
    {
        
        CheckBox chk1 = new CheckBox();
        CheckBox chk2 = new CheckBox();
        DateTime t1 = DateTime.Parse("09:30:00.000");
        DateTime t2 = DateTime.Parse("13:30:00.000");
        DateTime t3 = DateTime.Parse("20:30:00.000");




        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (Session["username"] == null)
            {
                Response.Redirect("LoginWebForm.aspx");
            }
            TextBox2.Text = Convert.ToString(DateTime.Now.DayOfWeek);
            if (!IsPostBack)
            {



                string us = (string)Session["username"];
                Response.Write(us);

                DateTime d1 = DateTime.Now;
                TextBox1.Text = d1.ToShortDateString();
                string CS = "data source = .; database = sample2; integrated security = SSPI";

                

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Att", con);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    if((string)Session["d"]=="vh")
                    { TextBox3.Text = dr[3].ToString(); }
                    else
                    {
                        TextBox3.Text = (string)Session["d"];
                    }
                    
                    Response.Write(TextBox3.Text + "<br/>" + TextBox1.Text);
                    
                    if (TextBox3.Text == TextBox1.Text)
                    {
                        SqlCommand dt = new SqlCommand("update Att set Attendance_Date = @Attendance_Date where username=@username and Attendance_Date=@Attendance_Date ; select * from Att;", con);
                        dt.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                        dt.Parameters.AddWithValue("@username", us);
                        con.Open();
                        GridView1.DataSource = dt.ExecuteReader();
                        GridView1.DataBind();
                    }
                    else
                    {

                        SqlCommand dt = new SqlCommand("insert into Att(Attendance_Date,username,Emp_ID) values(@Attendance_Date,@username,(select Emp_ID from emp_tb where username=@username))", con);
                        dt.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                        Session["d"] = TextBox1.Text;
                    
                        Response.Write(TextBox3.Text);
                        dt.Parameters.AddWithValue("@username", us);
                        SqlCommand df = new SqlCommand("update Att set Emp_Name=(select F_name from emp_tb where username=@username) where  username=@username and Attendance_date=@Attendance_Date", con);
                        df.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                        df.Parameters.AddWithValue("@username", us);
                        SqlCommand dm = new SqlCommand("select * from Att", con);

                        con.Open();
                        
                        int k = dt.ExecuteNonQuery();
                        int y = df.ExecuteNonQuery();
                        GridView1.DataSource = dm.ExecuteReader();
                        GridView1.DataBind();

                    }
                }
                if (TextBox2.Text == "Sunday" || TextBox2.Text == "Saturday")
                {
                    GridView1.Visible = false;
                    Button1.Enabled = false;
                    Response.Write("Not a Working Day!!!Can't Mark Attendance");
                }


                foreach (GridViewRow row in GridView1.Rows)
                {
                    chk1 = row.Cells[5].FindControl("CheckBox1") as CheckBox;
                    chk2 = row.Cells[6].FindControl("CheckBox2") as CheckBox;

                    chk1.Enabled = false;
                    chk2.Enabled = false;
                }

                if ((DateTime.Now > t1) && (DateTime.Now < t2))
                {


                    chk1.Enabled = true;
                }
                else if ((DateTime.Now > t2) && (DateTime.Now < t3))
                {

                    chk2.Enabled = true;
                }
                else if ((DateTime.Now < t1) || (DateTime.Now > t3))
                {
                    GridView1.Visible = false;
                    Response.Write("Attendance Cannot be Submitted Now!!!Please try again in valid time slot");
                    Button1.Enabled = false;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your Attendance has been saved");
            foreach (GridViewRow row in GridView1.Rows)
            {
                chk1 = row.Cells[5].FindControl("CheckBox1") as CheckBox;
                chk2 = row.Cells[6].FindControl("CheckBox2") as CheckBox;
            }

            string CS = "data source = .; database = sample2; integrated security = SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {


                SqlCommand cmd1 = new SqlCommand("update Att set Attendance_Status = 0", con);
                SqlCommand cmd2 = new SqlCommand("update Att set Attendance_Status = 1", con);
                SqlCommand cmd3 = new SqlCommand("update Att set Attendance_Status = 2", con);
                con.Open();


                if ((chk1.Checked == false) && (chk2.Checked == false))
                {

                    GridView1.DataSource = cmd1.ExecuteReader();
                    GridView1.DataBind();

                }
                else if ((chk1.Checked == true && chk2.Checked == false) || (chk1.Checked == false && chk2.Checked == true))
                {


                    GridView1.DataSource = cmd2.ExecuteReader();

                    GridView1.DataBind();
                }


                else
                {


                    GridView1.DataSource = cmd3.ExecuteReader();
                    GridView1.DataBind();
                }


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}