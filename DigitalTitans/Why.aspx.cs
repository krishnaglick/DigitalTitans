using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class policies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Token"] == null)
                Session["Token"] = false;
            /*TextBox2Name.Text = Session["Name"].ToString();
            TextBox2Email.Text = Session["Email"].ToString();
            TextBox2Phone.Text = Session["Phone"].ToString();
            TextBox1Name.Text = Request["name"].ToString();
            TextBox1Email.Text = Request["email"].ToString();
            TextBox1Phone.Text = Request["phone"].ToString();
            if (Request == null)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('1');", true);
            if (Request.Cookies == null)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('2');", true);
            if (Request.Cookies["Cookie"] == null)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('3');", true);
            if (Request.Cookies["Cookie"]["Name"] == null)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('4');", true);
            TextBox1.Text = Request.Cookies["Cookie"]["Name"];
            TextBox2.Text = Request.Cookies["Cookie"]["Email"];
            TextBox3.Text = Request.Cookies["Cookie"]["Phone"];
            Label10.Text = Request.Cookies["Cookie"]["LastVisit"];*/
        }
            /*Application.Lock();
            int acount = Convert.ToInt32(Application["count"]);
            acount++;
            Application["count"] = acount;
            Application.UnLock();
            TextBox2Name.Text = Application["count"].ToString();*/
    }
}