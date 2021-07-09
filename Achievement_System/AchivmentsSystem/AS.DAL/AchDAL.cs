using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AS.DAL.Interface;

namespace AS.DAL
{
    public class AchDAL : IAchievementSystemDAL_A
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
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Achievement WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }

        }
        public void EditAchievement(int id, string name, string text, int points)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE Achievement SET Name = @Name, Text = @Text, Points = @Points WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Text", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Points", SqlDbType.Int);

                command.Parameters["@Id"].Value = id;
                command.Parameters["@Name"].Value = name;
                command.Parameters["@Text"].Value = text;
                command.Parameters["@Points"].Value = points;

                command.ExecuteNonQuery();

                //    if(name == null)
                //    {

                //    }
                //    if(text == null)
                //    {

                //    }
            }
        }
        public Achievement ReadAchievement(int user_id)
        {
            Achievement achievement = null;
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            using (SqlCommand command = new SqlCommand(@"SELECT Achievement.Name, Achievement.Text, Achievement.Points FROM Achievement INNER JOIN Map ON Achievement.Id = Map.Id_achievement INNER JOIN[User] ON Map.Id_user = [User].Id WHERE [User].Id = @Id", connection))
            {
                {
                    connection.Open();
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@Id", user_id));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            achievement = new Achievement();
                            achievement.ID = reader.GetInt32(0);
                            achievement.Name = reader.GetString(1);
                            achievement.Text = reader.GetString(2);
                            achievement.Points = reader.GetInt32(3);
                        }
                        //reader.Close();
                    }
                }
                return achievement;
            }
        }
    }
}
