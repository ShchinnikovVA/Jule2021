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
    public partial class Account : System.Web.UI.Page
    {
        SqlConnection userData;
        protected async void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Рабочее пространство\Парктика 2021\Jule2021\Achievement_System\Achievement_System\Achievements.mdf;Integrated Security=True;Connect Timeout=30";
            userData = new SqlConnection(connectionString);
            await userData.OpenAsync();//позвляет быстро открывать соединение с бд
            SqlDataReader sqlReader = null;
            SqlCommand loadUserName = new SqlCommand("SELECT [Имя] FROM User", userData);
            try
            {
                sqlReader = await loadUserName.ExecuteReaderAsync();
                Label1.Text = Convert.ToString(sqlReader["Имя"]);
            }
            catch(Exception ex)
            {
                Label1.Text = "UserError";
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

    }
}