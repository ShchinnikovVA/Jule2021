using AS.Entities;
using AS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.BLL
{
    class AS_Logic
    {
        private AchDAL _achDAL;
        public AS_Logic(AchDAL dal)
        {
            _achDAL = dal;
        }
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
    }
}
