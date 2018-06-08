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
    public partial class EmployeeAttendance : System.Web.UI.Page
    {
        string stat;

        string sta = "1";
        CheckBox chk1 = new CheckBox();
        CheckBox chk2 = new CheckBox();
        DateTime t1 = DateTime.Parse("09:30:00.000");
        DateTime t2 = DateTime.Parse("18:25:00.000");
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

                DateTime d1 = DateTime.Today;
                TextBox1.Text = d1.ToShortDateString();
                string CS = "data source = .; database = sample2; integrated security = SSPI";

                if ((DateTime.Now < t1) || (DateTime.Now > t3))
                {
                    GridView1.Visible = false;
                    Response.Write("Attendance Cannot be Submitted Now!!!Please try again in valid time slot");

                }

                else
                {
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Att", con);
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds);
                        DataRow dr = ds.Tables[0].Rows[0];
                        con.Open();
                        if ((string)Session["d"] == "vh")
                        {
                            SqlCommand dy = new SqlCommand("select max(Attendance_Date) from att where username=@username", con);
                            dy.Parameters.AddWithValue("@username", us);
                            String ab = Convert.ToString(dy.ExecuteScalar());
                            
                            TextBox3.Text = ab;
                        }
                        else
                        {
                            TextBox3.Text = (string)Session["d"];
                        }

                        Response.Write(TextBox3.Text + "<br/>" + TextBox1.Text);

                        if (TextBox3.Text == TextBox1.Text)
                        {
                            SqlCommand dt = new SqlCommand("update Att set Attendance_Date = @Attendance_Date where username=@username and Attendance_Date=@Attendance_Date ; select * from Att where username=@username and Attendance_Date=@Attendance_Date;", con);
                            dt.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                            dt.Parameters.AddWithValue("@username", us);
                            
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
                            SqlCommand dm = new SqlCommand("select * from Att where username=@username and Attendance_Date=@Attendance_Date;", con);
                            dm.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                            dm.Parameters.AddWithValue("@username", us);
                       

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
                        using (SqlConnection co = new SqlConnection(CS))
                        {
                            SqlCommand cmd = new SqlCommand("Select Attendance_Status from att where username=@username and Attendance_date=@Attendance_Date", co);
                            cmd.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                            cmd.Parameters.AddWithValue("@username", (string)Session["Username"]);
                            co.Open();
                            sta = cmd.ExecuteScalar().ToString();
                        }
                        if (sta == "1")
                        {
                            Button1.Enabled = false;
                            Response.Write("Attendance Already Marked!!!");
                        }
                        else
                        {
                            chk1.Enabled = true;
                        }

                        // Application["flag"] = 1;
                    }
                    
                    else if ((DateTime.Now > t2) && (DateTime.Now < t3))
                    {
                        stat = "0";
                        Button1.Enabled = true;
                        using (SqlConnection co = new SqlConnection(CS))
                        {
                            SqlCommand cmd = new SqlCommand("Select Attendance_Status from att where username=@username and Attendance_date=@Attendance_Date", co);
                            cmd.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                            cmd.Parameters.AddWithValue("@username", (string)Session["Username"]);
                            co.Open();
                            stat = cmd.ExecuteScalar().ToString();
                        }
                        if (stat == "1"&&sta!="1")
                        {
                            Button1.Enabled = false;
                            Response.Write("Attendance Already Marked!!!");
                        }
                        else
                        {
                            chk2.Enabled = true;
                            //Application["flag"] = (int)Application["flag"]+1;
                        }
                    }
                    /*else if ((DateTime.Now < t1) || (DateTime.Now > t3))
                    {
                        GridView1.Visible = false;
                        Response.Write("Attendance Cannot be Submitted Now!!!Please try again in valid time slot");
                        Button1.Enabled = false;
                    }*/

                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now < t1) || (DateTime.Now > t3))
            {
                GridView1.Visible = false;
                Response.Write("Attendance Cannot be Submitted Now!!!Please try again in valid time slot");

            }
            else
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

                    //Session["flag"] = 0;
                    if ((chk1.Checked == false) && (chk2.Checked == false))
                    {

                        GridView1.DataSource = cmd1.ExecuteReader();
                        GridView1.DataBind();

                    }

                    else if ((chk1.Checked == true && chk2.Checked == false) || (chk1.Checked == false && chk2.Checked == true))
                    {

                        using (SqlConnection co = new SqlConnection(CS))
                        {
                            SqlCommand cmd = new SqlCommand("Select Attendance_Status from att where username=@username and Attendance_date=@Attendance_Date", co);
                            cmd.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                            cmd.Parameters.AddWithValue("@username", (string)Session["Username"]);
                            co.Open();
                            string c = cmd.ExecuteScalar().ToString();
                            if (c == "1"||c=="2")
                            {
                                //  Session["flag"] = 1;
                                GridView1.DataSource = cmd3.ExecuteReader();

                                GridView1.DataBind();
                            }
                            else
                            {


                                GridView1.DataSource = cmd2.ExecuteReader();
                                GridView1.DataBind();
                            }
                        }
                    }


                    


                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}