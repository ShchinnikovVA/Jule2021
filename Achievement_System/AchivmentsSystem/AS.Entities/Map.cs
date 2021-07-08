using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Entities
{
    public class Map
    {

        public Map( Guid iD_User, Guid iD_Achievement)
        {
            ID = Guid.NewGuid();
            ID_User = iD_User;
            ID_Achievement = iD_Achievement;
        }

        public Guid ID { get; }
        public Guid ID_User { get; }
        public Guid ID_Achievement { get; }

    }
}
