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
                listBox_vsichni.Items.Clear();
                listBox_vsichni.Items.AddRange(databaze.VratVsechny());
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
                Osoba u = (Osoba)listBox_vsichni.SelectedItem;
                lbl_jmeno_vsichni.Text = u.Jmeno;
                lbl_prijmeni_vsichni.Text = u.Prijmeni;
                lbl_email_vsichni.Text = u.Email;
                lbl_id_vsichni.Text = u.ID.ToString();
                if (u.ID % 2 == 0)
                    lbl_skupina_vsichni.Text = "Družstva";
                else if (u.ID % 2 != 0)
                    lbl_skupina_vsichni.Text = "Přípravka";
            }
        }

        private void button_pridat_databaze_Click(object sender, EventArgs e)
        {
            string jmeno = textBox_jmeno_vsichni.Text;
            string prijmeni = textBox_prijmeni_vsichni.Text;
            string email = textBox_email_vsichni.Text;
            uint id = (uint)numericUpDown_id_vsichni.Value;
            databaze.PridejOsobu(jmeno, prijmeni, email, id, 0);
            listBox_vsichni.Items.Add(new Osoba(jmeno, prijmeni, email, id, 0));
        }

        private void button_uloz_vsichni_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Uloz(",");
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo uložit, zkontrolujte přístupová práva k souboru.",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
