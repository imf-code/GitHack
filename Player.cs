using System;

namespace Hack
{
    public class Player
    {
        //Initial character position
        public int[] CharPos { get; set; }

        //Place PC on map
        public void SetChar()
        {
            Map.MapUpdate(CharPos, "@");
        }
    }
}