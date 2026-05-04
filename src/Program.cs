/*
 * Rekursive Datenstrukturen
 * 
 * Referenz auf sich selbst: 
 * Damit klar ist welche Räume wo sind muss in jedem Object der Classe Room
 * die Information gespeichert werden welche Räume neben ihm liegen.
 * das bedeutet, dass die classe Room selbst Felder enthält der classe room.
 * 
 * Innherhalb von Funktionen schreibt man private Variablen klein 
 * Funktionen immer Groß
 * 
 * Funktion heißt so wie die sache wo sie macht und macht auch nur die eine sache
 * 
 * UML gibt alles genau vor egal ob rechtschreibfehler
 * 1. private string erstellen für den Namen. dieser ist private weil man nicht in der Main den 
 * Namen nicht ändern soll ohne eine extra Funktion.
 * 2. Referenzen erstellen: Das Object der Klasse Room benötigt informationen darüber welche 
 * Räume sich um ihn rum sich befinden. Das heißt also das 4 Felder notwendig sind in denen
 * Die Räume gespeicehrt sind welche sich z.b. nördlich befinden.
 * -> es ist also notwendig auch dort dann ein Object anzulegen bzw es muss ein Object 
 * der Klasse Room existieren damit auch ein Object sich in dem Feld befinden kann.
 * 
 * 3. Konstruktor: Jetzt muss eine Möglichkeit geschaffen werden Objecte der Klasse Room zu erstellen
 * 
 * 
 * 
 */




using Ex_4_2;

namespace Ex4_2 // Namespace muss mit Großbuchstaben anfangen camelcase
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

        public void SetConnectedRoom(Room? north,Room? south, Room? east, Room? west) // das Fragezeichen ist notwendig wegen NULL
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
            switch(direction)
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
    
    class Program
    {
        static void Main()
        {
            Maze maz = new Maze("maze"); // Object Maze erstellen 
            if (maz.getStartRoom().GetConnectedRoom('N').GetConnectedRoom('E').GetConnectedRoom('E') == maz.getWinningRoom()) // checken ob die Raumanordnung richtig ist entsprechend dem Skrip
            { //Wieso soll ich auf ein null object zugreifen ?
                Console.WriteLine("The maze seems to be set up correctly!");//if true
            }
            else
            {
                Console.WriteLine("There seems to be something wrong with the maze!"); // Falls connecting 
            }

            Maze maz2 = new Maze("maze2");
            Player pla = new Player(maz.getStartRoom());
            while (pla.getCurrentRoom() != maz.getWinningRoom() && pla.getCurrentRoom() != maz.getLosingRoom())
            {
                Console.WriteLine("You are currently in {0}", pla.getCurrentRoom().GetName());
                Console.WriteLine("Where do you want to go? (N,S,E,W)");
                char direction = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (!pla.move(direction))
                {
                    Console.WriteLine("You can't go in that direction!");
                }

            }

            if (pla.getCurrentRoom() == maz.getWinningRoom())
            {
                Console.WriteLine("Congratulations! You won the maze!");
            }
            else
            {
                Console.WriteLine("Oh no! You lost the maze!");

            }
        }
    }

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
