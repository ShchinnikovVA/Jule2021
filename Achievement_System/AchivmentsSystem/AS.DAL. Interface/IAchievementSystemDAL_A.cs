using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.DAL.Interface
{
    public interface IAchievementSystemDAL_A
    {
        void AddAchievement(Achievement achievement);
        void RemoveAchievement(int id);
        void EditAchievement(int id, string name, string text, int points);
        void ReadAchievement();
    }
}
