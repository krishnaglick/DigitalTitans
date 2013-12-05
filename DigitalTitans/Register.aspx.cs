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
            if (Session["Token"] == null)
                Session["Token"] = false;
            if ((Boolean)Session["Token"] == true)
            {
                Response.Redirect("~/functionality/SR.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                myConnection.Open();
                SqlCommand cmd = new SqlCommand("newMembers", myConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", user.Text);
                cmd.Parameters.AddWithValue("@Pass", pass.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", em.Text);
                cmd.Parameters.AddWithValue("@SecurityQ", sq.Text);
                cmd.Parameters.AddWithValue("@SecurityA", sa.Text);

                cmd.ExecuteNonQuery();

                Session["Token"] = true;
                Session["Username"] = user.Text;
                Session["Password"] = pass.Text;
                Response.Redirect("~/functionality/SR.aspx");

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Sorry, that username is taken.');</script>");
            }
        }
    }  
}