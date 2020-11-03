namespace UnityCourcesTest.Classes
{
    class Player
    {
        public string Name { get; set; }
        public string Mark { get; set; }

        Player() {
            Name = "PlayerName";
            Mark = "X";
        }

        public Player(string mark)
        {
            Mark = mark;
            Name = mark + "Player";
        }
    }
}
