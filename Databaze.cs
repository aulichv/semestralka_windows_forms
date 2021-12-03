using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestralka_windows_forms
{
    class Databaze
    {
        private List<Osoba> zaznam_osoba;
        private string soubor;

        public Databaze(string soubor)
        {
            zaznam_osoba = new List<Osoba>();
            this.soubor = soubor;
        }

        public void PridejOsobu(string jmeno, string prijmeni, string email, uint id, int zaplaceno)
        {
            Osoba o = new Osoba(jmeno, prijmeni, email, id, zaplaceno);
            zaznam_osoba.Add(o);
        }

        public void OdeberOsobu(int index)
        {
            zaznam_osoba.Remove(zaznam_osoba[index]);
        }

        public void Zaplaceno(int index, int id, int castka, int castka_pripravka, int castka_druzstva)
        {
            //Podle id rozhodne družstvo (lichá přípravka, sudá družstva)
            //Test přípravka
            if (id % 2 != 0)
            {
                //Zkontroluje, jestli odpovídá částka
                if (castka == castka_pripravka)
                {
                    //Nastaví příznak na zaplaceno
                    zaznam_osoba[index].zaplaceno = 1;
                }
                else
                {
                    //Nastaví na chybnou částku
                    zaznam_osoba[index].zaplaceno = 2;
                }
            }
            //Test družstva
            else if (id % 2 == 0)
            {
                //Zkontroluje, jestli odpovídá částka
                if (castka == castka_druzstva)
                {
                    //Nastaví příznak na zaplaceno
                    zaznam_osoba[index].zaplaceno = 1;
                }
                else
                {
                    //Nastaví na chybnou částku
                    zaznam_osoba[index].zaplaceno = 2;
                }
            }
        }

        public int Najdi(int id)
        {
            int index = zaznam_osoba.FindIndex(os => os.ID == id);
            return index; 
        }
        public Osoba[] VratVybrane(int zaplaceno)
        {
            List<Osoba> vybrani = new List<Osoba>();
            vybrani = zaznam_osoba.FindAll(os => os.zaplaceno == zaplaceno);
            return vybrani.ToArray();
        }
        public Osoba[] VratVsechny()
        {
            return zaznam_osoba.ToArray();
        }
        public void Uloz(string oddelovac)
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                // projetí uživatelů
                foreach (Osoba o in zaznam_osoba)
                {
                    // vytvoření pole hodnot
                    string[] hodnoty = { o.Jmeno, o.Prijmeni, o.Email, o.ID.ToString(), o.zaplaceno.ToString() };
                    // vytvoření řádku
                    string radek = String.Join(oddelovac, hodnoty);
                    // zápis řádku
                    sw.WriteLine(radek);
                }
                // vyprázdnění bufferu
                sw.Flush();
            }
        }
        public void Nacti(char oddelovac)
        {
            zaznam_osoba.Clear();
            // Otevře soubor pro čtení
            using (StreamReader sr = new StreamReader(soubor))
            {
                string s;
                // čte řádek po řádku
                while ((s = sr.ReadLine()) != null)
                {
                    // rozdělí string řádku podle středníků
                    string[] sloupec = s.Split(oddelovac);
                    string jmeno = sloupec[0];
                    string prijmeni = sloupec[1];
                    string email = sloupec[2];
                    uint id = uint.Parse(sloupec[3]);
                    int zaplaceno = int.Parse(sloupec[4]);
                    // přidá uživatele s danými hodnotami
                    PridejOsobu(jmeno, prijmeni, email, id, zaplaceno);
                }
            }
        }
    }
}
