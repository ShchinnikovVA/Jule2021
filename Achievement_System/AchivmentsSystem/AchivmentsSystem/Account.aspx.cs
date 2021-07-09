using System;
using System.Collections.Generic;
using AS.Entities;
using AS.Dependencies;

namespace AchivmentsSystem
{
    public partial class Account : System.Web.UI.Page
    {
        int list_id = 1;
        string ID_USER;
        User this_user = null;
        List<Achievement> achievements = new List<Achievement>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_USER = Application["This_User"].ToString();
            this_user = DependencyResolver.Instance.BLL_Logic.ReaderUser(Convert.ToInt32(ID_USER));
            achievements =DependencyResolver.Instance.BLL_Logic.ReadAchievement(this_user.ID);
            SetNameText();
            GetAchievement();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAchievement.aspx");
        }
        public void SetNameText()
        {
            Label1.Text = this_user.Name;
            Label2.Text = this_user.Name;
            Label3.Text = this_user.Surname;
            Label4.Text = this_user.MiddleName;
            Label5.Text = this_user.EMail;
            Label6.Text = this_user.Phone_Number.ToString();
            if (Label6.Text == "0") Label6.Text = "";
        }
        public void GetAchievement()
        {
            for(int i = 1; i < achievements.Count ; i++)
            {
                ListBox1.Items.Insert(list_id, achievements[i].Name + " " + achievements[i].Text + " " + achievements[i].Points.ToString());
                list_id++;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Panel1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DependencyResolver.Instance.BLL_Logic.EditUser(
                Convert.ToInt32(this_user.ID),
                TextBox1.Text,
                TextBox2.Text,
                TextBox3.Text,
                TextBox4.Text,
                TextBox5.Text,
                TextBox6.Text,
                Convert.ToInt32(TextBox7.Text)
             );
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            TextBox1.Text = this_user.Login;
            TextBox2.Text = this_user.Password;
            TextBox3.Text = this_user.Name;
            TextBox4.Text = this_user.Surname;
            TextBox5.Text = this_user.MiddleName;
            TextBox6.Text = this_user.EMail;
            TextBox7.Text = this_user.Phone_Number.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            DependencyResolver.Instance.BLL_Logic.RemoveUser(this_user.ID);
            Response.Redirect("Login.aspx");
        }
    }
}