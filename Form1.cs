using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace semestralka_windows_forms
{
    public partial class Form1 : Form
    {
        private Databaze databaze;
        private List<Banka> zaznam_banka;
        decimal castka_pripravka;
        decimal castka_druzstva;
        char oddelovac;


        public Form1()
        {
            zaznam_banka = new List<Banka>();
            
            InitializeComponent();

            comboBox_oddelovac.SelectedIndex = 0;
            numericUpDown_pripravka.Value = 2000;
            numericUpDown_druzstva.Value = 2500;
            castka_pripravka = numericUpDown_pripravka.Value;
            castka_druzstva = numericUpDown_druzstva.Value;
            oddelovac = Char.Parse(comboBox_oddelovac.Text);
            // vytvoření složky aplikace v AppData
            // vytvoření databáze
            databaze = new Databaze();
            lbl_platba_datum_vsichni.Text = "";
            lbl_import_osob_cesta.Text = "";
            lbl_import_plateb_cesta.Text = "";

        }

        private void button_nacti_osoby_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Omezení souborů, které mohou být vybrány
            dialog.Filter = "CSV soubory (*.csv)|*.csv";
            //Zákaz výběru více souborů
            dialog.Multiselect = false;
            //Pokud uživatel potvrdí
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Získá cestu  k souboru
                String path = dialog.FileName;
                lbl_import_osob_cesta.Text = path;
                try
                {
                    databaze.Import(oddelovac, path);
                }
                catch
                {
                    MessageBox.Show("Sobor obsahuje chybu ve formátování. Zkontrolujte formát vstupních dat dle instrukcí. (Není prázdný sloupec?)", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_import_osob_cesta.Text = "";
                }
            }
        }

        private void listBox_vsichni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vsichni.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_vsichni.SelectedItem;
                lbl_jmeno_vsichni.Text = u.Jmeno;
                lbl_prijmeni_vsichni.Text = u.Prijmeni;
                lbl_email_vsichni.Text = u.Email;
                lbl_id_vsichni.Text = u.ID.ToString();
                //Zobrazení skupiny (rozhodnutí podle id)
                if (u.ID % 2 == 0)
                    lbl_skupina_vsichni.Text = "Družstva";
                else if (u.ID % 2 != 0)
                    lbl_skupina_vsichni.Text = "Přípravka";
                //Rozhodnutí o platbě
                if (u.Zaplaceno == 0)
                {
                    lbl_platba.Text = "Platba neevidována";
                }
                if (u.Zaplaceno == 1)
                {
                    lbl_platba.Text = "Zaplaceno";
                    lbl_platba_datum_vsichni.Text = u.Datum.ToShortDateString();
                }
                if (u.Zaplaceno == 2)
                {
                    lbl_platba.Text = "Zaplacena chybná částka";
                    lbl_platba_datum_vsichni.Text = u.Datum.ToShortDateString();
                }
            }
        }

        private void button_pridat_databaze_Click(object sender, EventArgs e)
        {
            string jmeno = textBox_jmeno_vsichni.Text;
            string prijmeni = textBox_prijmeni_vsichni.Text;
            string email = textBox_email_vsichni.Text;
            uint id = (uint)numericUpDown_id_vsichni.Value;
            int zaplaceno = 0;
            DateTime datum = DateTime.MinValue;
            decimal castka = 0;
            if (radioButton_nezaplaceno.Checked)
                zaplaceno = 0;
            
            if (radioButton_zaplaceno.Checked)
            {
                zaplaceno = 1;
                datum = dateTimePicker.Value;
                if (id % 2 != 0)
                    castka = castka_pripravka;
                if (id % 2 == 0)
                    castka = castka_druzstva;
            }
            databaze.PridejOsobu(jmeno, prijmeni, email, id, zaplaceno, datum, castka);
            listBox_vsichni.Items.Add(new Osoba(jmeno, prijmeni, email, id, zaplaceno, datum, castka));
        }

        private void button_odebrat_databaze_Click(object sender, EventArgs e)
        {
            if (listBox_vsichni.SelectedIndex >= 0)
            {
                databaze.OdeberOsobu(listBox_vsichni.SelectedIndex);
                listBox_vsichni.Items.RemoveAt(listBox_vsichni.SelectedIndex);
            }
            else
                MessageBox.Show("Vyberte osobu k odebrání ze seznamu",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void listBox_zaplaceno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_zaplaceno.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_zaplaceno.SelectedItem;
                lbl_jmeno_zaplaceno.Text = u.Jmeno;
                lbl_prijmeni_zaplaceno.Text = u.Prijmeni;
                lbl_email_zaplaceni.Text = u.Email;
                lbl_id_zaplaceno.Text = u.ID.ToString();
                //Zobrazení skupiny (rozhodnutí podle id)
                if (u.ID % 2 == 0)
                    lbl_skupina_zaplaceno.Text = "Družstva";
                else if (u.ID % 2 != 0)
                    lbl_skupina_zaplaceno.Text = "Přípravka";
                lbl_datum_platba_zaplaceno.Text = u.Datum.ToShortDateString();
            }
        }

        private void button_kopiruj_email_zaplaceno_Click(object sender, EventArgs e)
        {
            //Zkopírování emailů do schránky
            if (!string.IsNullOrEmpty(textBox_zaplaceno.Text))
                Clipboard.SetText(textBox_zaplaceno.Text);
        }

        private void button_export_zaplaceno_Click(object sender, EventArgs e)
        {
            //Uložení platičů do .csv
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV soubory (*.csv)|*.csv";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    databaze.Export(oddelovac, saveFileDialog1.FileName, 1);
                }
                catch
                {
                    MessageBox.Show("Vytvořte nový soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_import_banka_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Omezení souborů, které mohou být vybrány
            dialog.Filter = "CSV soubory (*.csv)|*.csv";
            //Zákaz výběru více souborů
            dialog.Multiselect = false;
            //Pokud uživatel potvrdí
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Získá cestu  k souboru
                String path = dialog.FileName;
                lbl_import_plateb_cesta.Text = path;
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string s;
                        // čte řádek po řádku
                        while ((s = sr.ReadLine()) != null)
                        {
                            // rozdělí string řádku podle separatoru
                            string[] sloupec = s.Split(oddelovac);
                            uint id = uint.Parse(sloupec[0]);
                            DateTime datum = DateTime.Parse(sloupec[1]);
                            int zaplaceno = int.Parse(sloupec[2]);
                            // záznam z výpisu s danými hodnotami
                            Banka b = new Banka(id, datum, zaplaceno);
                            zaznam_banka.Add(b);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Sobor obsahuje chybu ve formátování. Zkontrolujte formát vstupních dat dle instrukcí. (Není prázdný sloupec?)", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_import_plateb_cesta.Text = "";
                }
            }
        }

        private void listBox_chyba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_chyba.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_chyba.SelectedItem;
                lbl_jmeno_chyba.Text = u.Jmeno;
                lbl_prijmeni_chyba.Text = u.Prijmeni;
                lbl_email_chyba.Text = u.Email;
                lbl_id_chyba.Text = u.ID.ToString();
                //Zobrazení skupiny (rozhodnutí podle id)
                if (u.ID % 2 == 0)
                    lbl_skupina_chyba.Text = "Družstva";
                else if (u.ID % 2 != 0)
                    lbl_skupina_chyba.Text = "Přípravka";
                lbl_datum_chyba.Text = u.Datum.ToShortDateString();
                lbl_castka_chyba.Text = u.Castka.ToString();
            }
        }
        private void button_export_chyba_Click(object sender, EventArgs e)
        {
            //Uložení neplatičů do .csv
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV soubory (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    databaze.Export(oddelovac, saveFileDialog1.FileName, 0);
                }
                catch
                {
                    MessageBox.Show("Vytvořte nový soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_zkopiruj_email_chyba_Click(object sender, EventArgs e)
        {
            //Zkopírování emailů do schránky
            if (!string.IsNullOrEmpty(textBox_chybna_castka.Text))
                Clipboard.SetText(textBox_chybna_castka.Text);
        }
        private void listBox_nezaplaceno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_nezaplaceno.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_nezaplaceno.SelectedItem;
                lbl_jmeno_nezaplaceno.Text = u.Jmeno;
                lbl_prijmeni_nezaplaceno.Text = u.Prijmeni;
                lbl_email_nezaplaceni.Text = u.Email;
                lbl_id_nezaplaceno.Text = u.ID.ToString();
                //Zobrazení skupiny (rozhodnutí podle id)
                if (u.ID % 2 == 0)
                    lbl_skupina_nezaplaceno.Text = "Družstva";
                else if (u.ID % 2 != 0)
                    lbl_skupina_nezaplaceno.Text = "Přípravka";
            }
        }
        private void button_export_nezaplaceno_Click(object sender, EventArgs e)
        {
            //Uložení neplatičů do .csv
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV soubory (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    databaze.Export(oddelovac, saveFileDialog1.FileName, 2);
                }
                catch
                {
                    MessageBox.Show("Vytvořte nový soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button_zkopiruj_email_nezaplaceno_Click(object sender, EventArgs e)
        {
            //Zkopírování emailů do schránky
            if (!string.IsNullOrEmpty(textBox_nezaplaceno.Text))
                Clipboard.SetText(textBox_nezaplaceno.Text);
        }

        private void button_porovnej_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                for (int i = 0; i < zaznam_banka.Count; i++)
                {
                    index = databaze.Najdi(zaznam_banka[i].ID);
                    //if (index >=0)
                    databaze.Zaplatil(index, zaznam_banka[i].ID, zaznam_banka[i].Castka, zaznam_banka[i].Datum, castka_pripravka, castka_druzstva);
                }
            }
            catch
            {
                MessageBox.Show("Došlo k chybě, zkontrolujte formát vstupních dat.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_export_vsichni_Click(object sender, EventArgs e)
        {
            //Uložení platičů do .csv
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV soubory (*.csv)|*.csv";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    databaze.Export(oddelovac, saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Vytvořte nový soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControl1_SelectedIndexchanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                   //Stránka už je načtená
                    break;
                case 1:
                    //Výplň listboxu všichni
                    listBox_vsichni.Items.Clear();
                    listBox_vsichni.Items.AddRange(databaze.VratVsechny());
                    break;
                case 2:
                    //Výplň listboxu zaplaceno + seznam mailů
                    listBox_zaplaceno.Items.Clear();
                    listBox_zaplaceno.Items.AddRange(databaze.VratVybrane(1));
                    textBox_zaplaceno.Text = string.Join(";", databaze.VratEmail(1));
                    break;
                case 3:
                    //Výplň listboxu nezaplaceno + seznam mailů
                    listBox_nezaplaceno.Items.Clear();
                    listBox_nezaplaceno.Items.AddRange(databaze.VratVybrane(0));
                    textBox_nezaplaceno.Text = string.Join(";", databaze.VratEmail(0));
                    break;
                case 4:
                    //Výplň listboxu chybí + seznam mailů
                    listBox_chyba.Items.Clear();
                    listBox_chyba.Items.AddRange(databaze.VratVybrane(2));
                    textBox_chybna_castka.Text = string.Join(";", databaze.VratEmail(2));
                    break;
            }
        }
    }
}
