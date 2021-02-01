using System;
using System.Collections.Generic;
/**
* Autor: Christopher Winter
* Klasse: IA119
* Datei: Paketstation.cs
* Beschreibung: Diese Klasse bildet eine Paketstation ab.
**/
namespace Paketstation
{
    public class Paketstation
    {
        #region Attributes
        private List<Paketfach> _faecher;
        private UserInterface _terminal;
        private string _standort;
        private int _id;
        #endregion

        #region Propertys
        public List<Paketfach> Faecher { get => _faecher; set => _faecher = value; }
        public UserInterface Terminal { get => _terminal; set => _terminal = value; }
        public string Standort { get => _standort; set => _standort = value; }
        public int ID { get => _id; set => _id = value; }
        #endregion

        #region Contructors
        public Paketstation()
        {

        }
        public Paketstation(int id, string standort, UserInterface ui, List<Paketfach> faecher)
        {
            ID = id;
            Standort = standort;
            Terminal = ui;
            Faecher = faecher;
        }
        #endregion

        #region Worker
        public void PaketAbgeben(Paket paket)
        {
            /* Check ob ein Fach frei ist
             * Über alle Paketfächer gehen,
             * Checken ob Paket vorhanden ist
             * Wenn frei füge Paket zu diesem Paketfach hinzu und gebe Paketfachnummer zurück
             * Wenn kein Fach frei ist gebe Fehlermeldung zurück: "Station voll" o.ä
             */
            if(Faecher.Exists(f => f.Belegt == false))
            {
                foreach (Paketfach fach in Faecher)
                {
                    if (fach.Belegt == false)
                    {
                        fach.PaketEinfuegen(paket);
                        Terminal.TextAusgeben($"Paket wurde in Paketfach Nr.{fach.Nummer} eingelagert.");
                        break;
                    }
                    else {}
                }
            }
            else
            {
                Terminal.TextAusgeben("Leider ist kein Paketfach frei.");
            }
            
        }
        public void PaketeListen()
        {
            /*
             * Gehe über alle Fächer
             * Wenn Paket vorhanden gebe PaketfachID & Abesender + Empfänger aus zurück
             */
            foreach(Paketfach fach in Faecher)
            {
                Terminal.TextAusgeben($"Paketfach Nr.{fach.Nummer}, Belegt: {fach.Belegt}");
                if (fach.Belegt == true)
                {
                    Terminal.TextAusgeben($"{fach.ErhaltePaketInfo()}");
                }
            }
        }
        public Paket PaketAbholen(string empfaenger)
        {
            /* Frage nach ID
             * Gehe über alle Fächer
             * Wenn Paket vorhanden, prüfe ob Name = Empfänger ist
             * Wenn ja gebe PaketfachID zurück
             */
            Fachauswahl:
            Terminal.TextAusgeben("Welches Paket möchten Sie abholen? Bitte geben sie die Paketfach ID ein:");
            int gewaehlteID = Convert.ToInt32(Console.ReadLine());
            if(Faecher[gewaehlteID - 1].Belegt == true)
            {
                if(Faecher[gewaehlteID - 1].Inhalt.Empfaenger == empfaenger)
                {
                    Terminal.TextAusgeben("Paket entnommen.");
                    return Faecher[gewaehlteID - 1].PaketAusgeben();
                }
                else
                {
                    Terminal.TextAusgeben("In diesem Fach liegt kei nPaket für sie!");
                    goto Fachauswahl;
                }
                
            }
            else
            {
                Terminal.TextAusgeben("Dieses Paketfach ist leer.");
            }
            return null;
        }
        public void PaketFinden(string empfaenger, Paketfach paketfach)
        {
            //TODO List Paket with id maybe?
        }
        public void StatusAusgeben()
        {
            Terminal.TextAusgeben("Willkommen an der Paketstation");
            Terminal.TextAusgeben(Standort);
        }

        #endregion
    }
}
