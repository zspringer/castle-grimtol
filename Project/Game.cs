using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }

        public void Reset()
        {

        }

        void GameGuide()
        {
            System.Console.WriteLine("Type 'E' to go East");
            System.Console.WriteLine("Type 'W' to go West");
            System.Console.WriteLine("Type 'Take <ItemName>' to pick up an Item Ex: 'Take Key'");
            System.Console.WriteLine("Type 'H' to get this guide");
            System.Console.WriteLine("Type 'X' to give up");
        }


        public void UserResponse()
        {
            string UserChoice = Console.ReadLine();
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
                case "X":
                    System.Console.WriteLine("So long loser");
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("You did not choose a valid option");
                    break;
            }
        }

        public void Setup()
        {
            System.Console.WriteLine("Welcome to this crummy game");
            System.Console.WriteLine("---------------------------");

            GameGuide();
            //some user input
            //validate input is go
            //MyGame.Go

            //Use the constructor function to build the rooms
            Room Courtyard = new Room("Courtyard", "A run down courtyard with lots of weeds");
            Room Barracks = new Room("Barracks", "A dark and smelly room");
            Room Captain = new Room("Captain", "Pretty cool room with lots of treasures everywhere");
            Room End = new Room("End", "This is the room where you will win the game");

            //The list of the rooms with relationships that establish the exits allowed
            Courtyard.Exits.Add("E", Barracks);
            Barracks.Exits.Add("W", Courtyard);
            Barracks.Exits.Add("E", Captain);
            Captain.Exits.Add("W", Barracks);
            Captain.Exits.Add("E", End);
            End.Exits.Add("W", Captain);

            //Construct the items and add them to rooms
            Item Key = new Item("Key", "Gold colored key");
            Item Lock = new Item("Lock", "The lock to your freedom");

            //Add the items to the room
            Barracks.Items.Add(Key);
            Captain.Items.Add(Lock);

            //Sets the initial room when the game is started
            CurrentRoom = Courtyard;

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
        }


        public void Take(string item)
        {

        }

        public void UseItem(string itemName)
        {

        }
    }
}