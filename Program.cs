using System.IO.Compression;
using System.Security.Cryptography;

namespace Autohaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programm();
        }
        static void Programm()
        {
            Abfrage(L_Erstellung());
        }
        static List<Rechnung> L_Erstellung()
        {
            List<Rechnung> l_rechnung = Archiv.Liste_fuellen();
            Archiv.Liste_laenge(l_rechnung);
            return l_rechnung;
        }
        static void Abfrage(List<Rechnung> l_rechnung)
        {
            Console.Write($"Geben Sie die ID der Rechnung an. (1 bis {Rechnung.anzahl_rechnungen}):"); //Die Länge muss vorher bestimmt werden.
            int rechnungsnummer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wählen Sie welche Informationen Sie ansehen möchten: (K)unde, (A)uto, (R)echnung.");
            string optionen = Console.ReadLine().ToLower();

            if (optionen=="k")
            {
                Archiv.Ausgabe_Kunde(rechnungsnummer, l_rechnung);
            }
            else if (optionen=="a")
            {
                Archiv.Ausgabe_Auto(rechnungsnummer, l_rechnung);
            }
            else if (optionen =="r")
            {
                Archiv.Ausgabe_Rechnung(rechnungsnummer, l_rechnung);
            }
        }
    }
}