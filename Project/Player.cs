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
            int oldCount = Inventory.Count;
            Inventory.Add(item);
            int newCount = Inventory.Count;
            if (newCount - oldCount > 0)
            {
                System.Console.WriteLine($"{item.Name} was added to your inventory");
            }
            else
            {
                System.Console.WriteLine("You dropped it you idiot.");
            }
        }


        public Player()
        {
            Name = "The Dude";
            // Score = score;
            Score = 0;
            Inventory = new List<Item>();
        }

    }
}