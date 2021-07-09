using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.BLL.Interface
{
    public interface IAchievementSystemBLL
    {
        //ACHIEVEMENT
        void AddAchievement(Achievement achievement);
        void RemoveAchievement(int id);
        void RemoveAchievement(Achievement achievement);
        void EditAchievement(int id, string name, string text, string point);
        Achievement ReaderAchievement(int user_id);
        //MAP
        void AddMap(Map map);
        void RemoveMap(int id);
        //USER
        void AddUser(User user);
        void RemoveUser(int id);
        void EditUser(int id, string login, string password, string name, string surname, string middlename, string email, int number);
        User ReaderUser(int id);
        User LoginPassword(string login, string password);
    }
}
