﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ep
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            Label13.Visible = true;
            if (Page.IsValid)
            {
                Label13.Text = "Your data has been saved";
            }
            else
            {
                Response.Write("Please enter the correct details");
            }
        }
    }
}