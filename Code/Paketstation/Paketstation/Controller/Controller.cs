
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
        private List<Kunde> _kunden = new List<Kunde>();
        private int _activeKunde;
        private bool _activeMenue1 = true;
        private bool _activeMenue2 = true;
        #endregion

        #region Propertys
        public Paketstation Station { get => _station; set => _station = value; }
        public Kunde Kunde { get => _kunde; set => _kunde = value; }
        public int ActiveKunde { get => _activeKunde; set => _activeKunde = value; }
        private bool Menue1 { get => _activeMenue1; set => _activeMenue1 = value; }
        public bool Menue2 { get => _activeMenue2; set => _activeMenue2 = value; }
        public List<Kunde> Kunden { get => _kunden; set => _kunden = value; }
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
            #region Station Initialisierung
            UserInterface ui = new UserInterface();

            // Inititialisieren von 9 Paketfächern
            List<Paketfach> faecher = new List<Paketfach>();
            for(int counter = 1; counter <= 9; counter += 1)
            {
                Paketfach p = new Paketfach(null, counter, false, false);
                faecher.Add(p);
            }

            Paketstation station = new Paketstation(1, "Teststraße 1 00000 Teststadt", ui, faecher);
            #endregion

            #region Kunden Intitalisierung
            // Initialisieren von 3 Testkunden
            Kunde alfa = new Kunde(
                new Paket("Buchenweg 1337", 3000, "NORMAL", "Charlie", "Alfa"),
                1,
                "Alfa",
                "Eichenweg 12, 12345 Dortmund"
            );
            Kunden.Add(alfa);
            Kunde bravo = new Kunde(
                new Paket("Eichenweg 12, 12345 Dortmund", 1000, "NORMAL", "Alfa", "Bravo"),
                2,
                "Bravo",
                "Birkenweg 7, 54321 Köln"
            );
            Kunden.Add(bravo);
            Kunde charlie = new Kunde(
                null,
                3,
                "Charlie",
                "Buchenweg 1337, 00000 Nullstadt"
            );
            Kunden.Add(charlie);
            #endregion
            Menue1:
            while (Menue1)
            {
                ui.KundenMenueAusgeben(alfa, bravo, charlie);
                int menueWahl = Convert.ToInt32(Console.ReadLine());
                switch (menueWahl)
                {
                    case 1:
                        ActiveKunde = 1;
                        Menue1 = false;
                        Menue2 = true;
                        break;
                    case 2:
                        ActiveKunde = 2;
                        Menue1 = false;
                        Menue2 = true;
                        break;
                    case 3:
                        ActiveKunde = 3;
                        Menue1 = false;
                        Menue2 = true;
                        break;
                    default:
                        break;
                }
            }

            station.StatusAusgeben();

            while(Menue2)
            {
                ui.MenueAusgeben();
                int menueWahl = Convert.ToInt32(Console.ReadLine());
                switch (menueWahl)
                {
                    case 1:
                        foreach(Kunde k in Kunden)
                        {
                            if(k.Kundennummer == ActiveKunde)
                            {
                                if (k.Paket != null)
                                {
                                    KundeLiefertPaketEin(station, k.PaketEinliefern());
                                }
                                else
                                {
                                    ui.TextAusgeben("Sie haben nichts zum abgeben!");
                                }
                            }
                            else {}
                        }
                        
                        break;
                    case 2:
                        foreach(Kunde k in Kunden)
                        {
                            if(k.Kundennummer == ActiveKunde)
                            {
                                k.PaketAbholen(station);
                            }
                            else {}
                        }
                        break;
                    case 3:
                        KundeListetPakete(station);
                        break;
                    case 4:
                        Menue1 = true;
                        Menue2 = false;
                        goto Menue1;
                    case 5:
                        Menue1 = false;
                        Menue2 = false;
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
