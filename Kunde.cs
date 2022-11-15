using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohaus
{
    internal class Kunde
    {
        public string name;
        public string email;
        public string adresse;
        public string telefon;

        public Kunde(string name, string email, string adresse, string telefon)
        {
            this.name = name;
            this.email = email;
            this.adresse = adresse;
            this.telefon = telefon;
        }

        public void Ausgabe_Kunde()
        {
            Console.WriteLine($" Der Kunde {name}, wohnhaft bei {adresse}.\n Erreichbar telefonisch unter {telefon}, oder per EMail - {email}.\n");
        }
    }
}
