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
            if (Session["Token"] == null)
                Session["Token"] = false;
            if ((bool)Session["Token"] == true)
                Response.Redirect("~/functionality/SR.aspx.");
            if (Session["Login"] != null)
            {
                if ((bool)Session["Login"] == true)
                {
                    Response.Write("<script>alert('You need to login before using the application.');</script>");
                    Session["Login"] = false;
                }
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "" && TextBoxPassword.Text == "")
            {
                Response.Write("<script>alert('Please enter a username and password!');</script>");
                return;
            }

            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", myConnection);

                cmd.Parameters.AddWithValue("@Username", TextBoxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", TextBoxPassword.Text);

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Session["Token"] = true;
                    Session["Username"] = TextBoxUsername.Text;
                    Session["Password"] = TextBoxPassword.Text;
                    Response.Redirect("~/functionality/SR.aspx");
                }
                else
                    Response.Write("<script>alert('Invalid Username or Password!');</script>");

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void ButtonForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForgotPassword.aspx");
        }
    }
}