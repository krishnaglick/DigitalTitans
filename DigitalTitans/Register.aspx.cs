using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.functionality
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                myConnection.Open();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Connection Open!');", true);
                SqlCommand cmd = new SqlCommand("newMembers", myConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", CreateUserWizard1.UserName);
                cmd.Parameters.AddWithValue("@Pass", CreateUserWizard1.Password);
                cmd.Parameters.AddWithValue("@EmailAddress", CreateUserWizard1.Email);
                cmd.Parameters.AddWithValue("@SecurityQ", CreateUserWizard1.Question);
                cmd.Parameters.AddWithValue("@SecurityA", CreateUserWizard1.Answer);

                int temp = cmd.ExecuteNonQuery();

                if(temp == 0)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Register Failed! Username in use!');", true);
                else
                    Response.Redirect("~/functionality/SR.aspx");
                myConnection.Close();
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Login Failed!');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                myConnection.Open();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Connection Open!');", true);
                SqlCommand cmd = new SqlCommand("newMembers", myConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", user.Text);
                cmd.Parameters.AddWithValue("@Pass", pass.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", em.Text);
                cmd.Parameters.AddWithValue("@SecurityQ", sq.Text);
                cmd.Parameters.AddWithValue("@SecurityA", sa.Text);

                int temp = cmd.ExecuteNonQuery();

                if (temp == 0)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Register Failed! Username in use!');", true);
                else
                    Response.Redirect("~/functionality/SR.aspx");
                myConnection.Close();
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Login Failed!');", true);
            }
        }
    }  
}