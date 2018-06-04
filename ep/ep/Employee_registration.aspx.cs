﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ep
{
    
    public partial class Employee_registration : System.Web.UI.Page
    {
        int c = -1;
        int d = 0;
            
        protected void Page_Load(object sender, EventArgs e)

        {
            
            if (IsPostBack)
            {
                
                ViewState["c"] = (int)ViewState["c"] + 1;

            }
            else
            {
                ViewState["c"] = c;
            }

            if (Session["Username"] == null)
                Response.Redirect("LoginWebForm.aspx");

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                TextBox7.Text = TextBox6.Text;
            }
        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox11.Text = Calendar1.SelectedDate.ToString("d");
            Calendar1.Visible = false;


        }

       protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

        }*/

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string us = (string)Session["username"];
            string cs = "data source = .; database= sample2; integrated security =true;";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("procf",cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@F_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@L_Name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@DOB", TextBox11.Text);
                cmd.Parameters.AddWithValue("@DOJ", TextBox12.Text);
                cmd.Parameters.AddWithValue("@Dpt", DropDownList2.SelectedValue);
                cmd.Parameters.AddWithValue("@P_add", TextBox6.Text);
                cmd.Parameters.AddWithValue("@S_add", TextBox7.Text);
                cmd.Parameters.AddWithValue("@Mobile_no", TextBox8.Text);
                cmd.Parameters.AddWithValue("@email", TextBox9.Text);
                cmd.Parameters.AddWithValue("@Salary", TextBox10.Text);
                cmd.Parameters.AddWithValue("@Off_tm", DropDownList3.SelectedValue);
                cmd.Parameters.AddWithValue("@Emp_ID", ViewState["c"].ToString());
                cmd.Parameters.AddWithValue("@User_name", TextBox13.Text);
                


                cn.Open();
                cmd.ExecuteReader();

            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into Att(Emp_ID,username) values((select Emp_ID from emp_tb where Username=@username),@username)",con);
                cmd.Parameters.AddWithValue("@username", TextBox13.Text);
                con.Open();
                cmd.ExecuteReader();
                
            }
                Response.Write(ViewState["c"].ToString());
            Label13.Visible = true;
            if (Page.IsValid)
            {
                Label13.Text = "Your data has been saved";
            }
            else
            {
                Response.Write("Please enter the correct details");
            }
           

            //if (RequiredFieldValidator1.IsValid)
            //{
            //    TextBox1.BackColor= System.Drawing.Color.Green;
            //}
            //else
            //{
            //    TextBox1.BackColor = System.Drawing.Color.Red;
            //}

            /*TextBox1.BackColor = System.Drawing.Color.Green;*/


        }
    }
}
