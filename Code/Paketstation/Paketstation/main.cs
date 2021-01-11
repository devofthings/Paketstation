/**
 * Autor: Christopher Winter
 * Klasse: IA119
 * Datei: UserInterface.cs
 * Beschreibung: Das ist die main Klasse sie ist der Startpunkt des Paketstation Programms
 **/
namespace Paketstation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Controller c = new Controller();
            c.run();
        }
    }
}
