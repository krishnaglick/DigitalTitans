using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.functionality
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Token"] == null)
                Session["Token"] = false;
            if ((bool)Session["Token"] == false)
            {
                Session["Login"] = true;
                Response.Redirect("~/Login.aspx");
            }
            ButtonCancel_Click(null, null);
        }

        private void ShowThings()
        {
            TextBoxData1.Text = "";
            TextBoxData2.Text = "";
            TextBoxData3.Text = "";
            LabelData1.Visible = true;
            LabelData2.Visible = true;
            LabelData3.Visible = true;
            TextBoxData1.Visible = true;
            TextBoxData2.Visible = true;
            TextBoxData3.Visible = true;
            ButtonAccept.Visible = true;
            ButtonCancel.Visible = true;
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            LabelData1.Text = "Enter Old Password";
            LabelData2.Text = "Enter New Password";
            LabelData3.Text = "Reenter New Password";
            TextBoxData2.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            TextBoxData3.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            ShowThings();
        }

        protected void ButtonChangeEmail_Click(object sender, EventArgs e)
        {
            LabelData1.Text = "Enter Password";
            LabelData2.Text = "Enter New Email";
            LabelData3.Text = "Reenter New Email";
            ShowThings();
        }

        protected void ButtonChangeQA_Click(object sender, EventArgs e)
        {
            LabelData1.Text = "Enter Password";
            LabelData2.Text = "Enter New Security Question";
            LabelData3.Text = "Enter New Security Answer";
            TextBoxData3.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
            ShowThings();
        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
            if (LabelData2.Text == "Enter New Password")
            {
                if (TextBoxData1.Text == Session["Password"].ToString())
                {
                    if (TextBoxData2.Text == TextBoxData3.Text)
                    {
                        try
                        {
                            myConnection.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Users SET Password = @Password WHERE Username = @Username", myConnection);

                            cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                            cmd.Parameters.AddWithValue("@Password", TextBoxData2.Text);

                            cmd.ExecuteNonQuery();

                            Session["Password"] = TextBoxData2.Text;

                            myConnection.Close();
                        }
                        catch
                        {
                            Response.Write("<script>alert('Database Error!');</script>");
                            ButtonChangePassword_Click(null, null);
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Your new passwords do not match!');</script>");
                        ButtonChangePassword_Click(null, null);
                    }
                }
                else
                {
                    Response.Write("<script>alert('You gave the wrong password!');</script>");
                    ButtonChangePassword_Click(null, null);
                }
            }

            if (LabelData2.Text == "Enter New Email")
            {
                if (TextBoxData1.Text == Session["Password"].ToString())
                {
                    if (TextBoxData2.Text == TextBoxData3.Text)
                    {
                        try
                        {
                            myConnection.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Users SET Email = @Email WHERE Username = @Username", myConnection);

                            cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                            cmd.Parameters.AddWithValue("@Email", TextBoxData2.Text);

                            cmd.ExecuteNonQuery();

                            myConnection.Close();
                        }
                        catch
                        {
                            Response.Write("<script>alert('Database Error!');</script>");
                            ButtonChangeEmail_Click(null, null);
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Your new emails do not match!');</script>");
                        ButtonChangeEmail_Click(null, null);
                    }
                }
                else
                {
                    Response.Write("<script>alert('You gave the wrong password!');</script>");
                    ButtonChangeEmail_Click(null, null);
                }
            }

            if (LabelData2.Text == "Enter New Security Question")
            {
                if (TextBoxData1.Text == Session["Password"].ToString())
                {
                    try
                    {
                        myConnection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Users SET SecurityQuestion = @SQ, SecurityAnswer = @SA WHERE Username = @Username", myConnection);

                        cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                        cmd.Parameters.AddWithValue("@SQ", TextBoxData2.Text);
                        cmd.Parameters.AddWithValue("@SA", TextBoxData3.Text);

                        cmd.ExecuteNonQuery();

                        myConnection.Close();
                    }
                    catch
                    {
                        Response.Write("<script>alert('Database Error!');</script>");
                        ButtonChangeEmail_Click(null, null);
                    }
                }
                else
                {
                    Response.Write("<script>alert('You gave the wrong password!');</script>");
                    ButtonChangeEmail_Click(null, null);
                }
            }

            ButtonCancel_Click(null, null);
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            LabelData1.Visible = false;
            LabelData2.Visible = false;
            LabelData3.Visible = false;
            TextBoxData1.Visible = false;
            TextBoxData2.Visible = false;
            TextBoxData3.Visible = false;
            ButtonAccept.Visible = false;
            ButtonCancel.Visible = false;
            TextBoxData1.Text = "";
            TextBoxData2.Text = "";
            TextBoxData3.Text = "";
            TextBoxData2.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
            TextBoxData3.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
        }
    }
}