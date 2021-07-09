using AS.Entities;
using AS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.DAL.Interface;
using AS.BLL.Interface;

namespace AS.BLL
{
    public class AS_Logic : IAchievementSystemBLL
    {
        private IAchievementSystemDAL_A _achDAL;
        private IAchievementSystemDAL_M _mapDAL;
        private IAchievementSystemDAL_U _userDAL;
        public AS_Logic(IAchievementSystemDAL_A DAL_A, IAchievementSystemDAL_M DAL_M, IAchievementSystemDAL_U DAL_U)
        {
            _achDAL = DAL_A;
            _mapDAL = DAL_M;
            _userDAL = DAL_U;
        }
        // достижения
        public void AddAchievement(Achievement achievement)
        {
            _achDAL.AddAchievement(achievement);
        }
        public void RemoveAchievement(int id)
        {
            _achDAL.RemoveAchievement(id);
        }
        public void RemoveAchievement(Achievement achievement) => RemoveAchievement(achievement.ID);

        public void EditAchievement(int id, string name, string text, string point)
        {
            _achDAL.EditAchievement(id, name, text, Convert.ToInt32(point));
        }
        public Achievement ReaderAchievement(int user_id)
        {
            Achievement achievement = null;
            achievement = _achDAL.ReadAchievement(user_id);
            return achievement;
        }
        // карта достижений
        public void AddMap(Map map)
        {
            _mapDAL.AddMap(map);
        }
        public void RemoveMap(int id)
        {
            _mapDAL.RemoveMap(id);
        }
     
        // пользователь
        public void AddUser(User user)
        {
            _userDAL.AddUser(user);
            _mapDAL.AddMap(new Map(user.ID, 1));
        }
        public void RemoveUser(int id)
        {
            _userDAL.RemoveUser(id);
        }
        public void EditUser(int id, string login, string password, string name, string surname, string middlename, string email, int number)
        {
            _userDAL.EditUser( id,  login,  password,  name,  surname,  middlename, email, number);
        }
        public User ReaderUser(int id)
        {
            User user = null;
            user = _userDAL.ReaderUser(id);
            return user;
        }
        public User LoginPassword(string login, string password)
        {
            User user = null;
            user = _userDAL.LoginPassword(login, password);
            return user;
        }

    }
}
