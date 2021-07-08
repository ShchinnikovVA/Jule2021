using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Entities
{
    public class Achievement
    {
        public Achievement( string name, string text, int points)
        {
            //ID = Guid.NewGuid();
            Name = name;
            Text = text;
            Points = points;
        }

        public Achievement(int iD, string name, string text, int points)
        {
            ID = iD;
            Name = name;
            Text = text;
            Points = points;
        }

        public int ID { get; }
        public string Name { get; private set; }
        public string Text { get; private set; }
        public int Points { get; private set; }
    }
}
