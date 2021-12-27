using System;
using System.Collections.Generic;
using System.IO;

namespace semestralka_windows_forms
{
    class Databaze
    {
        private List<Osoba> zaznam_osoba;

        public Databaze()
        {
            zaznam_osoba = new List<Osoba>();
        }
        /// <summary>
        /// Přidá nový kompletní záznam osoby do databáze pro známý stav platby
        /// </summary>
        /// <param name="jmeno">Jméno osoby</param>
        /// <param name="prijmeni">Přijmení osoby</param>
        /// <param name="email">Email osoby</param>
        /// <param name="id">Identifikátor osoby</param>
        /// <param name="zaplaceno">Označuje status platby->0-ne;1-ano;2-špatná částka</param>
        /// <param name="datum">Datum platby</param>
        /// <param name="castka">Částka platby</param>
        public void PridejOsobu(string jmeno, string prijmeni, string email, uint id, int zaplaceno, DateTime datum, decimal castka)
        {
            Osoba o = new Osoba(jmeno, prijmeni, email, id, zaplaceno, datum, castka);
            zaznam_osoba.Add(o);
        }
        /// <summary>
        /// Přidá nový záznam osoby do databáze pro neznámý stav platby
        /// </summary>
        /// <param name="jmeno">Jméno osoby</param>
        /// <param name="prijmeni">Přijmení osoby</param>
        /// <param name="email">Email osoby</param>
        /// <param name="id">Identifikátor osoby</param>
        public void PridejOsobu(string jmeno, string prijmeni, string email, uint id)
        {
            Osoba o = new Osoba(jmeno, prijmeni, email, id);
            zaznam_osoba.Add(o);
        }
        /// <summary>
        /// Odebere záznam osoby z databáze
        /// </summary>
        /// <param name="index">index osoby</param>
        public void OdeberOsobu(int index)
        {
            zaznam_osoba.RemoveAt(index);
        }
        /// <summary>
        /// Zkontroluje jestli odpovídají parametry platby a přiřadí platbu dané osobě
        /// </summary>
        /// <param name="index">Index osoby</param>
        /// <param name="id">Identifikátor osoby</param>
        /// <param name="castka">Částka platby</param>
        /// <param name="datum">Datum platby</param>
        /// <param name="castka_pripravka">Čáska příspěvků pro přípravku</param>
        /// <param name="castka_druzstva">Čáska příspěvků pro družstva</param>
        public void Zaplatil(int index, uint id, decimal castka, DateTime datum, decimal castka_pripravka, decimal castka_druzstva)
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
                    zaznam_osoba[index].Castka = castka;
                }
                else
                {
                    //Nastaví na chybnou částku
                    zaznam_osoba[index].Zaplaceno = 2;
                    zaznam_osoba[index].Datum = datum;
                    zaznam_osoba[index].Castka = castka;
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
                    zaznam_osoba[index].Castka = castka;
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
        /// <summary>
        /// Hledá identifikátor osoby (id) v záznamu osob
        /// </summary>
        /// <param name="id">Hledané identifikátor osoby (id)</param>
        /// <returns>Index osoby</returns>
        public int Najdi(uint id)
        {
            int index = zaznam_osoba.FindIndex(os => os.ID == id);
            return index;
        }
        /// <summary>
        /// Vratí osoby z databáze ve vybrané skupině
        /// </summary>
        /// <param name="zaplaceno">Označuje status platby->0-ne;1-ano;2-špatná částka</param>
        /// <returns>Pole osob</returns>
        public Osoba[] VratVybrane(int zaplaceno)
        {
            List<Osoba> vybrani = new List<Osoba>();
            vybrani = zaznam_osoba.FindAll(os => os.Zaplaceno == zaplaceno);
            return vybrani.ToArray();
        }
        /// <summary>
        /// Vrátí všechny osoby v databázi
        /// </summary>
        /// <returns>Pole osob</returns>
        public Osoba[] VratVsechny()
        {
            return zaznam_osoba.ToArray();
        }
        /// <summary>
        /// Vrátí emaily vybrané skupiny 
        /// </summary>
        /// <param name="zaplaceno"></param>
        /// <returns>Seznam emailů oddělený ;<returns>
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
        /// <summary>
        /// Importuje osobu z csv souboru do databáze
        /// </summary>
        /// <param name="oddelovac">Oddělovač csv souboru</param>
        /// <param name="path">Cesta souboru</param>
        public void Import(char oddelovac, string path)
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
                    // přidá uživatele s danými hodnotami
                    PridejOsobu(jmeno, prijmeni, email, id);
                }
            }
        }
        /// <summary>
        /// Exportuje vybranou skupinu osob ve formátu csv dle parametru zaplaceno (0-ne;1-ano;2-chybná částka)
        /// </summary>
        /// <param name="oddelovac">Oddělovač csv</param>
        /// <param name="cesta">Cesta souboru</param>
        /// <param name="zaplaceno">Označuje status platby->0-ne;1-ano;2-špatná částka</param>
        public void Export(char oddelovac, string cesta, int zaplaceno)
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(cesta, false))
            {
                //Projde vsechny osoby, ktere zaplatili
                foreach (Osoba o in VratVybrane(zaplaceno))
                {
                    // vytvoření pole hodnot + ochrana, pokud je zadán oddělovač 
                    string[] hodnoty = { o.Jmeno.Replace(oddelovac, ' '),
                                         o.Prijmeni.Replace(oddelovac, ' '),
                                         o.Email.Replace(oddelovac, ' '),
                                         o.ID.ToString(),
                                         o.Zaplaceno.ToString(),
                                         o.Datum.ToShortDateString(),
                                         o.Castka.ToString() };
                    // vytvoření řádku
                    string radek = String.Join(oddelovac.ToString(), hodnoty);
                    // zápis řádku
                    sw.WriteLine(radek);
                }
                // vyprázdnění bufferu
                sw.Flush();
            }
        }
        /// <summary>
        /// Exportuje všechny záznamy osob ve formátu .csv
        /// </summary>
        /// <param name="oddelovac">Oddělovač csv</param>
        /// <param name="cesta">Cesta souboru</param>
        public void Export(char oddelovac, string cesta)
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(cesta, false))
            {
                //Projde vsechny osoby, ktere zaplatili
                foreach (Osoba o in VratVsechny())
                {
                    // vytvoření pole hodnot + ochrana, pokud je zadán oddělovač 
                    string[] hodnoty = { o.Jmeno.Replace(oddelovac, ' '),
                                         o.Prijmeni.Replace(oddelovac, ' '),
                                         o.Email.Replace(oddelovac, ' '),
                                         o.ID.ToString(),
                                         o.Zaplaceno.ToString(),
                                         o.Datum.ToShortDateString(),
                                         o.Castka.ToString() };
                    // vytvoření řádku
                    string radek = String.Join(oddelovac.ToString(), hodnoty);
                    // zápis řádku
                    sw.WriteLine(radek);
                }
                // vyprázdnění bufferu
                sw.Flush();
            }
        }
    }
}
