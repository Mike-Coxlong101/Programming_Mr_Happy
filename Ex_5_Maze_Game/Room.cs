using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_5_Maze_Game
{
    public class Room //auch immer mit großbuchstaben beginnen
    {
        private string _name; //private Felder mit unterstrich
        private Room? _north, _south, _east, _west; // enthalten die Infromation welche Räume benachbart sind

        //Jetzt ist ein Konstruktor notwendig damit ein Object erstellt werden kann

        public Room(string name)
        {
            this._name = name; //this stellt bezug zum privaten Feld oben her.
        }

        public void SetConnectedRoom(Room? north, Room? south, Room? east, Room? west) // das Fragezeichen ist notwendig wegen NULL
        {
            this._north = north; //hier ist jetzt this. notwendig wenn die Variablen in der classe gleich heißt. this. geht dann auf Classe ebene
            this._south = south;
            this._east = east;
            this._west = west;
        }

        public string GetName()
        {
            return _name;
        }

        public Room? GetConnectedRoom(char direction)
        {
            switch (direction)
            {
                case 'N':
                    return _north;

                case 'S':
                    return _south;

                case 'E':
                    return _east;

                case 'W':
                    return _west;

                default:
                    return null; //wenn ich falschen Buchstabe übergebe dann geht er in default return wird immer erwartet.
            }
        }

    }
}
