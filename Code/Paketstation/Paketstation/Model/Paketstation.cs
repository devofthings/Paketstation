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
        public void PaketAnnehmen(Paket paket)
        {
            // TODO ADD Paket to Paket Annehmen
            // Faecher.Add(paket);
        }
        public List<Paketfach> PaketeListen()
        {
            return Faecher;
        }
        public void Abgeben()
        {
            //TODO change void to Paket
        }
        public void PaketFinden()
        {
            //TODO List Paket with id maybe?
        }
        private void StatusAbfragen(int id)
        {
            //TODO Add some code
        }

        #endregion
    }
}
