using System;

namespace semestralka_windows_forms
{
    class Osoba
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public string Email { get; private set; }
        public uint ID { get; private set; }
        //0 = nezaplaceno; 1 = zaplaceno; 2 = spatna castka
        public int Zaplaceno { get; set; }
        public DateTime Datum { get; set; }
        public decimal Castka { get; set; }

        public Osoba(string jmeno, string prijmeni, string email, uint id)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            ID = id;
            Zaplaceno = 0;
            Datum = default;
            Castka = 0;
        }
        public Osoba(string jmeno, string prijmeni, string email, uint id, int zaplaceno, DateTime datum, decimal castka)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Email = email;
            ID = id;
            Zaplaceno = zaplaceno;
            Datum = datum;
            Castka = castka;
        }
        public override string ToString()
        {
            return Prijmeni + " " + Jmeno;
        }
    }
}
