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
        public Form1()
        {
            InitializeComponent();
            // vytvoření složky aplikace v AppData
            string cesta = "";
            try
            {
                cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DatabazeUzivatelu");
                if (!Directory.Exists(cesta))
                    Directory.CreateDirectory(cesta);
            }
            catch
            {
                MessageBox.Show("Nepodařilo se vytvořit složku " + cesta + ", zkontrolujte prosím svá oprávnění.",
                  "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // vytvoření databáze
            databaze = new Databaze(Path.Combine(cesta, "uzivatele.csv"));
        }

        private void button_nacti_osoby_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Nacti(',');
                //Výplň listboxu všichni
                listBox_vsichni.Items.Clear();
                listBox_vsichni.Items.AddRange(databaze.VratVsechny());
                //Výplň listboxu zaplaceno
                listBox_zaplaceno.Items.Clear();
                listBox_zaplaceno.Items.AddRange(databaze.VratVybrane(1));
                //Výplň listboxu nezaplaceno
                listBox_nezaplaceno.Items.Clear();
                listBox_nezaplaceno.Items.AddRange(databaze.VratVybrane(0));
                //Výplň listboxu chybí
                listBox_chyba.Items.Clear();
                listBox_chyba.Items.AddRange(databaze.VratVybrane(3));
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo načíst, soubor zřejmě neexisituje.",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (u.Zaplaceno == 1)
                {
                    lbl_platba.Text = "Zaplaceno";
                    lbl_platba_datum_vsichni.Text = u.Datum.ToShortDateString();
                }
                else if (u.Zaplaceno == 2)
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
            if (radioButton_nezaplaceno.Checked)
                zaplaceno = 0;
            if (radioButton_zaplaceno.Checked)
                zaplaceno = 1;
            databaze.PridejOsobu(jmeno, prijmeni, email, id, zaplaceno);
            listBox_vsichni.Items.Add(new Osoba(jmeno, prijmeni, email, id, zaplaceno));
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

        private void button_uloz_vsichni_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Uloz(';');
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo uložit, zkontrolujte přístupová práva k souboru.",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void listBox_zaplaceno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vsichni.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_vsichni.SelectedItem;
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
                databaze.Nacti2(';',path);
                //Výplň listboxu všichni
                listBox_vsichni.Items.Clear();
                listBox_vsichni.Items.AddRange(databaze.VratVsechny());
                //Výplň listboxu zaplaceno + seznam mailů
                listBox_zaplaceno.Items.Clear();
                listBox_zaplaceno.Items.AddRange(databaze.VratVybrane(1));
                textBox_zaplaceno.Text = string.Join(";", databaze.VratEmail(1));
                //Výplň listboxu nezaplaceno + seznam mailů
                listBox_nezaplaceno.Items.Clear();
                listBox_nezaplaceno.Items.AddRange(databaze.VratVybrane(0));
                textBox_nezaplaceno.Text = string.Join(";", databaze.VratEmail(0));
                //Výplň listboxu chybí + seznam mailů
                listBox_chyba.Items.Clear();
                listBox_chyba.Items.AddRange(databaze.VratVybrane(2));
                textBox_chybna_castka.Text = string.Join(";",databaze.VratEmail(2));
            }
        }

        private void listBox_chyba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vsichni.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_vsichni.SelectedItem;
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

        private void listBox_nezaplaceno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_vsichni.SelectedItem != null)
            {
                //Zobrazeni detailu vybrane osoby
                Osoba u = (Osoba)listBox_vsichni.SelectedItem;
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

        private void button_kopiruj_email_zaplaceno_Click(object sender, EventArgs e)
        {
            //Zkopírování emailů do schránky
            if (!string.IsNullOrEmpty(textBox_zaplaceno.Text))
                Clipboard.SetText(textBox_zaplaceno.Text);
        }

        private void button_export_zaplaceno_Click(object sender, EventArgs e)
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
                databaze.Export(';', saveFileDialog1.FileName,1);
            }
        }
    }
}
