
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

            List<Paketfach> faecher = new List<Paketfach>();
            // Inititialisieren von 9 Paketfächern
            for(int counter = 1; counter <= 9; counter += 1)
            {
                Paketfach p = new Paketfach(null, counter, false, false);
                faecher.Add(p);
            }


            Paketstation station = new Paketstation(1, "Teststraße 1 00000 Teststadt", ui, faecher);
            station.StatusAusgeben();

            while(Active)
            {
                ui.TextAusgeben("Was möchten Sie tun?");
                ui.TextAusgeben("1) Paket abgeben.");
                ui.TextAusgeben("2) Paket abholen.");
                ui.TextAusgeben("3) Pakete listen.");
                ui.TextAusgeben("4) Beenden");

                int menueWahl = Convert.ToInt32(Console.ReadLine());
                switch (menueWahl)
                {
                    case 1:
                        // ToDo: Soll der Kunde das Paket schon haben oder wird es hier initialisiert???
                        Paket p = new Paket("95126 Entenhausen, Watschelstraße 113", 3000, "NORMAL", "Donald Duck", "Chris Winter");
                        KundeLiefertPaketEin(station, p);
                        break;
                    case 2:
                        KundeHoltPaketAb(station);
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
