using System;

namespace Hack
{
    public class Map
    {
        //Various variables
        static string[,] map;
        static string[,] baseMap;
        static string collisionType = "";
        static int msgLength;

        //Load map into memory
        public static void MakeMap()
        {
            baseMap = new string[,] { { "#", "#", "#", "#", "#" },
                                      { "#", ".", ".", ".", "#" },
                                      { "#", ".", ".", ".", "#" },
                                      { "#", ".", ".", ".", "#" },
                                      { "#", "#", "#", "#", "#" } };
        }

        //For refreshing map
        public static void RefreshMap()
        {
            map = baseMap.Clone() as string[,];
        }

        //Draw map from memory, display message
        public static void DrawMap()
        {
            //Clear screen
            Console.SetCursorPosition(0, baseMap.GetUpperBound(0) + 1);
            for (int emptier = 0; emptier < msgLength; emptier++) { Console.Write(" "); }
            Console.SetCursorPosition(0,0);

            //Draw map
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.Length / map.GetLength(0); column++)
                {
                    Console.Write(map[row, column]);
                }
                Console.WriteLine("");
            }

            //Message at the bottom
            Console.WriteLine(Parser.Message);
            msgLength = Parser.Message.Length;
            Parser.ClrMsg();
        }

        //General collision check
        public static bool CollisionCheck(int[] nuPos)
        {
            switch (map[nuPos[0], nuPos[1]])
            {
                case ".":
                    return true;
                case "#":
                    collisionType = "wall";
                    return false;
                case "@":
                    collisionType = "player";
                    return false;
                default:
                    collisionType = "mystery";
                    return false;
            }
                    
        }

        //For updating the map
        public static void MapUpdate(int[] position, string thing)
        {

            if(CollisionCheck(position))
            {
                map[position[0], position[1]] = thing;
            }
            else
            {
                return;
            }
        }
    }
}