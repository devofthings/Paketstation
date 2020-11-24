/**
 * Autor: Christopher Winter
 * Klasse: IA119
 * Datei: Paket.cs
 * Beschreibung: Diese Klasse bildet ein Paket ab.
 **/
namespace Paketstation
{
    public class Paket
    {
        #region Attributes
        private string _paketschein;
        private int _gewicht;
        private string _groesse;
        private string _empfaenger;
        private string _absender;
        #endregion

        #region Propertys
        public string Paketschein { get => _paketschein; set => _paketschein = value; }
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        public string Groesse { get => _groesse; set => _groesse = value; }
        public string Empfaenger { get => _empfaenger; set => _empfaenger = value; }
        public string Absender { get => _absender; set => _absender = value; }
        #endregion

        #region Contructors
        public Paket()
        {

        }
        public Paket(string paketschein, int gewicht, string groesse, string empfaenger, string absender)
        {
            Paketschein = paketschein;
            Gewicht = gewicht;
            Groesse = groesse;
            Empfaenger = empfaenger;
            Absender = absender;
        }
        #endregion

        #region Worker
        public void StandortAbfrage()
        {

        }
        #endregion
    }
}
