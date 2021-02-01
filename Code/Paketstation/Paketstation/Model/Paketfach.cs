/**
 * Autor: Christopher Winter
 * Klasse: IA119
 * Datei: Paketfach.cs
 * Beschreibung: Diese Klasse bildet ein Paketfach in einer Packstation ab
 **/
namespace Paketstation
{
    public class Paketfach
    {
        #region Attributes
        private Paket _inhalt;
        private int _nummer;
        private bool _belegt;
        private bool _offen;
        #endregion

        #region Propertys
        public Paket Inhalt { get => _inhalt; set => _inhalt = value; }
        public int Nummer { get => _nummer; set => _nummer = value; }
        public bool Belegt { get => _belegt; set => _belegt = value; }
        public bool Offen { get => _offen; set => _offen = value; }
        #endregion

        #region Contructors
        public Paketfach()
        {

        }
        public Paketfach(Paket inhalt, int nummer, bool belegt, bool offen)
        {
            Inhalt = inhalt;
            Nummer = nummer;
            Belegt = belegt;
            Offen = offen;
        }
        #endregion

        #region Worker
        public void Oeffnen()
        {
            Offen = true;
        }
        public void Schliessen()
        {
            Offen = false;
        }
        public string ErhaltePaketInfo()
        {
            return $"Absender: {Inhalt.Absender}\n" +
                   $"Empfänger: {Inhalt.Empfaenger}";
        }
        public void PaketEinfuegen(Paket paket)
        {
            Inhalt = paket;
            Belegt = true;
        }
        public Paket PaketAusgeben() //paket
        {
            Paket ausgabe = Inhalt;
            Inhalt = null;
            Belegt = false;
            return ausgabe;
        }
        #endregion
    }
}
