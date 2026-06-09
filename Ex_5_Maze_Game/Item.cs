using System;
using System.Collections.Generic;
using System.Text;
/*
 *Eine Klasse ist sozusagen der Bauplan für ein Objekt. also wenn ich ein Objekt der Klasse item anlege dann hat es diese eigenschaften die die Klasse vorraussetzt
 *Listen:
 *Listen stellen arrays dar die dynamisch in der Größe sind. 
 */
namespace Ex_6_Maze_Game
{
    public class Item
    {
        private string _name; // erzeugt ein privates Feld für den Namen des Items 
        private bool _pickable; // erzeugt ein privates Feld für die Information ob das Item aufhebbar ist oder nicht

        public Item(string name,bool pickable) //Konstruktor der Klasse Item, hier werden die Werte für die Felder gesetzt wenn ein neues Objekt der Klasse Item erstellt wird
        {
            this._name = name;
            this._pickable = pickable;
        }

        /*
         * ToString ist in einer library schon deklariert. override ist notwendig damit nur der Item name zurück gegeben wird. 
         * ohne override würde die Funktion ToString die Adresse des Objekts zurückgeben was nicht sehr hilfreich ist.
         */
        public override string ToString()
        {
            return this._name;
        }

        //getter Methode mit is davor weil besser verständlich als get und weil es sich um eine boolsche Variable handelt?
        public bool isPickable() //funktion die zurück gibt ob das Item aufhebbar ist oder nicht
        {
            return this._pickable;
        }

        public void use(Player user)
        {
            // Implement the logic for using the item here
        }
    }
}
