using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxInput.Focus();
        }

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            if(TextBoxInput.Text == "")
                Response.Write("<script>alert('Please enter an email.');</script>");
            try
            {
                SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT SecurityQuestion FROM Users WHERE Email = @Email", myConnection);

                cmd.Parameters.AddWithValue("@Email", TextBoxInput.Text);

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    TextBoxSA.Visible = true;
                    LabelSA.Visible = true;
                    LabelSQ.Visible = true;
                    ButtonSendEmail.Visible = true;

                    TextBoxInput.Visible = false;
                    LabelAsk.Visible = false;
                    ButtonGo.Visible = false;

                    LabelSQ.Text = rdr.GetValue(0).ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Email');</script>");
                    TextBoxInput.Text = "";
                }

                rdr.Close();
                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }
            TextBoxSA.Focus();
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        protected void ButtonSendEmail_Click(object sender, EventArgs e)
        {
            String newPass = RandomString(8);
            String userName = "";
            String toEmail = "";
            bool CanDo = false;
            try
            {
                SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT SecurityAnswer, Username FROM Users WHERE Email = @Email", myConnection);

                cmd.Parameters.AddWithValue("@Email", TextBoxInput.Text);

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (rdr.GetValue(0).ToString() == TextBoxSA.Text)
                {
                    CanDo = true;
                    userName = rdr.GetValue(1).ToString();
                    toEmail = TextBoxInput.Text;
                }
                else
                {
                    String temp = TextBoxInput.Text;
                    Response.Write("<script>alert('Incorrect Security Answer');</script>");
                    TextBoxInput.Text = temp;
                    ButtonGo_Click(null, null);
                }

                rdr.Close();
                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }

            if (CanDo)
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
                    SqlCommand updatePassword = new SqlCommand("UPDATE Users SET Password = @Password WHERE Email = @Email", myConnection);

                    myConnection.Open();

                    updatePassword.Parameters.AddWithValue("@Email", toEmail);
                    updatePassword.Parameters.AddWithValue("@Password", newPass);

                    updatePassword.ExecuteNonQuery();

                    myConnection.Close();
                }
                catch
                {
                    Response.Write("<script>alert('Database Error, contact your damned sysadmin!');</script>");
                }
                
                try
                {
                    var fromAddress = new MailAddress("DigitalTitansTMS@gmail.com");
                    var toAddress = new MailAddress(toEmail);
                    string fromPassword = "scothancock";
                    string subject = "Password Reset";
                    string body = "You put in a password reset request. If you did not place this request then be aware that" +
                        "someone has your email and security answer. Your very identity is in danger! However, if you did request" +
                        " it then here it is.<br /><br />" + "Username: " + userName + "<br />Password: " + newPass;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = true,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body,
                        BodyEncoding = Encoding.UTF8,
                        IsBodyHtml = true
                    })
                    {
                        smtp.Send(message);
                        Response.Write("<script>alert('Reset email has been sent, please check your email.');</script>");

                        TextBoxSA.Visible = false;
                        LabelSA.Visible = false;
                        LabelSQ.Visible = false;
                        ButtonSendEmail.Visible = false;

                        TextBoxInput.Visible = true;
                        LabelAsk.Visible = true;
                        ButtonGo.Visible = true;

                        TextBoxInput.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}