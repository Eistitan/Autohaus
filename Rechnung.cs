using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohaus
{
    internal class Rechnung
    {
        public int rechnungs_nummer;
        public Kunde kunde;
        public Auto auto;
        public DateOnly datum;
        public decimal preis;

        public static int anzahl_rechnungen;

        public Rechnung(int rechnungs_nummer, Kunde kunde, Auto auto, DateOnly datum, decimal preis )
        {
            this.kunde = kunde;
            this.auto = auto;
            this.datum = datum;
            this.preis = preis;
            this.rechnungs_nummer = rechnungs_nummer;
        }

        public void Ausgabe_Rechnung()
        {
            Console.WriteLine($" Das Auto {auto.modell} von {auto.hersteller} wurde für {preis} Euro verkauft.\n Der Käufer ist {kunde.name}.\n Datum {datum}\n");
            
        }

    }
}
