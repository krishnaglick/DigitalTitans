using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.functionality
{
    public partial class Analyze : System.Web.UI.Page
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

            int temp = DropDownListAllSkills.SelectedIndex;
            DropDownListAllSkills.Items.Clear();
            DropDownListAllSkills.DataBind();
            DropDownListAllSkills.SelectedIndex = temp;
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            LabelNothingHere.Visible = false;
            GridViewMatchingUsers.DataSource = null;
            GridViewMatchingUsers.DataBind();
            try
            {
                SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
                String Op = DropDownListOperators.SelectedValue;
                SqlCommand cmd = new SqlCommand("SELECT Username, UserRating as [Employee Rating], ManagerRating as [Manager Rating] FROM Skills WHERE SkillName = @Skill AND (UserRating " + Op + " @Rating OR ManagerRating " + Op + " @Rating)", myConnection);
                cmd.Parameters.AddWithValue("@Skill", DropDownListAllSkills.SelectedValue);
                cmd.Parameters.AddWithValue("@Rating", RadioButtonListChooseRating.SelectedValue);

                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adptr.Fill(ds, "Skills");

                GridViewMatchingUsers.DataSource = ds.Tables["Skills"];
                GridViewMatchingUsers.DataBind();
                GridViewMatchingUsers.Visible = true;
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }
            if (GridViewMatchingUsers.Rows.Count < 1)
                LabelNothingHere.Visible = true;
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            GridViewMatchingUsers.DataSource = null;
            GridViewMatchingUsers.DataBind();
            GridViewMatchingUsers.Visible = false;
            LabelNothingHere.Visible = false;
            RadioButtonListChooseRating.SelectedIndex = 0;
            DropDownListAllSkills.SelectedIndex = 0;
            DropDownListOperators.SelectedIndex = 0;
        }
    }
}