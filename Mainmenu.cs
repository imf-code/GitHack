using System;

namespace Hack
{
    public class MainMenu
    {
        public static ConsoleKeyInfo Menu()
        {
            ConsoleKeyInfo input;
            Console.WriteLine("WELCOME TO HACK!\n" +
                              "_N_ew character.\n" +
                              "_Q_uit");
            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.N:
                        return input;
                    case ConsoleKey.Q:
                        return input;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            } while (input.Key != ConsoleKey.Q);

            return input;
        }
    }
}