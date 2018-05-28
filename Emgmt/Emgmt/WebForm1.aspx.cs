using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace Emgmt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //public String conString = "Data Source=.;Initial Catalog=employee_mgmnt;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=E_MGMT;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

           

        }


        SqlCommand com;

        SqlParameter UserName, Password;
        protected void Button1_Click(object sender, EventArgs e)
        {

            UserName = new SqlParameter();

            Password = new SqlParameter();

            com = new SqlCommand();
            com.Connection = con;
            con.Open();


            Session["UserName"] = TextBox1.Text;

            if (DropDownList1.SelectedValue == "Admin")
            {
                

                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.CommandText = "login_admin";


                UserName.SqlDbType = System.Data.SqlDbType.VarChar;

                UserName.Size = 50;

                UserName.ParameterName = "@username";

                UserName.Value = TextBox1.Text.ToString();

                UserName.Direction = ParameterDirection.Input;



                Password.SqlDbType = System.Data.SqlDbType.VarChar;

                Password.Size = 50;

                Password.ParameterName = "@password";

                Password.Value = TextBox2.Text.ToString();

                Password.Direction = ParameterDirection.Input;



                com.Parameters.Add(UserName);

                com.Parameters.Add(Password);

                int status;

                status = Convert.ToInt16(com.ExecuteScalar());



                if (status == 1)

                {

                    Response.Redirect("Welcome.aspx");

                }

                else

                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password...')", true);


                }

                con.Close();

            }
            if(DropDownList1.SelectedValue=="Employee") {
               


                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.CommandText = "login_pro";


                UserName.SqlDbType = System.Data.SqlDbType.VarChar;

                UserName.Size = 50;

                UserName.ParameterName = "@username";

                UserName.Value = TextBox1.Text.ToString();

                UserName.Direction = ParameterDirection.Input;



                Password.SqlDbType = SqlDbType.VarChar;

                Password.Size = 50;

                Password.ParameterName = "@password";

                Password.Value = TextBox2.Text.ToString();

                Password.Direction = ParameterDirection.Input;



                com.Parameters.Add(UserName);

                com.Parameters.Add(Password);

                int status;

                status = Convert.ToInt16(com.ExecuteScalar());



                if (status == 1)

                {

                    Response.Redirect("Welcome.aspx");

                }

                else

                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password...')", true);


                }

                con.Close();

            }

            


            /*SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into E_MGMT.dbo.details values('"+TextBox1.Text+"','"+TextBox2.Text+"')";
            cmd.ExecuteReader();
            con.Close();*/





            /*if(con.State == System.Data.ConnectionState.Open)
            {

                string q = "insert into details(id,name) values('" + (TextBox1.Text.ToString()) + "','" + TextBox2.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();
                Response.Write("<script> alert('Successful') </ script >");
                
            }*/

        }
    }
}