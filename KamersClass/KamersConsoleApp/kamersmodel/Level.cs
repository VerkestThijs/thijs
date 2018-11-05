using System;
using System.Collections.Generic;
using System.Text;

namespace kamersmodel
{
    public class Level
    {

        public Locatie Startpositie { get; } // readonly property


        public Level(Locatie buiten)
        {
            
            Startpositie = buiten;
        }





        public void ZetSpelerInLevel(Speler speler)
        {
            // plaats de speler in de startruimte
            throw new NotImplementedException();
        }

    }
}
