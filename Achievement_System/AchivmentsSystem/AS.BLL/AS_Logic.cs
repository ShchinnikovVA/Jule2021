using AS.Entities;
using AS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.BLL
{
    public class AS_Logic
    {
        private AchDAL _achDAL;
        private MapDAL _mapDAL;
        private UserDAL _userDAL;
        public AS_Logic()
        {
            _achDAL = new AchDAL();
            _mapDAL = new MapDAL();
            _userDAL = new UserDAL();
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
        public void ReaderAchievement()
        {
            _achDAL.ReadAchievement();
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
        public void EditMap()
        {
            _mapDAL.EditMap();
        }
        public void ReaderMap()
        {
            _mapDAL.ReaderMap();
        }
        // пользователь
        public void AddUser(User user)
        {
            _userDAL.AddUser(user);
        }
        public void RemoveUser(int id)
        {
            _userDAL.RemoveUser(id);
        }
        public void EditUser()
        {
            _userDAL.EditUser();
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
