using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AchivmentsSystem
{
    public partial class LogIn : System.Web.UI.Page
    {
        SqlConnection userData;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("admin", "admin");
            if (list.ContainsKey(TextBox1.Text))
                if (list[TextBox1.Text] == TextBox2.Text)
                    Response.Redirect("Account.aspx");
                else
                    Label3.Text = "Неверно указан пароль";
            else
                Label3.Text = "Неверно указан логин";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }
    }
}