namespace AS.Entities
{
    public class Achievement
    {
        public Achievement()
        {
        }

        public Achievement( string name, string text, int points)
        {
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

        public int ID { get; set; }
        public string Name { get;  set; }
        public string Text { get;  set; }
        public int Points { get;  set; }
    }
}
