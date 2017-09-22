using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Item : IItem
    {
        // public int Inventory {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}

        public Dictionary<string, Item> Items {get; set;}

        // public bool addItem(Item item)
        // {


        // }

        // public string viewInventory()
        // {

        // }


        // public Item(string name, string description,int inventory)
        public Item(string name, string description)
        {
            // Inventory = inventory;
            Name = name;
            Description = description;
            Items = new Dictionary<string, Item>();
        }

    }
}