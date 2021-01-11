
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
        #endregion
    }
}
