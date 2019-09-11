using System;

namespace Hack
{
    public class Parser
    {
        //Init
        static string mess = "";
        public static string Message { get { return mess; } }
        static Player character = General.Name;
        static int[] charPos = character.CharPos;

        //Initial parsing of player input
        public static void ParseInput(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.NumPad8:
                case ConsoleKey.NumPad2:
                case ConsoleKey.NumPad4:
                case ConsoleKey.NumPad6:
                    Move(input);
                    break;
                default:
                    mess = "Unknown command.";
                    break;
            }
        }

        //Movement routine
        public static void Move(ConsoleKeyInfo input)
        {
            int[] nuPos = { charPos[0], charPos[1] };
            switch (input.Key)
            {
                case ConsoleKey.NumPad8:
                    nuPos[0] = charPos[0] - 1;
                    break;
                case ConsoleKey.NumPad2:
                    nuPos[0] = charPos[0] + 1;
                    break;
                case ConsoleKey.NumPad4:
                    nuPos[1] = charPos[1] - 1;
                    break;
                case ConsoleKey.NumPad6:
                    nuPos[1] = charPos[1] + 1;
                    break;
                default:
                    Console.WriteLine("What??");
                    break;
            }


            if (Map.CollisionCheck(nuPos))
            {
                character.CharPos = charPos = nuPos;
            }
            else
            {
                mess += "Cannot move in that direction.";
            }
        }

        //Empty mess
        public static void ClrMsg()
        {
            mess = "";
        }
    }
}
