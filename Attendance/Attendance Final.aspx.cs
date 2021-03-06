﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace P1
{
    public partial class Attendance_Final : System.Web.UI.Page
    {
        CheckBox chk1 = new CheckBox();
        CheckBox chk2 = new CheckBox();
        DateTime t1 = DateTime.Parse("09:30:00.000");
        DateTime t2 = DateTime.Parse("13:30:00.000");
        DateTime t3 = DateTime.Parse("18:30:00.000");
        


        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Text = Convert.ToString(DateTime.Now.DayOfWeek);
            if (!IsPostBack)
            {


                
                DateTime d1 = DateTime.Now;
                TextBox1.Text = d1.ToShortDateString();
                string CS = "data source = .; database = mydb; integrated security = SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand dt = new SqlCommand("select * from Att;update Att set Attendance_Date = @Attendance_Date", con);
                    dt.Parameters.AddWithValue("@Attendance_Date", TextBox1.Text);
                    con.Open();
                    GridView1.DataSource = dt.ExecuteReader();
                    GridView1.DataBind();

                }
                if(TextBox2.Text == "Sunday" || TextBox2.Text == "Saturday")
                {
                    GridView1.Visible = false;
                    Button1.Enabled = false;
                    Response.Write("Not a Working Day!!!Can't Mark Attendance");
                }


                foreach (GridViewRow row in GridView1.Rows)
                {
                    chk1 = row.Cells[4].FindControl("CheckBox1") as CheckBox;
                    chk2 = row.Cells[5].FindControl("CheckBox2") as CheckBox;

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
                chk1 = row.Cells[4].FindControl("CheckBox1") as CheckBox;
                chk2 = row.Cells[5].FindControl("CheckBox2") as CheckBox;
            }

            string CS = "data source = .; database = mydb; integrated security = SSPI";
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