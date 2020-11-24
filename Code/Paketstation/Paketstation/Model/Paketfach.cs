/**
 * Autor: Christopher Winter
 * Klasse: IA119
 * Datei: Paketfach.cs
 * Beschreibung: Diese Klasse bildet die Paketstaion ab
 **/
namespace Paketstation
{
    public class Paketfach
    {
        #region Attributes
        private Paket _inhalt;
        private int _nummer;
        private bool _status;
        private bool _belegt;
        #endregion

        #region Propertys
        public Paket Inhalt { get => _inhalt; set => _inhalt = value; }
        public int Nummer { get => _nummer; set => _nummer = value; }
        public bool Status { get => _status; set => _status = value; }
        public bool Belegt { get => _belegt; set => _belegt = value; }
        #endregion

        #region Contructors
        public Paketfach()
        {

        }
        public Paketfach(Paket inhalt, int nummer, bool status, bool belegt)
        {
            Inhalt = inhalt;
            Nummer = nummer;
            Status = status;
            Belegt = belegt;
        }
        #endregion

        #region Worker
        public void Oeffnen()
        {

        }
        public void Schliessen()
        {

        }
        public void ErhalteBeleg() //bool
        {

        }
        public void ErhaltePaketInfo() //string
        {

        }
        public void PaketEinfuegen()
        {

        }
        public void PaketAusgeben() //paket
        {

        }
        #endregion
    }
}
