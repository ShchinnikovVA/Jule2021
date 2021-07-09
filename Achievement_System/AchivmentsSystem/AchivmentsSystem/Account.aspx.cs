using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using AS.BLL;
using AS.Entities;
using AS.BLL.Interface;
using AS.Dependencies;

namespace AchivmentsSystem
{
    public partial class Account : System.Web.UI.Page
    {
        int list_id = 1;
        string ID_USER;
        User this_user = null;
        Achievement achievements = null;
        //HttpCookie this_id = new HttpCookie("This_ID");
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_USER = Application["This_User"].ToString();
            this_user = DependencyResolver.Instance.BLL_Logic.ReaderUser(Convert.ToInt32(ID_USER));
            achievements = DependencyResolver.Instance.BLL_Logic.ReaderAchievement(this_user.ID);
            //this_id.Value =this_user.ID.ToString();
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
            //achievements = DependencyResolver.Instance.BLL_Logic.ReaderAchievement(this_user.ID);
            /*if(achievements != null)*/
            ListBox1.Items.Insert(list_id, achievements.Name);
            //Label1.Text = achievements.Name;
            /*else*/
            ListBox1.Items.Insert(list_id+1, "help");
            list_id++;
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