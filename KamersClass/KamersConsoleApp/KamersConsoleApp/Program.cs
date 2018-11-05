using kamersmodel;
using System;

namespace KamersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* var speelruimte = MaakSpeelRuimteAan();
             var speler = MaakSpeler();
             ZetSpelerInRuimte(speelruimte.startruimte); */


            // maak speelruimte aan
            // maak speler aan
            // zet speler in speelruimte(beginpositie)
            //begin het spel : zorg dat de opdrachten kunnen gegeven worden

            var level = MaakLevelAan();
            var speler = MaakSpelerAan();
            level.ZetSpelerInLevel(speler);
            SpeelLevel();



        }



        private static Speler MaakSpelerAan()
        {
            throw new NotImplementedException();
        }

        private static void SpeelLevel()
        {
            Console.WriteLine("start van het spel");
            string commando = "";
            while (commando != "stop")
            {
                switch (commando)
                {
                    case "wie ben ik":
                        // toont informatie over de speler
                        break;
                    case " waar ben ik":
                        // toon de naam van de ruimte waar de speler zich bevindt
                        break;
                    case "ga naar":
                        // verplaats speler naar andere ruimte
                        break;
                    case "help":
                        // toon de commando's die kunnen ingetypt worden
                        break;
                    default:
                        break;


                }
                commando = Console.ReadLine().Trim();
            }
        }

        private static Speler MaakLevelAan()
        {
            // een level is bv een huis
            var buiten = new Locatie("buiten");
            var hal = new Locatie("inkomhal");
            var keuken = new Locatie("keuken");
            var living = new Locatie("living");
            // de doorgang tussen ruimtes

            buiten.MaakDoorgangNaar(hal);
            hal.MaakDoorgangNaar(keuken);
            hal.MaakDoorgangNaar(living);
            // volgende 2 lijnen doen identiek hetzelfde
            living.MaakDoorgangNaar(keuken);
            Locatie.MaakDoorgang(living, keuken);

            // Maak Level aan en voeg de plaatsen eraan toe

            return new Level(buiten); // buiten de startpositie


        }
    }
}
