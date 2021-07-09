using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using AS.Entities;
using AS.BLL;
using AS.BLL.Interface;
using AS.Dependencies;

namespace AchivmentsSystem
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != null)
            {
                if (TextBox2.Text != null)
                {
                    var userData = DependencyResolver.Instance.BLL_Logic.LoginPassword(TextBox1.Text, TextBox2.Text);
                    Dictionary<string, string> list = new Dictionary<string, string>();
                    list.Add(userData.Login, userData.Password);
                    if (list.ContainsKey(TextBox1.Text))
                        if (list[TextBox1.Text] == TextBox2.Text)
                        {
                            Application["This_User"] = userData.ID.ToString();
                            Response.Redirect("Account.aspx");
                        }
                        else
                            Label3.Text = "Неверно указан пароль";
                    else
                        Label3.Text = "Неверно указан логин";
                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DependencyResolver.Instance.BLL_Logic.AddUser(new User(TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox7.Text));
            //bll.AddMap(new Map(000, 1));
        }
    }
}