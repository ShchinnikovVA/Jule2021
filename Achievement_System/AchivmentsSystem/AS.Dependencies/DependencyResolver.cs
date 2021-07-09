using AS.DAL.Interface;
using AS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.BLL.Interface;
using AS.BLL;

namespace AS.Dependencies
{
    public class DependencyResolver
    {
        public static DependencyResolver Instance =>  new DependencyResolver();

        public IAchievementSystemDAL_A DAL_A => new AchDAL();
        public IAchievementSystemDAL_M DAL_M => new MapDAL();
        public IAchievementSystemDAL_U DAL_U => new UserDAL();
        public IAchievementSystemBLL BLL_Logic => new AS_Logic(DAL_A, DAL_M, DAL_U);
    }
}
