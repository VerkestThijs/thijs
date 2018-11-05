using System;

namespace kamersmodel
{
    public class Doorgang
    {

        private  Locatie eersteLocatie;
        private  Locatie tweedeLocatie;

        public Doorgang(Locatie eersteLocatie, Locatie tweedeLocatie)
            {
              this.eersteLocatie = eersteLocatie;
               this.tweedeLocatie = tweedeLocatie;
            }
        
    }
}
