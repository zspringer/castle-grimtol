using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Item : IItem
    {
        // public int Inventory {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public bool Flag {get; set;}

        // public List<string, Item> Items {get; set;}

        // public bool addItem(Item item)
        // {


        // }

        // public string viewInventory()
        // {

        // }


        // public Item(string name, string description,int inventory)
        public Item(string name, string description, bool Flag)
        {
            // Inventory = inventory;
            Name = name;
            Description = description;
            Flag = false;
            // Items = new List<string, Item>();
        }

    }
}