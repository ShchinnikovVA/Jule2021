using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AS.Entities;
using AS.BLL;

namespace AchivmentsSystem
{
    public partial class CreateAchievement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bll = new AS_Logic();
            bll.AddAchievement(new Achievement(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text)));
        }
    }
}