using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

/*        protected void Button1_Click(object sender, EventArgs e)
        {
            double temp;
            bool isNum = double.TryParse(Textbox1.Text, out temp);
            if (isNum)
                TextBox2.Text = Convert.ToString(Convert.ToDouble(Textbox1.Text) * 1.25);
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Please enter a number!');", true);
                Textbox1.Text = "";
                TextBox2.Text = "";
            }
            int count = Convert.ToInt32(ViewState["count"]);
            count++;
            Application.Lock();
            int acount = Convert.ToInt32(Application["count"]);
            acount++;
            Application["count"] = acount;
            Application.UnLock();
            ViewState["count"] = count;
            TextBox2ndOutput.Text = ViewState["count"].ToString() + "," + Application["count"].ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBox2ndInput.Text == "")
                return;
            double temp;
            bool isNum = double.TryParse(TextBox2ndInput.Text, out temp);
            if (isNum)
                TextBox2ndOutput.Text = Convert.ToString(Convert.ToDouble(TextBox2ndInput.Text) * Convert.ToDouble(DropDownList1.SelectedValue));
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Please enter a number!');", true);
                TextBox2ndOutput.Text = "";
                TextBox2ndInput.Text = "";
            }
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            if (Textbox3Phone.Text == "" || Textbox3Email.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Email and/or Phone cannot be left blank!');", true);
                return;
            }
            Label4.Text = Textbox3Name.Text + "'s Phone: " + Textbox3Phone.Text + " & Email: " + Textbox3Email.Text;
            Session["Name"] = Textbox3Name.Text;
            Session["Phone"] = Textbox3Phone.Text;
            Session["Email"] = Textbox3Email.Text;
            String query = "name=" + Textbox3Name.Text + "&phone=" + Textbox3Phone.Text + "&email=" + Textbox3Email.Text;

            HttpCookie Cookie = new HttpCookie("Cookie");
            Cookie.Values["Name"] = Textbox3Name.Text;
            Cookie.Values["Phone"] = Textbox3Phone.Text;
            Cookie.Values["Email"] = Textbox3Email.Text;
            DateTime temp = DateTime.Now;
            Cookie.Values["LastVisit"] = temp.ToString();
            temp = DateTime.Now.AddDays(1);
            Cookie.Expires = temp;
            Response.Cookies.Add(Cookie);

            Response.Redirect("Policies.aspx?" + query);
        }*/
    }
}