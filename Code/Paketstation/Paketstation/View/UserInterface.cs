
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
        public void MenueAusgeben()
        {
            TextAusgeben("Was möchten Sie tun?");
            TextAusgeben("1) Paket abgeben.");
            TextAusgeben("2) Paket abholen.");
            TextAusgeben("3) Pakete listen.");
            TextAusgeben("4) Beenden");
        }
        #endregion
    }
}
