using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Entities
{
    public class Achievement
    {
        public Achievement( string name, string text)
        {
            ID = Guid.NewGuid();
            Name = name;
            Text = text;
        }

        public Guid ID { get; }
        public string Name { get; private set; }
        public string Text { get; private set; }
    }
}
