using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_5_Maze_Game
{
    public class Maze
    {
        private string _name;
        private Room _startRoom;
        private Room _winningRoom;
        private Room _losingRoom;

        public Maze(string name)
        {
            this._name = name;

            //Räume erzeugen
            Room Kitchen = new Room("kitchen");
            Room LivingRoom = new Room("LivingRoom");
            Room Exit = new Room("Exit");
            Room Bathroom = new Room("Bathroom");
            Room Bedroom = new Room("Bedroom");
            Room HsRoom = new Room("HsRoom");

            Kitchen.SetConnectedRoom(null, Bedroom, LivingRoom, null);
            LivingRoom.SetConnectedRoom(null, Bedroom, Exit, Kitchen);
            Exit.SetConnectedRoom(null, null, null, LivingRoom);
            Bathroom.SetConnectedRoom(Kitchen, null, Bedroom, null);
            Bedroom.SetConnectedRoom(LivingRoom, HsRoom, null, Bathroom);
            HsRoom.SetConnectedRoom(Bedroom, null, null, null);
            _startRoom = Bathroom;
            _winningRoom = Exit;
            _losingRoom = HsRoom;
        }
        public Room getWinningRoom()
        {
            return _winningRoom;
        }

        public Room getStartRoom()
        {
            return _startRoom;
        }

        public Room getLosingRoom()
        {
            return _losingRoom;
        }



    }
}
