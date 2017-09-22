using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public string Name;
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        //Not sure if this goes here
        public void addItem(Item item)
        {
            // Menu.Add(item);
        }


        public Player(int score)
        {
            Name = "The Dude";
            Score = score;
            Inventory = new List<Item>();
        }

    }
}