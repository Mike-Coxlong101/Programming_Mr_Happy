using System;
using System.Collections.Generic;
using System.Text;
/*
 * Die Sichtbarkeit der Variablen muss mmit Methoden abgestimmt sein, da die Argumente nich tweniger Sichtbar sein dürfen als die MEthode.
 * 
 */




namespace Ex_6_Maze_Game
{
    public class Maze
    {
        private string _name;
        private Room _startRoom;
        private Room _winningRoom;
        private Room _losingRoom;
        private Player player;

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

            //Items der Räume hinzufügen
            Item Key = new Item("key", true);
            Item gun = new Item("gun", true);
            Item brickwall = new Item("brickwall", false);
            Item dynamite = new Item("dynamite", true);
            Item Koks = new Item ("Koks", true);
            Item Ketamin = new Item("Ketamin", true);

            player = new Player(_startRoom);
            player.AddItemToBag(Ketamin);
            Kitchen.AddContent(Key);
            LivingRoom.AddContent(gun);
            Bathroom.AddContent(brickwall);
            Bedroom.AddContent(Koks);

            

            
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

        internal Player GetPlayer()
        {
            return player;
        }

    }
}
