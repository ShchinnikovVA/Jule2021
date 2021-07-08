using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Entities
{
    public class User
    {
        public User()
        {
        }

        public User( string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public User(int iD, string login, string password, string name, string surname, string middleName, string eMail, int phone_Number)
        {
            ID = iD;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            EMail = eMail;
            Phone_Number = phone_Number;
        }

        //public User(/* Guid iD_Map,*/ string login, string password, string name, string surname)
        //{
        //    ID = Guid.NewGuid();
        //    //ID_Map = iD_Map;
        //    Login = login;
        //    Password = password;
        //    Name = name;
        //    Surname = surname;
        //}

        //public User( Guid iD_Map, string login, string password, string name, string surname, string middleName, string eMail, int phone_Number)
        //{
        //    ID = Guid.NewGuid();
        //    ID_Map = iD_Map;
        //    Login = login;
        //    Password = password;
        //    Name = name;
        //    Surname = surname;
        //    MiddleName = middleName;
        //    EMail = eMail;
        //    Phone_Number = phone_Number;
        //}

        public int ID { get; set; }
        //public int ID_Map { get; }
        public string Login { get;  set; }
        public string Password { get;  set; }
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string MiddleName { get;  set; }
        public string EMail { get;  set; }
        public int Phone_Number { get;  set; }

    }
}
