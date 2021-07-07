using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Entities
{
    class User
    {
        public User( Guid iD_Map, string login, string password, string name, string surname)
        {
            ID = Guid.NewGuid();
            ID_Map = iD_Map;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public User( Guid iD_Map, string login, string password, string name, string surname, string middleName, string eMail, int phone_Number)
        {
            ID = Guid.NewGuid();
            ID_Map = iD_Map;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            EMail = eMail;
            Phone_Number = phone_Number;
        }

        public Guid ID { get; }
        public Guid ID_Map { get; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string MiddleName { get; private set; }
        public string EMail { get; private set; }
        public int Phone_Number { get; private set; }

    }
}
