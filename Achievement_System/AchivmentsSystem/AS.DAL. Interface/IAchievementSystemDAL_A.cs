using AS.Entities;
using System.Collections.Generic;

namespace AS.DAL.Interface
{
    public interface IAchievementSystemDAL_A
    {
        void AddAchievement(Achievement achievement);
        void RemoveAchievement(int id);
        void EditAchievement(int id, string name, string text, int points);
        List<Achievement> ReadAchievement(int user_id);
    }
}
