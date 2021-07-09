using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.DAL.Interface
{
    public interface IAchievementSystemDAL_M
    {
        void AddMap(Map map);
        void RemoveMap(int id);
    }
}
