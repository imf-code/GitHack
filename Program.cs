using System;

namespace Hack
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Create new Player
            Player character1 = new Player();
            General.Name = character1;
            Player character = General.Name;
            character1.CharPos = new int[] { 1, 1 };

            //Load map & settings
            Map.MakeMap();
            General.ScreenSize();

            //Main menu
            ConsoleKeyInfo input = MainMenu.Menu();

            //Main loop
            while (input.Key != ConsoleKey.Q)
            {
                //Clean the map
                Map.RefreshMap();

                //Place objects on map
                character.SetChar();

                //Draw map
                Map.DrawMap();

                //Player input
                input = Console.ReadKey();
                Parser.ParseInput(input);
            }
        }
    }
}
