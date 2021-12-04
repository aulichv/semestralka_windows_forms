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
            zaznam_osoba.RemoveAt(index);
        }

        public void Zaplatil(int index, int id, int castka, DateTime datum, int castka_pripravka, int castka_druzstva)
        {
            //Podle id rozhodne družstvo (lichá přípravka, sudá družstva)
            //Test přípravka
            if (id % 2 != 0)
            {
                //Zkontroluje, jestli odpovídá částka
                if (castka == castka_pripravka)
                {
                    //Nastaví příznak na zaplaceno
                    zaznam_osoba[index].Zaplaceno = 1;
                    zaznam_osoba[index].Datum = datum;
                }
                else
                {
                    //Nastaví na chybnou částku
                    zaznam_osoba[index].Zaplaceno = 2;
                    zaznam_osoba[index].Datum = datum;
                }
            }
            //Test družstva
            else if (id % 2 == 0)
            {
                //Zkontroluje, jestli odpovídá částka
                if (castka == castka_druzstva)
                {
                    //Nastaví příznak na zaplaceno
                    zaznam_osoba[index].Zaplaceno = 1;
                    zaznam_osoba[index].Datum = datum;
                }
                else
                {
                    //Nastaví na chybnou částku
                    zaznam_osoba[index].Zaplaceno = 2;
                    zaznam_osoba[index].Datum = datum;
                    zaznam_osoba[index].Castka = castka;
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
            vybrani = zaznam_osoba.FindAll(os => os.Zaplaceno == zaplaceno);
            return vybrani.ToArray();
        }
        public Osoba[] VratVsechny()
        {
            return zaznam_osoba.ToArray();
        }
        public string[] VratEmail(int zaplaceno)
        {
            List<Osoba> vybrani = new List<Osoba>();
            vybrani = zaznam_osoba.FindAll(os => os.Zaplaceno == zaplaceno);
            string[] email = new string[vybrani.Count];
            //spojí maily do jednoho řetězce s využitím středníku
            for (int i = 0; i < vybrani.Count; i++)
            {
                email[i] = vybrani[i].Email;
            }
            return email;
        }
        public void Uloz(char oddelovac)
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                // projetí uživatelů
                foreach (Osoba o in zaznam_osoba)
                {
                    // vytvoření pole hodnot + ochrana, pokud je zadán oddělovač 
                    string[] hodnoty = { o.Jmeno.Replace(oddelovac, ' '), o.Prijmeni.Replace(oddelovac, ' '), o.Email.Replace(oddelovac, ' '), o.ID.ToString(), o.Zaplaceno.ToString() };
                    // vytvoření řádku
                    string radek = String.Join(oddelovac.ToString(), hodnoty);
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

        public void Nacti2(char oddelovac, string path)
        {
            zaznam_osoba.Clear();
            // Otevře soubor pro čtení
            using (StreamReader sr = new StreamReader(path))
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
