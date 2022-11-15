using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohaus
{
    internal class Auto
    {
        public string hersteller;
        public string modell;
        public string besonderheiten;
        public int km_stand;
        public int baujahr;

        public Auto(string hersteller, string modell, string besonderheiten, int km_stand, int baujahr)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.besonderheiten = besonderheiten;
            this.km_stand = km_stand;
            this.baujahr = baujahr;
        }

        public void Ausgabe_Auto()
        {
            Console.WriteLine($" Das Modell {modell} von {hersteller}, Baujahr {baujahr} hat {besonderheiten}.\n Kilometerstand - {km_stand} km.\n ");
        }
    }
}
