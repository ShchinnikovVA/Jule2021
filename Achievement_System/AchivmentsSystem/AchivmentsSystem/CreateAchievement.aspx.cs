using System;
using AS.Entities;
using AS.Dependencies;

namespace AchivmentsSystem
{
    public partial class CreateAchievement : System.Web.UI.Page
    {
        string ID_USER;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_USER = Application["This_User"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e) // Добавить
        {
            DependencyResolver.Instance.BLL_Logic.AddAchievement(new Achievement(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text)));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Account.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox8.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e) // обновить
        {
            DependencyResolver.Instance.BLL_Logic.EditAchievement(Convert.ToInt32(TextBox4.Text), TextBox5.Text, TextBox6.Text, TextBox7.Text);
        }

        protected void Button2_Click(object sender, EventArgs e) // удалить
        {
            DependencyResolver.Instance.BLL_Logic.RemoveAchievement(Convert.ToInt32(TextBox8.Text));
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DependencyResolver.Instance.BLL_Logic.AddMap(new Map(Convert.ToInt32(ID_USER), Convert.ToInt32(TextBox9.Text)));
        }
    }
}