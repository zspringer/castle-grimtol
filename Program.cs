﻿using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO Write a function that will switch this boolean to false to end the game on the game class
            bool playing = true;
            Game MyGame = new Game();
            MyGame.Setup();
            Console.Clear();
            while (playing)
            {
                MyGame.UserResponse();
            }
        }
    }
}
