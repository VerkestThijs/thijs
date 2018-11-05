using System;
using System.Collections.Generic;
using System.Text;

namespace kamersmodel
{
    public class Locatie
    {
        public string NaamLocatie { get; } // readonly propertie


        public Locatie(string naamLocatie)
        {
            NaamLocatie = naamLocatie;
            doorgangen = new List<Doorgang>();
        }

        List<Doorgang> doorgangen;

        /// <summary>
        /// maakt een doorgang van deze locatie (this) naar een andere
        /// </summary>
        /// <param name="hal">de locatie waarnaar een doorgan moet gemaakt worden</param>

        public  void MaakDoorgangNaar(Locatie hal)
        {
            doorgangen.Add(new Doorgang(this, hal));
        }

        public static void MaakDoorgang(Locatie van, Locatie naar)
        {
            van.MaakDoorgangNaar(naar);
        }
    }
}
