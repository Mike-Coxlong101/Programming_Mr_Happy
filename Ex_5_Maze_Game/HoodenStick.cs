using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7_Maze_Game
{
    public class HoodenStick : Item 
    {
        public HoodenStick(string name, bool pickable) : base(name, pickable) { }

        public override void use( Player player) // pointer vom typ Player namens player 
        {
            player.AddItemToBag(new HoodenStick("HoodenStick", true)); // keine derefrenzierung notwendig
        }


    }
}
