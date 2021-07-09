using AS.Entities;
using System.Data;
using System.Data.SqlClient;
using AS.DAL.Interface;

namespace AS.DAL
{
    public class MapDAL : IAchievementSystemDAL_M
    {
        public const string _FILES_PATCH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Рабочее пространство\Парктика 2021\Jule2021\Achievement_System\AchivmentsSystem\Files\AchievementSystem.mdf;Integrated Security=True;Connect Timeout=30";
        public void AddMap(Map map)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Map VALUES ( @Id_user, @Id_achievement)";
                command.Parameters.Add("@Id_user", SqlDbType.Int);
                command.Parameters.Add("@Id_achievement", SqlDbType.Int);

                int id_user = map.ID_User;
                int id_achievement = map.ID_Achievement;

                command.Parameters["@Id_user"].Value = id_user;
                command.Parameters["@Id_achievement"].Value = id_achievement;

                command.ExecuteNonQuery();
            }
        }
        public void RemoveMap(int id)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Map WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = id;
                command.ExecuteNonQuery();
            }
        }
    }
}

