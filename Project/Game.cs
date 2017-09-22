using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        //Should I set the bool here?
        // public bool Playing {get; set;}  Maybe set the bool up here instead of on program?

        public void Reset()
        {
            //See about setting the bool here instead of on program so that you can flip it here
            // Playing = false;
            //Would clear the console and then run setup again
            // Console.Clear();
            // Setup();

        }

        public void GameGuide()
        {
            System.Console.WriteLine("Type 'E' to go East");
            System.Console.WriteLine("Type 'W' to go West");
            System.Console.WriteLine("Type 'Take <ItemName>' to pick up an Item Ex: 'Take Key'");
            System.Console.WriteLine("Type 'U' to use an item in your inventory");
            System.Console.WriteLine("Type 'H' to get this guide");
            System.Console.WriteLine("Type 'X' to give up");
        }


        public void UserResponse()
        {
            string UserChoice = Console.ReadLine().ToUpper();
            switch (UserChoice.ToUpper())
            {
                case "H":
                    GameGuide();
                    break;
                case "E":
                    Go(UserChoice);
                    break;
                case "W":
                    Go(UserChoice);
                    break;
                case "TAKE KEY":
                    Take("KEY");
                    break;
                case "U":
                    // UseItem();
                    break;
                case "X":
                    System.Console.WriteLine("So long dude");
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("You did not choose a valid option");
                    break;
            }
        }

        public void Setup()
        {
            //Use the constructor function to build the rooms
            Room Courtyard = new Room("Courtyard", "A run down courtyard with lots of weeds.");
            Room Barracks = new Room("Barracks", "A dark and smelly room.");
            Room Captain = new Room("Captain Room", "It is a pretty cool room with lots of treasures everywhere including.");
            Room End = new Room("End Room", "Congratulations, you are saved and have won the game.");
            
            //Sets the initial room when the game is started
            CurrentRoom = Courtyard;
            Player cp = new Player();
            CurrentPlayer = cp;


            System.Console.WriteLine("Welcome to THE game");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("If you ever need the User Guide, Type 'H'");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine($"You are currently in the {CurrentRoom.Name}.  {CurrentRoom.Description}");
            System.Console.WriteLine("---------------------------");

            GameGuide();
            //some user input
            //validate input is go
            //MyGame.Go


            //The list of the rooms with relationships that establish the exits allowed
            Courtyard.Exits.Add("E", Barracks);
            Barracks.Exits.Add("W", Courtyard);
            Barracks.Exits.Add("E", Captain);
            Captain.Exits.Add("W", Barracks);
            Captain.Exits.Add("E", End);
            End.Exits.Add("W", Captain);

            //Construct the items and add them to rooms
            Item Key = new Item("KEY", "Gold colored key");
            Item Lock = new Item("LOCK", "The lock to your freedom");

            //Add the items to the room
            // Barracks.Items.Add(Key);
            // Captain.Items.Add(Lock);
            Barracks.addItem(new Item("KEY", "Gold colored key"));
            Captain.addItem(new Item("LOCK", "The lock to your freedom"));
            System.Console.WriteLine();

            // CurrentPlayer.addItem(new Item("DOG", "BLACK DOG"));
        }
        //How to move from room to room
        public void Go(string UserChoice)
        {
            if (CurrentRoom.Exits[UserChoice] != null)
            {
                CurrentRoom = CurrentRoom.Exits[UserChoice];
            }
            else
            {
                System.Console.WriteLine("You can't go that way");
            }
            // System.Console.WriteLine($"You are now in the {CurrentRoom.Name}");
            System.Console.WriteLine($"You have now moved to the {CurrentRoom.Name}.  {CurrentRoom.Description}");
            if (CurrentRoom.Items[0]!= null)
            {
                System.Console.Beep();
                System.Console.Beep();
                System.Console.ForegroundColor= ConsoleColor.DarkGreen;
                System.Console.WriteLine($"This room has a {CurrentRoom.Items[0].Name} in it");
            }
        }


        public void Take(string ItemName)
        {
            // System.Console.WriteLine(CurrentPlayer.Inventory[0].Name);
            //Cannot use List because you do not have access to the list but you can use CurrentRoom.Items
            //foreach(Item item in CurrentRoom.Items)
            for(int x = 0; x < CurrentRoom.Items.Count; x++)
            {
                
                {
                    if (CurrentRoom.Items[x].Name == ItemName)
                    {
                        CurrentPlayer.addItem(CurrentRoom.Items[x]);
                        // System.Console.WriteLine($"You have {CurrentPlayer.Inventory[0].Name} in your inventory");
                        CurrentRoom.Items.Remove(CurrentRoom.Items[x]);                  
                    }
                }
            }
        }

        public void UseItem(string itemName)
        {
            // itemName.Split
            // System.Console.WriteLine("I am in UseItem");
            
        }
    }
}