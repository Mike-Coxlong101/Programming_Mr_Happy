using System;
using System.Collections.Generic;
using System.Text;
/*
 * Der Player hat ein inventar das bedeutet er benötigt eine Liste welche Objecte vom Typ item beeinhaltet. Im ULM wird das Symbolisiert durch
 * einen Pfeil von Player zu dem Object Item das * bedeutet er kann 0 oder unendlich viele items haben.
 */

namespace Ex_7_Maze_Game
{
    public class Player
    {
        private Room _currentRoom; //steht nicht im UML aber es ist notwendig damit der Spieler weiß wo er sich befindet
        private List<Item> _bag; //muss hier stehen damit klar ist, dass der Player dauerhaft eine Liste hat welche private ist. Im Konstruktor steht nie eine Variable die angelegt wird da es wie eine Funktion ist.
        
        public Player(Room CurrentRoom)
        {
            this._currentRoom = CurrentRoom;
            this._bag = new List<Item>(); 
        }

        public Room getCurrentRoom()
        {
            return _currentRoom; 
        }

        public bool AddItemToBag(Item item)
        {
            if (item != null) 
            {
                this._bag.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Wenn der User eine Item ausgewählt hat in der Linken List Box und dann drop drückt wird diese Funktion aufgerufen.
        public bool RemoveFromBag(Item ItemInUse)
        {
            if(this._bag.Count != 0)
            {
                _currentRoom.AddContent(ItemInUse);
                this._bag.Remove(ItemInUse);
                return true;
            }
            return false;
        }


        public List<Item> IsInBag()
        {
            return this._bag;
        }

        public bool move(char direction)
        {
            Room? nextRoom = _currentRoom.GetConnectedRoom(direction); //hier wird die Funktion aus der classe Room aufgerufen um zu schauen ob es einen Raum in der Richtung gibt
            if (nextRoom != null) //wenn es einen Raum gibt dann wird der Spieler in diesen Raum gesetzt
            {
                _currentRoom = nextRoom;
                return true; //wenn es einen Raum gibt dann wird true zurückgegeben damit die Main weiß das die Bewegung erfolgreich war
            }
            else
            {
                return false; //wenn es keinen Raum gibt dann wird false zurückgegeben damit die Main weiß das die Bewegung nicht erfolgreich war
            }
        }
    }
}
