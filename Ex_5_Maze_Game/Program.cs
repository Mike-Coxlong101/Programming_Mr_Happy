/*
 * Maze Game:
 * 
 * Startraum ist Bathroom 
 * 
 * Anzeige Elemente:
 * Message box für die current location 
 * Message box für Ergebnis gewonnen etc. 
 * Message box für fehlerhaft Eingabe z.b.: Richtung welche nicht möglich ist.
 * Message box für reset wenn entsprechnernder Raum erreicht ist.
 * 
 * Steuerelemente:
 * Buttons N E W S
 * 
 * Funktionen:
 * current location
 * check wegen aktuellem Raum 
 * reset
 * update wenn wechsel in neuen Raum.
 */



namespace Ex_5_Maze_Game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}