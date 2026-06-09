using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_6_Maze_Game
{
    public class Room //auch immer mit großbuchstaben beginnen
    {
        private string _name; //private Felder mit unterstrich
        private Room? _north, _south, _east, _west; // enthalten die Infromation welche Räume benachbart sind

        private List<Item> _content; // dynamisches array welches objekte der Klasse item enthält

        //Jetzt ist ein Konstruktor notwendig damit ein Object erstellt werden kann

        public Room(string name)
        {
            this._name = name; //this stellt bezug zum privaten Feld oben her.
            this._content = new List<Item>();
        }

        public bool AddContent(Item item)
        {
            if (item != null)
            {
                this._content.Add(item);
                return true;
            }
            else return false;
        }

        public Item RemoveFromRoom(Item SelectedItem)
        {
            if(SelectedItem != null)
            {
                this._content.Remove(SelectedItem);
                return SelectedItem;
            }
            return null;
        }
        
        public List<Item> IsContent()
        {
            return this._content;
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
