/**
 * Autor: Christopher Winter
 * Klasse: IA119
 * Datei: Kunde.cs
 * Beschreibung: Diese Klasse bildet einen Kunden ab.
 **/
namespace Paketstation
{
    public class Kunde
    {
        #region Attributes
        private Paket _paket;
        private int _kundennummer;
        private string _name;
        private string _adresse;
        #endregion

        #region Propertys
        public Paket Paket { get => _paket; set => _paket = value; }
        public int Kundennummer { get => _kundennummer; set => _kundennummer = value; }
        public string Name { get => _name; set => _name = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        #endregion

        #region Contructors
        public Kunde()
        {

        }
        public Kunde(Paket paket, int kundennummer, string name, string adresse)
        {
            Paket = paket;
            Kundennummer = kundennummer;
            Name = name;
            Adresse = adresse;
        }
        #endregion

        #region Worker
        public Paket PaketEinliefern()
        {
            Paket tmp = Paket;
            Paket = null;
            return tmp;
        }
        public void PaketAbholen(Paketstation station)
        {
            Paket = station.PaketAbholen();
        }
        #endregion
    }
}
