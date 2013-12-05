using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.functionality
{
    public partial class SR : System.Web.UI.Page
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
            SqlDataSource1.ConnectionString = "Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI";
            SqlDataSource1.SelectCommand = "SELECT SkillName as [Skill Name], SkillDescription as [Skill Description], UserRating as [Personal Rating] FROM Skills WHERE Username = '" + Session["Username"].ToString() + "'";
        }

        protected void ButtonSkillRateFunTimes_Click(object sender, EventArgs e)
        {
            ButtonSkillRateFunTimes.Visible = false;
            ButtonSkillAddFunTimes.Visible = false;
            GridView1.Visible = false;
            ListBoxEditingSkillList.Visible = true;
            LabelChooseSkillToRate.Visible = true;
            RadioButtonListRatingOptions.Visible = true;
            LabelSkillRating.Visible = true;
            ListBoxEditingSkillList.Items.Clear();
            ListBoxEditingSkillList.ClearSelection();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                SqlCommand cmd = new SqlCommand("SELECT SkillName FROM Skills WHERE Username = @Username", myConnection);

                cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    ListBoxEditingSkillList.Items.Add(rdr.GetValue(0).ToString());
                }

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }
        }

        protected void ButtonSkillAddFunTimes_Click(object sender, EventArgs e)
        {
            ButtonSkillRateFunTimes.Visible = false;
            ButtonSkillAddFunTimes.Visible = false;
            GridView1.Visible = false;
            LabelNewSkillDescription.Visible = true;
            LabelNewSkillName.Visible = true;
            LabelSkillRating.Visible = true;
            TextBoxNewSkillDescription.Visible = true;
            TextBoxNewSkillName.Visible = true;
            RadioButtonListRatingOptions.Visible = true;
        }

        protected void RadioButtonListRatingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEditingSkillList.Visible == true)
            {
                if (ListBoxEditingSkillList.SelectedIndex < 0)
                {
                    RadioButtonListRatingOptions.ClearSelection();
                    Response.Write("<script>alert('Please choose a skill!');</script>");
                    return;
                }
                try
                {
                    SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Skills SET UserRating = @Rating WHERE SkillName = @Skillname AND Username = @Username", myConnection);

                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                    cmd.Parameters.AddWithValue("@Skillname", ListBoxEditingSkillList.SelectedValue);
                    cmd.Parameters.AddWithValue("@Rating", Convert.ToInt32(RadioButtonListRatingOptions.SelectedValue));

                    cmd.ExecuteNonQuery();

                    myConnection.Close();
                }
                catch
                {
                    Response.Write("<script>alert('Sorry, there was an error updating the rating. Find your neatest IT Support and bitch that lazy schmuck out.');</script>");
                }
            }
            else
            {
                if (TextBoxNewSkillName.Text == "")
                {
                    Response.Write("<script>alert('Please name the skill.');</script>");
                    return;
                }
                try
                {
                    SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Skills (SkillName, SkillDescription, Username, UserRating) VALUES (@Skillname, @SkillDescription, @Username, @Rating)", myConnection);

                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                    cmd.Parameters.AddWithValue("@Skillname", TextBoxNewSkillName.Text);
                    cmd.Parameters.AddWithValue("@SkillDescription", TextBoxNewSkillDescription.Text);
                    cmd.Parameters.AddWithValue("@Rating", Convert.ToInt32(RadioButtonListRatingOptions.SelectedValue));

                    cmd.ExecuteNonQuery();

                    myConnection.Close();
                }
                catch
                {
                    Response.Write("<script>alert('You already have a Skill with that name!');</script>");
                }
            }

            LabelNewSkillDescription.Visible = false;
            LabelNewSkillName.Visible = false;
            TextBoxNewSkillDescription.Visible = false;
            TextBoxNewSkillName.Visible = false;

            ListBoxEditingSkillList.Visible = false;
            RadioButtonListRatingOptions.Visible = false;
            LabelChooseSkillToRate.Visible = false;
            LabelSkillRating.Visible = false;
            ButtonSkillRateFunTimes.Visible = true;
            GridView1.Visible = true;
            ButtonSkillAddFunTimes.Visible = true;

            TextBoxNewSkillDescription.Text = "";
            TextBoxNewSkillName.Text = "";
            RadioButtonListRatingOptions.ClearSelection();

            GridView1.DataBind();
        }
    }
}