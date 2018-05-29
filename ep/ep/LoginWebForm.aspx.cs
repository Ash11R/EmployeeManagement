using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ep
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=sample2;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["d"] = "vh";
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
            if (DropDownList1.SelectedValue == "Select") {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Select something from dropdpwn')", true);

            }

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
            if (DropDownList1.SelectedValue == "Employee")
            {



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
        }
    }
}