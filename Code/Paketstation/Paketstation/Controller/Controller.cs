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
        #endregion

        #region Propertys
        public Paketstation Station { get => _station; set => _station = value; }
        public Kunde Kunde { get => _kunde; set => _kunde = value; }
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

        }
        public void KundeLiefertPaketEin()
        {

        }
        public void KundeHoltPaketAb()
        {

        }
        public void KundeListetPaket()
        {

        }
        #endregion
    }
}
