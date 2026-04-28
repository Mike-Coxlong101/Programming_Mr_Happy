using System;
using System.Collections.Generic;
using System.Text;
using Ex4_2;

namespace Ex_4_2
{
    internal class Player
    {
        private Room _currentRoom; //steht nicht im UML aber es ist notwendig damit der Spieler weiß wo er sich befindet
        public Player(Room CurrentRoom)
        {
            this._currentRoom = CurrentRoom;
        }

        public Room getCurrentRoom()
        {
            return _currentRoom;
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
