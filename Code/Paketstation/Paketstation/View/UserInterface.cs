
using System;
/**
* Autor: Christopher Winter
* Klasse: IA119
* Datei: UserInterface.cs
* Beschreibung: Diese Klasse bildet das User Interface und alle seien Funktionen ab.
**/
namespace Paketstation
{
    public class UserInterface
    {
        #region Attributes
        private string _text;
        #endregion

        #region Propertys
        public string Text { get => _text; set => _text = value; }
        #endregion

        #region Contructors
        public UserInterface()
        {

        }
        #endregion

        #region Worker
        public void DatenAnnehmen()
        {

        }
        public void TextAusgeben(string Text)
        {
            Console.WriteLine(Text);
        }
        public void KundenMenueAusgeben(Kunde k1, Kunde k2, Kunde k3)
        {
            TextAusgeben("Bitte wähle einen Kunden");
            TextAusgeben($"1) {k1.Name}, Hat Paket: {k1.HatPaket()}");
            TextAusgeben($"2) {k2.Name}, Hat Paket: {k2.HatPaket()}");
            TextAusgeben($"3) {k3.Name}, Hat Paket: {k3.HatPaket()}");
        }
        public void MenueAusgeben()
        {
            TextAusgeben("Was möchten Sie tun?");
            TextAusgeben("1) Paket abgeben.");
            TextAusgeben("2) Paket abholen.");
            TextAusgeben("3) Pakete listen.");
            TextAusgeben("4) Zurück zur Kundenauswahl");
            TextAusgeben("5) Beenden");

        }
        #endregion
    }
}
