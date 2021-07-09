namespace AS.Entities
{
    public class Map
    {
        public Map( int iD_User, int iD_Achievement)
        {
            ID_User = iD_User;
            ID_Achievement = iD_Achievement;
        }

        public int ID { get; }
        public int ID_User { get; }
        public int ID_Achievement { get; }

    }
}
