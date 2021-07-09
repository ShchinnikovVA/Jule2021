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

namespace AchivmentsSystem
{
    public partial class Account : System.Web.UI.Page
    {
        string ID_USER;
        User this_user = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_USER = Application["This User"].ToString();
            var bll = new AS_Logic();
            this_user = bll.ReaderUser(Convert.ToInt32(ID_USER));
            Label1.Text = this_user.Name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAchievement.aspx");
        }
    }
}