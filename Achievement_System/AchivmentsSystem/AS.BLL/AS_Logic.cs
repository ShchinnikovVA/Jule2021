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
        public void RemoveAchievement(Guid id)
        {
            _achDAL.RemoveAchievement(id);
        }
        public void RemoveAchievement(Achievement achievement) => RemoveAchievement(achievement.ID);

        public void EditAchievement(Guid id, string name, string text)
        {
            _achDAL.EditAchievement(id, name, text);
        }
        // карта достижений
        public void AddMap(Map map)
        {
            _mapDAL.AddMap(map);
        }
        public void RemoveMap(Guid id)
        {
            _mapDAL.RemoveMap(id);
        }
        public void EditMap()
        {
            _mapDAL.EditMap();
        }
        // пользователь
        public void AddUser(User user)
        {
            _userDAL.AddUser(user);
        }
        public void RemoveUser(Guid id)
        {
            _userDAL.RemoveUser(id);
        }
        public void EditUser()
        {
            _userDAL.EditUser();
        }

    }
}
