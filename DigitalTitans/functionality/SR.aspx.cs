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
            SqlDataSource1.SelectCommand = "SELECT SkillName as [Skill Name], SkillDescription as [Skill Description], UserRating as [Personal Rating], ManagerRating as [Manager Rating] FROM Skills WHERE Username = '" + Session["Username"].ToString() + "'";
            int temp = DropDownListEmployees.SelectedIndex;
            DropDownListEmployees.Items.Clear();
            DropDownListEmployees.Items.Add("Self");
            DropDownListEmployees.DataBind();
            DropDownListEmployees.SelectedIndex = temp;
            if (DropDownListEmployees.Items.Count < 2)
                DropDownListEmployees.Visible = false;
        }

        protected void ButtonSkillRateFunTimes_Click(object sender, EventArgs e)
        {
            ButtonSkillRateFunTimes.Visible = false;
            ButtonPickSkillDelete.Visible = false;
            ButtonSkillAddFunTimes.Visible = false;
            GridView1.Visible = false;
            DropDownListEmployees.Visible = false;

            LabelChooseSkillToRate.Visible = true;
            RadioButtonListRatingOptions.Visible = true;
            LabelSkillRating.Visible = true;
            ButtonCancel.Visible = true;

            LabelChooseSkillToRate.Text = "Choose Skill to Rate";

            DropDownListEditingSkillList.Visible = true;
            DropDownListEditingSkillList.Items.Clear();
            DropDownListEditingSkillList.ClearSelection();

            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                SqlCommand cmd = new SqlCommand("SELECT SkillName FROM Skills WHERE Username = @Username", myConnection);

                if(DropDownListEmployees.SelectedValue == "Self")
                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                else
                    cmd.Parameters.AddWithValue("@Username", DropDownListEmployees.SelectedValue);

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    DropDownListEditingSkillList.Items.Add(rdr.GetValue(0).ToString());
                }

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }
            if (DropDownListEditingSkillList.Items.Count == 0)
            {
                Response.Write("<script>alert('You need to have a skill made, to alter its rating!');</script>");
                HideExtraCrap();
            }
        }

        protected void ButtonSkillAddFunTimes_Click(object sender, EventArgs e)
        {
            ButtonSkillRateFunTimes.Visible = false;
            ButtonPickSkillDelete.Visible = false;
            ButtonSkillAddFunTimes.Visible = false;
            GridView1.Visible = false;
            DropDownListEmployees.Visible = false;

            LabelNewSkillDescription.Visible = true;
            LabelNewSkillName.Visible = true;
            LabelSkillRating.Visible = true;
            TextBoxNewSkillDescription.Visible = true;
            TextBoxNewSkillName.Visible = true;
            RadioButtonListRatingOptions.Visible = true;
            ButtonCancel.Visible = true;
        }

        private void HideExtraCrap()
        {
            LabelNewSkillDescription.Visible = false;
            LabelNewSkillName.Visible = false;
            TextBoxNewSkillDescription.Visible = false;
            TextBoxNewSkillName.Visible = false;

            DropDownListEditingSkillList.Visible = false;
            RadioButtonListRatingOptions.Visible = false;

            RadioButtonListRatingOptions.Visible = false;
            LabelChooseSkillToRate.Visible = false;
            LabelSkillRating.Visible = false;
            ButtonDeleteSkill.Visible = false;
            ButtonCancel.Visible = false;

            ButtonSkillRateFunTimes.Visible = true;
            GridView1.Visible = true;
            ButtonSkillAddFunTimes.Visible = true;
            ButtonPickSkillDelete.Visible = true;
            DropDownListEmployees.Visible = true;

            TextBoxNewSkillDescription.Text = "";
            TextBoxNewSkillName.Text = "";
            RadioButtonListRatingOptions.ClearSelection();

            GridView1.DataBind();

            DropDownListEmployees_SelectedIndexChanged(null, null);
        }

        protected void RadioButtonListRatingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListEditingSkillList.Visible == true)
            {
                try
                {
                    SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = myConnection;

                    if (DropDownListEmployees.SelectedValue == "Self")
                    {
                        cmd.CommandText = "UPDATE Skills SET UserRating = @Rating WHERE SkillName = @Skillname AND Username = @Username";
                        cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE Skills SET ManagerRating = @Rating WHERE SkillName = @Skillname AND Username = @Username";
                        cmd.Parameters.AddWithValue("@Username", DropDownListEmployees.SelectedValue);
                    }
                    cmd.Parameters.AddWithValue("@Skillname", DropDownListEditingSkillList.SelectedValue);
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
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = myConnection;

                    if (DropDownListEmployees.SelectedValue == "Self")
                    {
                        cmd.CommandText = "INSERT INTO Skills (SkillName, SkillDescription, Username, UserRating) VALUES (@Skillname, @SkillDescription, @Username, @Rating)";
                        cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Skills (SkillName, SkillDescription, Username, ManagerRating) VALUES (@Skillname, @SkillDescription, @Username, @Rating)";
                        cmd.Parameters.AddWithValue("@Username", DropDownListEmployees.SelectedValue);
                    }  
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

            HideExtraCrap();
        }

        protected void ButtonPickSkillDelete_Click(object sender, EventArgs e)
        {
            ButtonSkillRateFunTimes.Visible = false;
            ButtonSkillAddFunTimes.Visible = false;
            ButtonPickSkillDelete.Visible = false;
            GridView1.Visible = false;
            ButtonCancel.Visible = true;
            LabelChooseSkillToRate.Visible = true;
            ButtonDeleteSkill.Visible = true;
            DropDownListEmployees.Visible = false;

            DropDownListEditingSkillList.Visible = true;
            DropDownListEditingSkillList.Items.Clear();
            DropDownListEditingSkillList.ClearSelection();

            LabelChooseSkillToRate.Text = "Choose Skill to Delete";

            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                SqlCommand cmd = new SqlCommand("SELECT SkillName FROM Skills WHERE Username = @Username", myConnection);
                cmd.Connection = myConnection;

                if (DropDownListEmployees.SelectedValue == "Self")
                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                else
                    cmd.Parameters.AddWithValue("@Username", DropDownListEmployees.SelectedValue);

                myConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DropDownListEditingSkillList.Items.Add(rdr.GetValue(0).ToString());
                }

                rdr.Close();

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Database Error!');</script>");
            }

            if (DropDownListEditingSkillList.Items.Count == 0)
            {
                Response.Write("<script>alert('You have to have a skill to delete in the first place!');</script>");
                HideExtraCrap();
                return;
            }
        }

        protected void ButtonDeleteSkill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=lyra2.unfcsd.unf.edu;Initial Catalog=DigitalTitans;Persist Security Info=True;User ID=DigitalTitans;Password=xahhxqlwyGp09zI");
                myConnection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Skills WHERE SkillName = @Skillname AND Username = @Username", myConnection);

                if (DropDownListEmployees.SelectedValue == "Self")
                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());
                else
                    cmd.Parameters.AddWithValue("@Username", DropDownListEmployees.SelectedValue);
                cmd.Parameters.AddWithValue("@Skillname", DropDownListEditingSkillList.SelectedValue);

                cmd.ExecuteNonQuery();

                myConnection.Close();
            }
            catch
            {
                Response.Write("<script>alert('Unable to exterminate targeted je- I mean skill! Yeah, skill...');</script>");
            }

            HideExtraCrap();
        }

        protected void DropDownListEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListEmployees.SelectedValue == "Self")
            {
                SqlDataSource1.SelectCommand = "SELECT SkillName as [Skill Name], SkillDescription as [Skill Description], UserRating as [Personal Rating], ManagerRating as [Manager Rating] FROM Skills WHERE Username = '" + Session["Username"].ToString() + "'";
                GridView1.DataBind();
            }
            else
            {
                SqlDataSource1.SelectCommand = "SELECT SkillName as [Skill Name], SkillDescription as [Skill Description], UserRating as [Personal Rating], ManagerRating as [Manager Rating] FROM Skills WHERE Username = '" + DropDownListEmployees.SelectedValue + "'";
                GridView1.DataBind();
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            HideExtraCrap();
        }
    }
}