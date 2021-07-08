using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AS.DAL
{
    public class AchDAL
    {
        public const string _FILES_PATCH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Рабочее пространство\Парктика 2021\Jule2021\Achievement_System\AchivmentsSystem\Files\AchievementSystem.mdf;Integrated Security=True;Connect Timeout=30";
        
        public void AddAchievement(Achievement achievement)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Achievement VALUES ( @Name, @Text, @Points)";
                //command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Text", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Points", SqlDbType.Int);

                //int id = achievement.ID;
                string name = achievement.Name;
                string text = achievement.Text;
                int point = achievement.Points;

                //command.Parameters["@Id"].Value = id;
                command.Parameters["@Name"].Value = name;
                command.Parameters["@Text"].Value = text;
                command.Parameters["@Points"].Value = point;

                command.ExecuteNonQuery();
            }
        }
        public void RemoveAchievement(int id)
        {
            

        }
        public void EditAchievement(int id, string name, string text, int points)
        {
            if(name == null)
            {

            }
            if(text == null)
            {

            }
        }
    }
}
