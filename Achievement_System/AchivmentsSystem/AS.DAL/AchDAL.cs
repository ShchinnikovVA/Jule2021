using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AS.DAL
{
    public class AchDAL
    {
        public const string _FILES_PATCH = @"F:\Рабочее пространство\Парктика 2021\Jule2021\Achievement_System\AchivmentsSystem";
        public void AddAchievement(Achievement achievement)
        {

        }
        public void RemoveAchievement(Guid id)
        {

        }
        public void EditAchievement(Guid id, string name, string text)
        {
            if(name == null)
            {

            }
            if(text == null)
            {

            }
        }
    }
}
