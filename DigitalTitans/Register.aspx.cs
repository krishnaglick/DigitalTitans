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
                SqlCommand cmd = new SqlCommand("newMembers", myConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", CreateUserWizard1.UserName);
                cmd.Parameters.AddWithValue("@Password", CreateUserWizard1.Password);
                cmd.Parameters.AddWithValue("@EmailAddress", CreateUserWizard1.Email);
                cmd.Parameters.AddWithValue("@SecurityQuestion", CreateUserWizard1.Question);
                cmd.Parameters.AddWithValue("@SecurityAnswer", CreateUserWizard1.Answer);
                myConnection.Open();

                int temp = cmd.ExecuteNonQuery();
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Login Failed!');", true);
            }
        }
    }  
}