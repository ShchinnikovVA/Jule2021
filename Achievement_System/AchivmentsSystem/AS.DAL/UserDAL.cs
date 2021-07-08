using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AS.DAL
{
    public class UserDAL
    {
        public const string _FILES_PATCH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Рабочее пространство\Парктика 2021\Jule2021\Achievement_System\AchivmentsSystem\Files\AchievementSystem.mdf;Integrated Security=True;Connect Timeout=30";
        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO [dbo].[User] (Login, Password, Name, Surname) VALUES ( @Login, @Password, @Name, @Surname)";
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Surname", SqlDbType.NVarChar, 50);

                string login = user.Login;
                string password = user.Password;
                string name = user.Name;
                string surname = user.Surname;

                command.Parameters["@Login"].Value = login;
                command.Parameters["@Password"].Value = password;
                command.Parameters["@Name"].Value = name;
                command.Parameters["@Surname"].Value = surname;

                command.ExecuteNonQuery();
            }
        }
        public void RemoveUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM [dbo].[User] WHERE Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }
        }
        public void EditUser()
        {
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE [dbo].[User] SET Login = @Login, Password = @Password, Name = @Name, Surname = @Surname, Middlename = @Middlename, Email = @Email, Number = @Number WHERE Id = @Id";
                command.Parameters.Add("@Login", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Surname", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Middlename", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            }
        }
        public User LoginPassword (string login, string password)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            using (SqlCommand command = new SqlCommand("select * from [dbo].[User] where ( Login = @Login and Password = @Password)", connection))
            {
                connection.Open();
                
                
                //command.Parameters["@Login"].Value = password;
                //    command.Parameters["@Password"].Value = password;
                command.Parameters.Add(new SqlParameter("@Login", login));
                command.Parameters.Add(new SqlParameter("@Password", password));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User();
                        user.ID = reader.GetInt32(0); 
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Surname = reader.GetString(4);
                        //user.MiddleName = reader.GetString(5);
                        //user.EMail = reader.GetString(6);
                        //user.Phone_Number = reader.GetInt32(7);



                    }
                    return user;
                }
            }
        }
        public User ReaderUser(int id)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(_FILES_PATCH))
            using (SqlCommand command = new SqlCommand("select * from [dbo].[User] where Id = @Id", connection))
            {   
                command.Parameters.Add(new SqlParameter("@Id", id));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    if (reader.Read())
                    {
                        user = new User();
                        user.ID = id;
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Surname = reader.GetString(4);
                        user.MiddleName = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        user.EMail = reader.IsDBNull(6) ? "" : reader.GetString(6);
                        user.Phone_Number = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                        //user.EMail = reader.GetString(6);
                        //user.Phone_Number = reader.GetInt32(7);



                    }
                    return user;
                }
            }
        }
    }
}
