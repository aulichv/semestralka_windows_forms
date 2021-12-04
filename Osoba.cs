using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestralka_windows_forms
{
    class Osoba
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public string Email { get; private set; }
        public uint ID { get; private set; }
        //0 == nezaplaceno; 1 == zaplaceno; 2 == spatna castka
        public int Zaplaceno { get;  set; }
        public DateTime Datum { get; set; }
 
        public Osoba(string jmeno, string prijmeni, string email, uint id, int zaplaceno)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            ID = id;
            Zaplaceno = zaplaceno;
        }

        public override string ToString()
        {
            return Prijmeni + " " + Jmeno;
        }
    }
}
