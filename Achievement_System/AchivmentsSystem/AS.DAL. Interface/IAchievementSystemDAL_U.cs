using AS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.DAL.Interface
{
    public interface IAchievementSystemDAL_U
    {
        void AddUser(User user);
        void RemoveUser(int id);
        void EditUser();
        User LoginPassword(string login, string password);
    }
}
