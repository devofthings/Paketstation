
using System;
using System.Collections.Generic;
/**
* Autor: Christopher Winter
* Klasse: IA119
* Datei: Controller.cs
* Beschreibung: Dies ist der Controller er kontrolliert den Programmablauf.
**/
namespace Paketstation
{
    public class Controller
    {
        #region Attributes
        private Paketstation _station;
        private Kunde _kunde;
        private bool _active = true;
        #endregion

        #region Propertys
        public Paketstation Station { get => _station; set => _station = value; }
        public Kunde Kunde { get => _kunde; set => _kunde = value; }
        private bool Active { get => _active; set => _active = value; }
        #endregion

        #region Contructors
        public Controller()
        {

        }
        public Controller(Paketstation station, Kunde kunde)
        {
            Station = station;
            Kunde = kunde;
        }
        #endregion

        #region Worker
        public void run()
        {
            UserInterface ui = new UserInterface();

            // Inititialisieren von 9 Paketfächern
            List<Paketfach> faecher = new List<Paketfach>();
            for(int counter = 1; counter <= 9; counter += 1)
            {
                Paketfach p = new Paketfach(null, counter, false, false);
                faecher.Add(p);
            }

            // Initialisieren von 3 Testkunden
            Kunde alfa = new Kunde(
                new Paket("Buchenweg 1337", 3000, "NORMAL", "Charlie", "Alfa"),
                1,
                "Alfa",
                "Eichenweg 12, 12345 Dortmund"
            );
            Kunde bravo = new Kunde(
                new Paket("Eichenweg 12, 12345 Dortmund", 1000, "NORMAL", "Alfa", "Bravo"),
                2,
                "Bravo",
                "Birkenweg 7, 54321 Köln"
            );
            Kunde charlie = new Kunde(
                null,
                3,
                "Charlie",
                "Buchenweg 1337, 00000 Nullstadt"
            );

            Paketstation station = new Paketstation(1, "Teststraße 1 00000 Teststadt", ui, faecher);
            station.StatusAusgeben();

            while(Active)
            {
                ui.MenueAusgeben();
                int menueWahl = Convert.ToInt32(Console.ReadLine());
                switch (menueWahl)
                {
                    case 1:
                        if(alfa.Paket != null)
                        {
                            KundeLiefertPaketEin(station, alfa.PaketEinliefern());
                        }
                        else
                        {
                            ui.TextAusgeben("Sie haben nichts zum abgeben!");
                        }
                        
                        break;
                    case 2:
                        charlie.PaketAbholen(station);
                        break;
                    case 3:
                        KundeListetPakete(station);
                        break;
                    case 4:
                        Active = false;
                        break;
                    default:
                        break;
                }
            }
            

        }
        public void KundeLiefertPaketEin(Paketstation station, Paket p)
        {
            station.PaketAbgeben(p);
        }
        public void KundeHoltPaketAb(Paketstation station)
        {
            station.PaketAbholen();
        }
        public void KundeListetPakete(Paketstation station)
        {
            station.PaketeListen();
        }
        #endregion
    }
}
