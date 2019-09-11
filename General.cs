using System;

namespace Hack
{
    public class General
    {
        //Screen size
        public static void ScreenSize()
        {
            Console.SetWindowSize(40, 10);
        }

        //Player
        public static Player Name { get; set; }
    }
}