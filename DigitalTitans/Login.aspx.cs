using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void loginBox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
            SqlCommand cmd = new SqlCommand("userLogin", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", loginBox.UserName);
            cmd.Parameters.AddWithValue("@Password", loginBox.Password);

            myConnection.Open();

            int success = cmd.ExecuteNonQuery();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                SqlCommand cmd = new SqlCommand("userLogin", myConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text);

                myConnection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Session["Token"] = "true";
                    Response.Redirect("~/Home.aspx");
                }
                else
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Login Failed!');", true);

                myConnection.Close();
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Database Error!');", true);
            }
        }
    }
}