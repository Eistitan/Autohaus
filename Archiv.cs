using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohaus
{
    internal static class Archiv //Speicherort aller Objekte
    {
        static Auto a1 = new("Mercedes", "600er", "Lowrider", 150000, 2001);
        static Auto a2 = new("VW", "Polo", "Alufelgen", 200000, 2000);
        static Auto a3 = new("Toyota", "Yaris", "fünf Türen", 176000, 2017);
        static Auto a4 = new("Renault", "Zoe", "elektrisch", 100000, 2020);
        static Auto a5 = new("VW", "ID5", "elektrisch", 50000, 2022);

        static Kunde k1 = new("Peter Augustus", "paugu@gmail.com", "Alte-Str. 8, 74541 Altdorf", "07985-41322");
        static Kunde k2 = new("Andrea Milk", "milk.a@gmail.de", "Rosenweg 19a, 14547 Busendorf", "08132-982122");
        static Kunde k3 = new("Karl Brauer", "derlustigealtemann@web.de", "Freudenweg 13, 38875 Elend", "039455-745847");
        
        //Den Kunden und das Auto direkt in der Rechnung zu initieren würde den Code ganz unleserlich machen.
        static Rechnung rech1 = new(1, k2, a5, new DateOnly(2022, 02, 12), 45000);
        static Rechnung rech2 = new(2, k1, a4, new DateOnly(2022, 03, 19), 35000);
        static Rechnung rech3 = new(3, k2, a2, new DateOnly(2022, 06, 7), 5000);
        static Rechnung rech4 = new(4, k3, a3, new DateOnly(2022, 08, 22), 25000);
        static Rechnung rech5 = new(5, k3, a1, new DateOnly(2022, 08, 22), 15000);

        public static List<Rechnung> Liste_fuellen()
        {
            List<Rechnung> rechnungen = new List<Rechnung>();
            rechnungen.Add(rech1);
            rechnungen.Add(rech2);
            rechnungen.Add(rech3);
            rechnungen.Add(rech4);
            rechnungen.Add(rech5);
            return rechnungen;
        }
        public static void Liste_laenge(List<Rechnung> rechnungen)
        {
            Rechnung.anzahl_rechnungen=rechnungen.Count;
        }
        public static void Ausgabe_Auto(int r_nr, List<Rechnung> rechn)
        {
            rechn[r_nr - 1].auto.Ausgabe_Auto();
        }
        public static void Ausgabe_Kunde(int r_nr, List<Rechnung> rechn)
        {
            rechn[r_nr - 1].kunde.Ausgabe_Kunde();
        }
        public static void Ausgabe_Rechnung(int r_nr, List<Rechnung> rechn)
        {
            rechn[r_nr-1].Ausgabe_Rechnung();
        }
    }
}
