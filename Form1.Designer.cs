
namespace semestralka_windows_forms
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_import_banka = new System.Windows.Forms.Button();
            this.button_nacti_osoby = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox_vsichni = new System.Windows.Forms.ListBox();
            this.lbl_vsichni_tabulka = new System.Windows.Forms.Label();
            this.groupBox_detail_vsichni = new System.Windows.Forms.GroupBox();
            this.lbl_skupina_vsichni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_id_vsichni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_prijmeni_vsichni = new System.Windows.Forms.Label();
            this.button_odebrat_databaze = new System.Windows.Forms.Button();
            this.lbl_platba_datum_vsichni = new System.Windows.Forms.Label();
            this.lbl_platba = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_email_vsichni = new System.Windows.Forms.Label();
            this.lbl_email_nadpis = new System.Windows.Forms.Label();
            this.lbl_jmeno_vsichni = new System.Windows.Forms.Label();
            this.lbl_jmeno_nadpis = new System.Windows.Forms.Label();
            this.button_pridat_databaze = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox_oddelovac = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_export_vsichni = new System.Windows.Forms.Button();
            this.groupBox_pridat_vsichni = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton_nezaplaceno = new System.Windows.Forms.RadioButton();
            this.radioButton_zaplaceno = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_id_vsichni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email_vsichni = new System.Windows.Forms.TextBox();
            this.textBox_prijmeni_vsichni = new System.Windows.Forms.TextBox();
            this.textBox_jmeno_vsichni = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_email_zaplaceno = new System.Windows.Forms.Label();
            this.textBox_zaplaceno = new System.Windows.Forms.TextBox();
            this.button_export_zaplaceno = new System.Windows.Forms.Button();
            this.button_kopiruj_email_zaplaceno = new System.Windows.Forms.Button();
            this.listBox_zaplaceno = new System.Windows.Forms.ListBox();
            this.lbl_zaplaceno_tabulka = new System.Windows.Forms.Label();
            this.groupBox_detail_zaplaceno = new System.Windows.Forms.GroupBox();
            this.lbl_skupina_zaplaceno = new System.Windows.Forms.Label();
            this.Skupina = new System.Windows.Forms.Label();
            this.lbl_id_zaplaceno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_prijmeni_zaplaceno = new System.Windows.Forms.Label();
            this.lbl_datum_platba_zaplaceno = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_email_zaplaceni = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_jmeno_zaplaceno = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_skupina_nezaplaceno = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_id_nezaplaceno = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_prijmeni_nezaplaceno = new System.Windows.Forms.Label();
            this.lbl_email_nezaplaceni = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lbl_jmeno_nezaplaceno = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lbl_email_nezaplaceno = new System.Windows.Forms.Label();
            this.textBox_nezaplaceno = new System.Windows.Forms.TextBox();
            this.button_export_nezaplaceno = new System.Windows.Forms.Button();
            this.button_zkopiruj_email_nezaplaceno = new System.Windows.Forms.Button();
            this.listBox_nezaplaceno = new System.Windows.Forms.ListBox();
            this.lbl_nezaplaceno_tabulka = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_castka_chyba = new System.Windows.Forms.Label();
            this.lbl_skupina_chyba = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_id_chyba = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_prijmeni_chyba = new System.Windows.Forms.Label();
            this.lbl_datum_chyba = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_email_chyba = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_jmeno_chyba = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.listBox_chyba = new System.Windows.Forms.ListBox();
            this.lbl_chyba_tabulka = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_chybna_castka = new System.Windows.Forms.TextBox();
            this.button_export_chyba = new System.Windows.Forms.Button();
            this.button_zkopiruj_email_chyba = new System.Windows.Forms.Button();
            this.button_porovnej = new System.Windows.Forms.Button();
            this.numericUpDown_druzstva = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_pripravka = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_import_osob_cesta = new System.Windows.Forms.Label();
            this.lbl_import_plateb_cesta = new System.Windows.Forms.Label();
            this.groupBox_detail_vsichni.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox_pridat_vsichni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id_vsichni)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox_detail_zaplaceno.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_druzstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pripravka)).BeginInit();
            this.SuspendLayout();
            // 
            // button_import_banka
            // 
            this.button_import_banka.Location = new System.Drawing.Point(593, 362);
            this.button_import_banka.Name = "button_import_banka";
            this.button_import_banka.Size = new System.Drawing.Size(89, 23);
            this.button_import_banka.TabIndex = 0;
            this.button_import_banka.Text = "Import plateb";
            this.button_import_banka.UseVisualStyleBackColor = true;
            this.button_import_banka.Click += new System.EventHandler(this.button_import_banka_Click);
            // 
            // button_nacti_osoby
            // 
            this.button_nacti_osoby.Location = new System.Drawing.Point(593, 333);
            this.button_nacti_osoby.Name = "button_nacti_osoby";
            this.button_nacti_osoby.Size = new System.Drawing.Size(75, 23);
            this.button_nacti_osoby.TabIndex = 2;
            this.button_nacti_osoby.Text = "Import osob";
            this.button_nacti_osoby.UseVisualStyleBackColor = true;
            this.button_nacti_osoby.Click += new System.EventHandler(this.button_nacti_osoby_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Title = "Exportovat osoby";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox_vsichni
            // 
            this.listBox_vsichni.FormattingEnabled = true;
            this.listBox_vsichni.Location = new System.Drawing.Point(6, 61);
            this.listBox_vsichni.Name = "listBox_vsichni";
            this.listBox_vsichni.Size = new System.Drawing.Size(249, 316);
            this.listBox_vsichni.Sorted = true;
            this.listBox_vsichni.TabIndex = 3;
            this.listBox_vsichni.SelectedIndexChanged += new System.EventHandler(this.listBox_vsichni_SelectedIndexChanged);
            // 
            // lbl_vsichni_tabulka
            // 
            this.lbl_vsichni_tabulka.AutoSize = true;
            this.lbl_vsichni_tabulka.Location = new System.Drawing.Point(6, 45);
            this.lbl_vsichni_tabulka.Name = "lbl_vsichni_tabulka";
            this.lbl_vsichni_tabulka.Size = new System.Drawing.Size(71, 13);
            this.lbl_vsichni_tabulka.TabIndex = 6;
            this.lbl_vsichni_tabulka.Text = "Seznam osob";
            // 
            // groupBox_detail_vsichni
            // 
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_skupina_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.label5);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_id_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.label4);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_prijmeni_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.button_odebrat_databaze);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_platba_datum_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_platba);
            this.groupBox_detail_vsichni.Controls.Add(this.label8);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_email_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_email_nadpis);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_jmeno_vsichni);
            this.groupBox_detail_vsichni.Controls.Add(this.lbl_jmeno_nadpis);
            this.groupBox_detail_vsichni.Location = new System.Drawing.Point(293, 61);
            this.groupBox_detail_vsichni.Name = "groupBox_detail_vsichni";
            this.groupBox_detail_vsichni.Size = new System.Drawing.Size(198, 257);
            this.groupBox_detail_vsichni.TabIndex = 10;
            this.groupBox_detail_vsichni.TabStop = false;
            this.groupBox_detail_vsichni.Text = "Detail vybrané osoby:";
            // 
            // lbl_skupina_vsichni
            // 
            this.lbl_skupina_vsichni.AutoSize = true;
            this.lbl_skupina_vsichni.Location = new System.Drawing.Point(100, 123);
            this.lbl_skupina_vsichni.Name = "lbl_skupina_vsichni";
            this.lbl_skupina_vsichni.Size = new System.Drawing.Size(59, 13);
            this.lbl_skupina_vsichni.TabIndex = 19;
            this.lbl_skupina_vsichni.Text = "Nevybráno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Skupina";
            // 
            // lbl_id_vsichni
            // 
            this.lbl_id_vsichni.AutoSize = true;
            this.lbl_id_vsichni.Location = new System.Drawing.Point(6, 123);
            this.lbl_id_vsichni.Name = "lbl_id_vsichni";
            this.lbl_id_vsichni.Size = new System.Drawing.Size(59, 13);
            this.lbl_id_vsichni.TabIndex = 17;
            this.lbl_id_vsichni.Text = "Nevybráno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID";
            // 
            // lbl_prijmeni_vsichni
            // 
            this.lbl_prijmeni_vsichni.AutoSize = true;
            this.lbl_prijmeni_vsichni.Location = new System.Drawing.Point(100, 47);
            this.lbl_prijmeni_vsichni.Name = "lbl_prijmeni_vsichni";
            this.lbl_prijmeni_vsichni.Size = new System.Drawing.Size(59, 13);
            this.lbl_prijmeni_vsichni.TabIndex = 15;
            this.lbl_prijmeni_vsichni.Text = "Nevybráno";
            // 
            // button_odebrat_databaze
            // 
            this.button_odebrat_databaze.Location = new System.Drawing.Point(103, 228);
            this.button_odebrat_databaze.Name = "button_odebrat_databaze";
            this.button_odebrat_databaze.Size = new System.Drawing.Size(90, 23);
            this.button_odebrat_databaze.TabIndex = 15;
            this.button_odebrat_databaze.Text = "Odeber osobu";
            this.button_odebrat_databaze.UseVisualStyleBackColor = true;
            this.button_odebrat_databaze.Click += new System.EventHandler(this.button_odebrat_databaze_Click);
            // 
            // lbl_platba_datum_vsichni
            // 
            this.lbl_platba_datum_vsichni.AutoSize = true;
            this.lbl_platba_datum_vsichni.Location = new System.Drawing.Point(135, 169);
            this.lbl_platba_datum_vsichni.Name = "lbl_platba_datum_vsichni";
            this.lbl_platba_datum_vsichni.Size = new System.Drawing.Size(41, 13);
            this.lbl_platba_datum_vsichni.TabIndex = 14;
            this.lbl_platba_datum_vsichni.Text = "label10";
            // 
            // lbl_platba
            // 
            this.lbl_platba.AutoSize = true;
            this.lbl_platba.Location = new System.Drawing.Point(6, 169);
            this.lbl_platba.Name = "lbl_platba";
            this.lbl_platba.Size = new System.Drawing.Size(59, 13);
            this.lbl_platba.TabIndex = 13;
            this.lbl_platba.Text = "Nevybráno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Platba";
            // 
            // lbl_email_vsichni
            // 
            this.lbl_email_vsichni.AutoSize = true;
            this.lbl_email_vsichni.Location = new System.Drawing.Point(6, 87);
            this.lbl_email_vsichni.Name = "lbl_email_vsichni";
            this.lbl_email_vsichni.Size = new System.Drawing.Size(59, 13);
            this.lbl_email_vsichni.TabIndex = 11;
            this.lbl_email_vsichni.Text = "Nevybráno";
            // 
            // lbl_email_nadpis
            // 
            this.lbl_email_nadpis.AutoSize = true;
            this.lbl_email_nadpis.Location = new System.Drawing.Point(6, 74);
            this.lbl_email_nadpis.Name = "lbl_email_nadpis";
            this.lbl_email_nadpis.Size = new System.Drawing.Size(32, 13);
            this.lbl_email_nadpis.TabIndex = 10;
            this.lbl_email_nadpis.Text = "Email";
            // 
            // lbl_jmeno_vsichni
            // 
            this.lbl_jmeno_vsichni.AutoSize = true;
            this.lbl_jmeno_vsichni.Location = new System.Drawing.Point(6, 47);
            this.lbl_jmeno_vsichni.Name = "lbl_jmeno_vsichni";
            this.lbl_jmeno_vsichni.Size = new System.Drawing.Size(59, 13);
            this.lbl_jmeno_vsichni.TabIndex = 9;
            this.lbl_jmeno_vsichni.Text = "Nevybráno";
            // 
            // lbl_jmeno_nadpis
            // 
            this.lbl_jmeno_nadpis.AutoSize = true;
            this.lbl_jmeno_nadpis.Location = new System.Drawing.Point(6, 28);
            this.lbl_jmeno_nadpis.Name = "lbl_jmeno_nadpis";
            this.lbl_jmeno_nadpis.Size = new System.Drawing.Size(91, 13);
            this.lbl_jmeno_nadpis.TabIndex = 8;
            this.lbl_jmeno_nadpis.Text = "Jméno a přijmení:";
            // 
            // button_pridat_databaze
            // 
            this.button_pridat_databaze.Location = new System.Drawing.Point(120, 228);
            this.button_pridat_databaze.Name = "button_pridat_databaze";
            this.button_pridat_databaze.Size = new System.Drawing.Size(75, 23);
            this.button_pridat_databaze.TabIndex = 12;
            this.button_pridat_databaze.Text = "Přidej osobu";
            this.button_pridat_databaze.UseVisualStyleBackColor = true;
            this.button_pridat_databaze.Click += new System.EventHandler(this.button_pridat_databaze_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 419);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexchanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbl_import_plateb_cesta);
            this.tabPage4.Controls.Add(this.lbl_import_osob_cesta);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.numericUpDown_pripravka);
            this.tabPage4.Controls.Add(this.button_import_banka);
            this.tabPage4.Controls.Add(this.button_nacti_osoby);
            this.tabPage4.Controls.Add(this.numericUpDown_druzstva);
            this.tabPage4.Controls.Add(this.comboBox_oddelovac);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(793, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Instrukce";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox_oddelovac
            // 
            this.comboBox_oddelovac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_oddelovac.FormattingEnabled = true;
            this.comboBox_oddelovac.Items.AddRange(new object[] {
            ";",
            ",",
            "|",
            ":"});
            this.comboBox_oddelovac.Location = new System.Drawing.Point(385, 338);
            this.comboBox_oddelovac.Name = "comboBox_oddelovac";
            this.comboBox_oddelovac.Size = new System.Drawing.Size(54, 21);
            this.comboBox_oddelovac.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(693, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(592, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 75);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 338);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(125, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Výše příspěvků družstva";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_export_vsichni);
            this.tabPage1.Controls.Add(this.groupBox_pridat_vsichni);
            this.tabPage1.Controls.Add(this.listBox_vsichni);
            this.tabPage1.Controls.Add(this.lbl_vsichni_tabulka);
            this.tabPage1.Controls.Add(this.groupBox_detail_vsichni);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Všichni";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_export_vsichni
            // 
            this.button_export_vsichni.Location = new System.Drawing.Point(638, 354);
            this.button_export_vsichni.Name = "button_export_vsichni";
            this.button_export_vsichni.Size = new System.Drawing.Size(96, 23);
            this.button_export_vsichni.TabIndex = 16;
            this.button_export_vsichni.Text = "Export osob";
            this.button_export_vsichni.UseVisualStyleBackColor = true;
            this.button_export_vsichni.Click += new System.EventHandler(this.button_export_vsichni_Click);
            // 
            // groupBox_pridat_vsichni
            // 
            this.groupBox_pridat_vsichni.Controls.Add(this.dateTimePicker);
            this.groupBox_pridat_vsichni.Controls.Add(this.radioButton_nezaplaceno);
            this.groupBox_pridat_vsichni.Controls.Add(this.radioButton_zaplaceno);
            this.groupBox_pridat_vsichni.Controls.Add(this.label7);
            this.groupBox_pridat_vsichni.Controls.Add(this.numericUpDown_id_vsichni);
            this.groupBox_pridat_vsichni.Controls.Add(this.label1);
            this.groupBox_pridat_vsichni.Controls.Add(this.textBox_email_vsichni);
            this.groupBox_pridat_vsichni.Controls.Add(this.textBox_prijmeni_vsichni);
            this.groupBox_pridat_vsichni.Controls.Add(this.button_pridat_databaze);
            this.groupBox_pridat_vsichni.Controls.Add(this.textBox_jmeno_vsichni);
            this.groupBox_pridat_vsichni.Controls.Add(this.label27);
            this.groupBox_pridat_vsichni.Controls.Add(this.label29);
            this.groupBox_pridat_vsichni.Controls.Add(this.label31);
            this.groupBox_pridat_vsichni.Location = new System.Drawing.Point(533, 61);
            this.groupBox_pridat_vsichni.Name = "groupBox_pridat_vsichni";
            this.groupBox_pridat_vsichni.Size = new System.Drawing.Size(201, 257);
            this.groupBox_pridat_vsichni.TabIndex = 14;
            this.groupBox_pridat_vsichni.TabStop = false;
            this.groupBox_pridat_vsichni.Text = "Přidat novou osobu";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(27, 192);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeftLayout = true;
            this.dateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker.TabIndex = 23;
            // 
            // radioButton_nezaplaceno
            // 
            this.radioButton_nezaplaceno.AutoSize = true;
            this.radioButton_nezaplaceno.Location = new System.Drawing.Point(126, 169);
            this.radioButton_nezaplaceno.Name = "radioButton_nezaplaceno";
            this.radioButton_nezaplaceno.Size = new System.Drawing.Size(39, 17);
            this.radioButton_nezaplaceno.TabIndex = 22;
            this.radioButton_nezaplaceno.TabStop = true;
            this.radioButton_nezaplaceno.Text = "Ne";
            this.radioButton_nezaplaceno.UseVisualStyleBackColor = true;
            // 
            // radioButton_zaplaceno
            // 
            this.radioButton_zaplaceno.AutoSize = true;
            this.radioButton_zaplaceno.Location = new System.Drawing.Point(71, 169);
            this.radioButton_zaplaceno.Name = "radioButton_zaplaceno";
            this.radioButton_zaplaceno.Size = new System.Drawing.Size(44, 17);
            this.radioButton_zaplaceno.TabIndex = 21;
            this.radioButton_zaplaceno.TabStop = true;
            this.radioButton_zaplaceno.Text = "Ano";
            this.radioButton_zaplaceno.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Zaplaceno";
            // 
            // numericUpDown_id_vsichni
            // 
            this.numericUpDown_id_vsichni.Location = new System.Drawing.Point(62, 133);
            this.numericUpDown_id_vsichni.Name = "numericUpDown_id_vsichni";
            this.numericUpDown_id_vsichni.Size = new System.Drawing.Size(133, 20);
            this.numericUpDown_id_vsichni.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // textBox_email_vsichni
            // 
            this.textBox_email_vsichni.Location = new System.Drawing.Point(62, 103);
            this.textBox_email_vsichni.Name = "textBox_email_vsichni";
            this.textBox_email_vsichni.Size = new System.Drawing.Size(133, 20);
            this.textBox_email_vsichni.TabIndex = 15;
            // 
            // textBox_prijmeni_vsichni
            // 
            this.textBox_prijmeni_vsichni.Location = new System.Drawing.Point(62, 67);
            this.textBox_prijmeni_vsichni.Name = "textBox_prijmeni_vsichni";
            this.textBox_prijmeni_vsichni.Size = new System.Drawing.Size(133, 20);
            this.textBox_prijmeni_vsichni.TabIndex = 14;
            // 
            // textBox_jmeno_vsichni
            // 
            this.textBox_jmeno_vsichni.Location = new System.Drawing.Point(62, 25);
            this.textBox_jmeno_vsichni.Name = "textBox_jmeno_vsichni";
            this.textBox_jmeno_vsichni.Size = new System.Drawing.Size(133, 20);
            this.textBox_jmeno_vsichni.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 106);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Email";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "Příijmení";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "Jméno";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_email_zaplaceno);
            this.tabPage2.Controls.Add(this.textBox_zaplaceno);
            this.tabPage2.Controls.Add(this.button_export_zaplaceno);
            this.tabPage2.Controls.Add(this.button_kopiruj_email_zaplaceno);
            this.tabPage2.Controls.Add(this.listBox_zaplaceno);
            this.tabPage2.Controls.Add(this.lbl_zaplaceno_tabulka);
            this.tabPage2.Controls.Add(this.groupBox_detail_zaplaceno);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zaplaceno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_email_zaplaceno
            // 
            this.lbl_email_zaplaceno.AutoSize = true;
            this.lbl_email_zaplaceno.Location = new System.Drawing.Point(497, 55);
            this.lbl_email_zaplaceno.Name = "lbl_email_zaplaceno";
            this.lbl_email_zaplaceno.Size = new System.Drawing.Size(81, 13);
            this.lbl_email_zaplaceno.TabIndex = 17;
            this.lbl_email_zaplaceno.Text = "Seznam emailů:";
            // 
            // textBox_zaplaceno
            // 
            this.textBox_zaplaceno.Location = new System.Drawing.Point(500, 71);
            this.textBox_zaplaceno.Multiline = true;
            this.textBox_zaplaceno.Name = "textBox_zaplaceno";
            this.textBox_zaplaceno.Size = new System.Drawing.Size(262, 266);
            this.textBox_zaplaceno.TabIndex = 16;
            // 
            // button_export_zaplaceno
            // 
            this.button_export_zaplaceno.Location = new System.Drawing.Point(500, 354);
            this.button_export_zaplaceno.Name = "button_export_zaplaceno";
            this.button_export_zaplaceno.Size = new System.Drawing.Size(75, 23);
            this.button_export_zaplaceno.TabIndex = 15;
            this.button_export_zaplaceno.Text = "Export osob";
            this.button_export_zaplaceno.UseVisualStyleBackColor = true;
            this.button_export_zaplaceno.Click += new System.EventHandler(this.button_export_zaplaceno_Click);
            // 
            // button_kopiruj_email_zaplaceno
            // 
            this.button_kopiruj_email_zaplaceno.Location = new System.Drawing.Point(665, 354);
            this.button_kopiruj_email_zaplaceno.Name = "button_kopiruj_email_zaplaceno";
            this.button_kopiruj_email_zaplaceno.Size = new System.Drawing.Size(97, 23);
            this.button_kopiruj_email_zaplaceno.TabIndex = 14;
            this.button_kopiruj_email_zaplaceno.Text = "Zkopíruj emaily";
            this.button_kopiruj_email_zaplaceno.UseVisualStyleBackColor = true;
            this.button_kopiruj_email_zaplaceno.Click += new System.EventHandler(this.button_kopiruj_email_zaplaceno_Click);
            // 
            // listBox_zaplaceno
            // 
            this.listBox_zaplaceno.FormattingEnabled = true;
            this.listBox_zaplaceno.Location = new System.Drawing.Point(6, 61);
            this.listBox_zaplaceno.Name = "listBox_zaplaceno";
            this.listBox_zaplaceno.Size = new System.Drawing.Size(249, 316);
            this.listBox_zaplaceno.Sorted = true;
            this.listBox_zaplaceno.TabIndex = 11;
            this.listBox_zaplaceno.SelectedIndexChanged += new System.EventHandler(this.listBox_zaplaceno_SelectedIndexChanged);
            // 
            // lbl_zaplaceno_tabulka
            // 
            this.lbl_zaplaceno_tabulka.AutoSize = true;
            this.lbl_zaplaceno_tabulka.Location = new System.Drawing.Point(6, 42);
            this.lbl_zaplaceno_tabulka.Name = "lbl_zaplaceno_tabulka";
            this.lbl_zaplaceno_tabulka.Size = new System.Drawing.Size(71, 13);
            this.lbl_zaplaceno_tabulka.TabIndex = 12;
            this.lbl_zaplaceno_tabulka.Text = "Seznam osob";
            // 
            // groupBox_detail_zaplaceno
            // 
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_skupina_zaplaceno);
            this.groupBox_detail_zaplaceno.Controls.Add(this.Skupina);
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_id_zaplaceno);
            this.groupBox_detail_zaplaceno.Controls.Add(this.label6);
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_prijmeni_zaplaceno);
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_datum_platba_zaplaceno);
            this.groupBox_detail_zaplaceno.Controls.Add(this.label20);
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_email_zaplaceni);
            this.groupBox_detail_zaplaceno.Controls.Add(this.label22);
            this.groupBox_detail_zaplaceno.Controls.Add(this.lbl_jmeno_zaplaceno);
            this.groupBox_detail_zaplaceno.Controls.Add(this.label24);
            this.groupBox_detail_zaplaceno.Location = new System.Drawing.Point(282, 61);
            this.groupBox_detail_zaplaceno.Name = "groupBox_detail_zaplaceno";
            this.groupBox_detail_zaplaceno.Size = new System.Drawing.Size(201, 316);
            this.groupBox_detail_zaplaceno.TabIndex = 13;
            this.groupBox_detail_zaplaceno.TabStop = false;
            this.groupBox_detail_zaplaceno.Text = "Detail vybrané osoby:";
            // 
            // lbl_skupina_zaplaceno
            // 
            this.lbl_skupina_zaplaceno.AutoSize = true;
            this.lbl_skupina_zaplaceno.Location = new System.Drawing.Point(6, 176);
            this.lbl_skupina_zaplaceno.Name = "lbl_skupina_zaplaceno";
            this.lbl_skupina_zaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_skupina_zaplaceno.TabIndex = 19;
            this.lbl_skupina_zaplaceno.Text = "Nevybráno";
            // 
            // Skupina
            // 
            this.Skupina.AutoSize = true;
            this.Skupina.Location = new System.Drawing.Point(6, 163);
            this.Skupina.Name = "Skupina";
            this.Skupina.Size = new System.Drawing.Size(46, 13);
            this.Skupina.TabIndex = 18;
            this.Skupina.Text = "Skupina";
            // 
            // lbl_id_zaplaceno
            // 
            this.lbl_id_zaplaceno.AutoSize = true;
            this.lbl_id_zaplaceno.Location = new System.Drawing.Point(6, 133);
            this.lbl_id_zaplaceno.Name = "lbl_id_zaplaceno";
            this.lbl_id_zaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_id_zaplaceno.TabIndex = 17;
            this.lbl_id_zaplaceno.Text = "Nevybráno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // lbl_prijmeni_zaplaceno
            // 
            this.lbl_prijmeni_zaplaceno.AutoSize = true;
            this.lbl_prijmeni_zaplaceno.Location = new System.Drawing.Point(101, 47);
            this.lbl_prijmeni_zaplaceno.Name = "lbl_prijmeni_zaplaceno";
            this.lbl_prijmeni_zaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_prijmeni_zaplaceno.TabIndex = 15;
            this.lbl_prijmeni_zaplaceno.Text = "Nevybráno";
            // 
            // lbl_datum_platba_zaplaceno
            // 
            this.lbl_datum_platba_zaplaceno.AutoSize = true;
            this.lbl_datum_platba_zaplaceno.Location = new System.Drawing.Point(81, 203);
            this.lbl_datum_platba_zaplaceno.Name = "lbl_datum_platba_zaplaceno";
            this.lbl_datum_platba_zaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_datum_platba_zaplaceno.TabIndex = 14;
            this.lbl_datum_platba_zaplaceno.Text = "Nevybráno";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Datum platby";
            // 
            // lbl_email_zaplaceni
            // 
            this.lbl_email_zaplaceni.AutoSize = true;
            this.lbl_email_zaplaceni.Location = new System.Drawing.Point(6, 90);
            this.lbl_email_zaplaceni.Name = "lbl_email_zaplaceni";
            this.lbl_email_zaplaceni.Size = new System.Drawing.Size(59, 13);
            this.lbl_email_zaplaceni.TabIndex = 11;
            this.lbl_email_zaplaceni.Text = "Nevybráno";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Email";
            // 
            // lbl_jmeno_zaplaceno
            // 
            this.lbl_jmeno_zaplaceno.AutoSize = true;
            this.lbl_jmeno_zaplaceno.Location = new System.Drawing.Point(6, 47);
            this.lbl_jmeno_zaplaceno.Name = "lbl_jmeno_zaplaceno";
            this.lbl_jmeno_zaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_jmeno_zaplaceno.TabIndex = 9;
            this.lbl_jmeno_zaplaceno.Text = "Nevybráno";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Jméno a příjmení";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.lbl_email_nezaplaceno);
            this.tabPage3.Controls.Add(this.textBox_nezaplaceno);
            this.tabPage3.Controls.Add(this.button_export_nezaplaceno);
            this.tabPage3.Controls.Add(this.button_zkopiruj_email_nezaplaceno);
            this.tabPage3.Controls.Add(this.listBox_nezaplaceno);
            this.tabPage3.Controls.Add(this.lbl_nezaplaceno_tabulka);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nezaplaceno";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_skupina_nezaplaceno);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lbl_id_nezaplaceno);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lbl_prijmeni_nezaplaceno);
            this.groupBox2.Controls.Add(this.lbl_email_nezaplaceni);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.lbl_jmeno_nezaplaceno);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Location = new System.Drawing.Point(282, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 316);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail vybrané osoby:";
            // 
            // lbl_skupina_nezaplaceno
            // 
            this.lbl_skupina_nezaplaceno.AutoSize = true;
            this.lbl_skupina_nezaplaceno.Location = new System.Drawing.Point(6, 176);
            this.lbl_skupina_nezaplaceno.Name = "lbl_skupina_nezaplaceno";
            this.lbl_skupina_nezaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_skupina_nezaplaceno.TabIndex = 19;
            this.lbl_skupina_nezaplaceno.Text = "Nevybráno";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 163);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Skupina";
            // 
            // lbl_id_nezaplaceno
            // 
            this.lbl_id_nezaplaceno.AutoSize = true;
            this.lbl_id_nezaplaceno.Location = new System.Drawing.Point(6, 133);
            this.lbl_id_nezaplaceno.Name = "lbl_id_nezaplaceno";
            this.lbl_id_nezaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_id_nezaplaceno.TabIndex = 17;
            this.lbl_id_nezaplaceno.Text = "Nevybráno";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "ID";
            // 
            // lbl_prijmeni_nezaplaceno
            // 
            this.lbl_prijmeni_nezaplaceno.AutoSize = true;
            this.lbl_prijmeni_nezaplaceno.Location = new System.Drawing.Point(101, 47);
            this.lbl_prijmeni_nezaplaceno.Name = "lbl_prijmeni_nezaplaceno";
            this.lbl_prijmeni_nezaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_prijmeni_nezaplaceno.TabIndex = 15;
            this.lbl_prijmeni_nezaplaceno.Text = "Nevybráno";
            // 
            // lbl_email_nezaplaceni
            // 
            this.lbl_email_nezaplaceni.AutoSize = true;
            this.lbl_email_nezaplaceni.Location = new System.Drawing.Point(6, 90);
            this.lbl_email_nezaplaceni.Name = "lbl_email_nezaplaceni";
            this.lbl_email_nezaplaceni.Size = new System.Drawing.Size(59, 13);
            this.lbl_email_nezaplaceni.TabIndex = 11;
            this.lbl_email_nezaplaceni.Text = "Nevybráno";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 77);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(32, 13);
            this.label41.TabIndex = 10;
            this.label41.Text = "Email";
            // 
            // lbl_jmeno_nezaplaceno
            // 
            this.lbl_jmeno_nezaplaceno.AutoSize = true;
            this.lbl_jmeno_nezaplaceno.Location = new System.Drawing.Point(6, 47);
            this.lbl_jmeno_nezaplaceno.Name = "lbl_jmeno_nezaplaceno";
            this.lbl_jmeno_nezaplaceno.Size = new System.Drawing.Size(59, 13);
            this.lbl_jmeno_nezaplaceno.TabIndex = 9;
            this.lbl_jmeno_nezaplaceno.Text = "Nevybráno";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(90, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Jméno a příjmení";
            // 
            // lbl_email_nezaplaceno
            // 
            this.lbl_email_nezaplaceno.AutoSize = true;
            this.lbl_email_nezaplaceno.Location = new System.Drawing.Point(497, 55);
            this.lbl_email_nezaplaceno.Name = "lbl_email_nezaplaceno";
            this.lbl_email_nezaplaceno.Size = new System.Drawing.Size(81, 13);
            this.lbl_email_nezaplaceno.TabIndex = 18;
            this.lbl_email_nezaplaceno.Text = "Seznam emailů:";
            // 
            // textBox_nezaplaceno
            // 
            this.textBox_nezaplaceno.Location = new System.Drawing.Point(500, 71);
            this.textBox_nezaplaceno.Multiline = true;
            this.textBox_nezaplaceno.Name = "textBox_nezaplaceno";
            this.textBox_nezaplaceno.Size = new System.Drawing.Size(262, 266);
            this.textBox_nezaplaceno.TabIndex = 17;
            // 
            // button_export_nezaplaceno
            // 
            this.button_export_nezaplaceno.Location = new System.Drawing.Point(500, 354);
            this.button_export_nezaplaceno.Name = "button_export_nezaplaceno";
            this.button_export_nezaplaceno.Size = new System.Drawing.Size(75, 23);
            this.button_export_nezaplaceno.TabIndex = 15;
            this.button_export_nezaplaceno.Text = "Export osob";
            this.button_export_nezaplaceno.UseVisualStyleBackColor = true;
            this.button_export_nezaplaceno.Click += new System.EventHandler(this.button_export_nezaplaceno_Click);
            // 
            // button_zkopiruj_email_nezaplaceno
            // 
            this.button_zkopiruj_email_nezaplaceno.Location = new System.Drawing.Point(675, 354);
            this.button_zkopiruj_email_nezaplaceno.Name = "button_zkopiruj_email_nezaplaceno";
            this.button_zkopiruj_email_nezaplaceno.Size = new System.Drawing.Size(87, 23);
            this.button_zkopiruj_email_nezaplaceno.TabIndex = 14;
            this.button_zkopiruj_email_nezaplaceno.Text = "Zkopíruj emaily";
            this.button_zkopiruj_email_nezaplaceno.UseVisualStyleBackColor = true;
            this.button_zkopiruj_email_nezaplaceno.Click += new System.EventHandler(this.button_zkopiruj_email_nezaplaceno_Click);
            // 
            // listBox_nezaplaceno
            // 
            this.listBox_nezaplaceno.FormattingEnabled = true;
            this.listBox_nezaplaceno.Location = new System.Drawing.Point(6, 61);
            this.listBox_nezaplaceno.Name = "listBox_nezaplaceno";
            this.listBox_nezaplaceno.Size = new System.Drawing.Size(249, 316);
            this.listBox_nezaplaceno.Sorted = true;
            this.listBox_nezaplaceno.TabIndex = 11;
            this.listBox_nezaplaceno.SelectedIndexChanged += new System.EventHandler(this.listBox_nezaplaceno_SelectedIndexChanged);
            // 
            // lbl_nezaplaceno_tabulka
            // 
            this.lbl_nezaplaceno_tabulka.AutoSize = true;
            this.lbl_nezaplaceno_tabulka.Location = new System.Drawing.Point(6, 42);
            this.lbl_nezaplaceno_tabulka.Name = "lbl_nezaplaceno_tabulka";
            this.lbl_nezaplaceno_tabulka.Size = new System.Drawing.Size(74, 13);
            this.lbl_nezaplaceno_tabulka.TabIndex = 12;
            this.lbl_nezaplaceno_tabulka.Text = "Seznam osob:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.listBox_chyba);
            this.tabPage5.Controls.Add(this.lbl_chyba_tabulka);
            this.tabPage5.Controls.Add(this.label38);
            this.tabPage5.Controls.Add(this.textBox_chybna_castka);
            this.tabPage5.Controls.Add(this.button_export_chyba);
            this.tabPage5.Controls.Add(this.button_zkopiruj_email_chyba);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(793, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Chybná částka";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_castka_chyba);
            this.groupBox3.Controls.Add(this.lbl_skupina_chyba);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbl_id_chyba);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbl_prijmeni_chyba);
            this.groupBox3.Controls.Add(this.lbl_datum_chyba);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lbl_email_chyba);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbl_jmeno_chyba);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(281, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 316);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail vybrané osoby:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Částka";
            // 
            // lbl_castka_chyba
            // 
            this.lbl_castka_chyba.AutoSize = true;
            this.lbl_castka_chyba.Location = new System.Drawing.Point(81, 237);
            this.lbl_castka_chyba.Name = "lbl_castka_chyba";
            this.lbl_castka_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_castka_chyba.TabIndex = 20;
            this.lbl_castka_chyba.Text = "Nevybráno";
            // 
            // lbl_skupina_chyba
            // 
            this.lbl_skupina_chyba.AutoSize = true;
            this.lbl_skupina_chyba.Location = new System.Drawing.Point(6, 176);
            this.lbl_skupina_chyba.Name = "lbl_skupina_chyba";
            this.lbl_skupina_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_skupina_chyba.TabIndex = 19;
            this.lbl_skupina_chyba.Text = "Nevybráno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Skupina";
            // 
            // lbl_id_chyba
            // 
            this.lbl_id_chyba.AutoSize = true;
            this.lbl_id_chyba.Location = new System.Drawing.Point(6, 133);
            this.lbl_id_chyba.Name = "lbl_id_chyba";
            this.lbl_id_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_id_chyba.TabIndex = 17;
            this.lbl_id_chyba.Text = "Nevybráno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "ID";
            // 
            // lbl_prijmeni_chyba
            // 
            this.lbl_prijmeni_chyba.AutoSize = true;
            this.lbl_prijmeni_chyba.Location = new System.Drawing.Point(101, 47);
            this.lbl_prijmeni_chyba.Name = "lbl_prijmeni_chyba";
            this.lbl_prijmeni_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_prijmeni_chyba.TabIndex = 15;
            this.lbl_prijmeni_chyba.Text = "Nevybráno";
            // 
            // lbl_datum_chyba
            // 
            this.lbl_datum_chyba.AutoSize = true;
            this.lbl_datum_chyba.Location = new System.Drawing.Point(81, 203);
            this.lbl_datum_chyba.Name = "lbl_datum_chyba";
            this.lbl_datum_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_datum_chyba.TabIndex = 14;
            this.lbl_datum_chyba.Text = "Nevybráno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Datum platby";
            // 
            // lbl_email_chyba
            // 
            this.lbl_email_chyba.AutoSize = true;
            this.lbl_email_chyba.Location = new System.Drawing.Point(6, 90);
            this.lbl_email_chyba.Name = "lbl_email_chyba";
            this.lbl_email_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_email_chyba.TabIndex = 11;
            this.lbl_email_chyba.Text = "Nevybráno";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Email";
            // 
            // lbl_jmeno_chyba
            // 
            this.lbl_jmeno_chyba.AutoSize = true;
            this.lbl_jmeno_chyba.Location = new System.Drawing.Point(6, 47);
            this.lbl_jmeno_chyba.Name = "lbl_jmeno_chyba";
            this.lbl_jmeno_chyba.Size = new System.Drawing.Size(59, 13);
            this.lbl_jmeno_chyba.TabIndex = 9;
            this.lbl_jmeno_chyba.Text = "Nevybráno";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Jméno a příjmení";
            // 
            // listBox_chyba
            // 
            this.listBox_chyba.FormattingEnabled = true;
            this.listBox_chyba.Location = new System.Drawing.Point(5, 59);
            this.listBox_chyba.Name = "listBox_chyba";
            this.listBox_chyba.Size = new System.Drawing.Size(249, 316);
            this.listBox_chyba.Sorted = true;
            this.listBox_chyba.TabIndex = 19;
            this.listBox_chyba.SelectedIndexChanged += new System.EventHandler(this.listBox_chyba_SelectedIndexChanged);
            // 
            // lbl_chyba_tabulka
            // 
            this.lbl_chyba_tabulka.AutoSize = true;
            this.lbl_chyba_tabulka.Location = new System.Drawing.Point(5, 40);
            this.lbl_chyba_tabulka.Name = "lbl_chyba_tabulka";
            this.lbl_chyba_tabulka.Size = new System.Drawing.Size(74, 13);
            this.lbl_chyba_tabulka.TabIndex = 20;
            this.lbl_chyba_tabulka.Text = "Seznam osob:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(496, 53);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 13);
            this.label38.TabIndex = 25;
            this.label38.Text = "Seznam emailů:";
            // 
            // textBox_chybna_castka
            // 
            this.textBox_chybna_castka.Location = new System.Drawing.Point(499, 69);
            this.textBox_chybna_castka.Multiline = true;
            this.textBox_chybna_castka.Name = "textBox_chybna_castka";
            this.textBox_chybna_castka.Size = new System.Drawing.Size(262, 266);
            this.textBox_chybna_castka.TabIndex = 24;
            // 
            // button_export_chyba
            // 
            this.button_export_chyba.Location = new System.Drawing.Point(499, 352);
            this.button_export_chyba.Name = "button_export_chyba";
            this.button_export_chyba.Size = new System.Drawing.Size(75, 23);
            this.button_export_chyba.TabIndex = 23;
            this.button_export_chyba.Text = "Export osob";
            this.button_export_chyba.UseVisualStyleBackColor = true;
            this.button_export_chyba.Click += new System.EventHandler(this.button_export_chyba_Click);
            // 
            // button_zkopiruj_email_chyba
            // 
            this.button_zkopiruj_email_chyba.Location = new System.Drawing.Point(686, 352);
            this.button_zkopiruj_email_chyba.Name = "button_zkopiruj_email_chyba";
            this.button_zkopiruj_email_chyba.Size = new System.Drawing.Size(75, 23);
            this.button_zkopiruj_email_chyba.TabIndex = 22;
            this.button_zkopiruj_email_chyba.Text = "Zkopíruj emaily";
            this.button_zkopiruj_email_chyba.UseVisualStyleBackColor = true;
            this.button_zkopiruj_email_chyba.Click += new System.EventHandler(this.button_zkopiruj_email_chyba_Click);
            // 
            // button_porovnej
            // 
            this.button_porovnej.Location = new System.Drawing.Point(708, 423);
            this.button_porovnej.Name = "button_porovnej";
            this.button_porovnej.Size = new System.Drawing.Size(89, 23);
            this.button_porovnej.TabIndex = 5;
            this.button_porovnej.Text = "Kontrola plateb";
            this.button_porovnej.UseVisualStyleBackColor = true;
            this.button_porovnej.Click += new System.EventHandler(this.button_porovnej_Click);
            // 
            // numericUpDown_druzstva
            // 
            this.numericUpDown_druzstva.Location = new System.Drawing.Point(146, 336);
            this.numericUpDown_druzstva.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_druzstva.Name = "numericUpDown_druzstva";
            this.numericUpDown_druzstva.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_druzstva.TabIndex = 6;
            // 
            // numericUpDown_pripravka
            // 
            this.numericUpDown_pripravka.Location = new System.Drawing.Point(146, 363);
            this.numericUpDown_pripravka.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_pripravka.Name = "numericUpDown_pripravka";
            this.numericUpDown_pripravka.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_pripravka.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Výše příspěvků přípravka";
            // 
            // lbl_import_osob_cesta
            // 
            this.lbl_import_osob_cesta.AutoSize = true;
            this.lbl_import_osob_cesta.Location = new System.Drawing.Point(674, 338);
            this.lbl_import_osob_cesta.Name = "lbl_import_osob_cesta";
            this.lbl_import_osob_cesta.Size = new System.Drawing.Size(41, 13);
            this.lbl_import_osob_cesta.TabIndex = 9;
            this.lbl_import_osob_cesta.Text = "label10";
            // 
            // lbl_import_plateb_cesta
            // 
            this.lbl_import_plateb_cesta.AutoSize = true;
            this.lbl_import_plateb_cesta.Location = new System.Drawing.Point(689, 371);
            this.lbl_import_plateb_cesta.Name = "lbl_import_plateb_cesta";
            this.lbl_import_plateb_cesta.Size = new System.Drawing.Size(41, 13);
            this.lbl_import_plateb_cesta.TabIndex = 10;
            this.lbl_import_plateb_cesta.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_porovnej);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Správce plateb";
            this.groupBox_detail_vsichni.ResumeLayout(false);
            this.groupBox_detail_vsichni.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_pridat_vsichni.ResumeLayout(false);
            this.groupBox_pridat_vsichni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id_vsichni)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_detail_zaplaceno.ResumeLayout(false);
            this.groupBox_detail_zaplaceno.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_druzstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pripravka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_import_banka;
        private System.Windows.Forms.Button button_nacti_osoby;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox_vsichni;
        private System.Windows.Forms.Label lbl_vsichni_tabulka;
        private System.Windows.Forms.GroupBox groupBox_detail_vsichni;
        private System.Windows.Forms.Label lbl_platba_datum_vsichni;
        private System.Windows.Forms.Label lbl_platba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_email_vsichni;
        private System.Windows.Forms.Label lbl_email_nadpis;
        private System.Windows.Forms.Label lbl_jmeno_vsichni;
        private System.Windows.Forms.Label lbl_jmeno_nadpis;
        private System.Windows.Forms.Button button_pridat_databaze;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_export_zaplaceno;
        private System.Windows.Forms.Button button_kopiruj_email_zaplaceno;
        private System.Windows.Forms.ListBox listBox_zaplaceno;
        private System.Windows.Forms.Label lbl_zaplaceno_tabulka;
        private System.Windows.Forms.GroupBox groupBox_detail_zaplaceno;
        private System.Windows.Forms.Label lbl_datum_platba_zaplaceno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_email_zaplaceni;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_jmeno_zaplaceno;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_export_nezaplaceno;
        private System.Windows.Forms.Button button_zkopiruj_email_nezaplaceno;
        private System.Windows.Forms.ListBox listBox_nezaplaceno;
        private System.Windows.Forms.Label lbl_nezaplaceno_tabulka;
        private System.Windows.Forms.Button button_odebrat_databaze;
        private System.Windows.Forms.GroupBox groupBox_pridat_vsichni;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbl_email_zaplaceno;
        private System.Windows.Forms.TextBox textBox_zaplaceno;
        private System.Windows.Forms.Label lbl_email_nezaplaceno;
        private System.Windows.Forms.TextBox textBox_nezaplaceno;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listBox_chyba;
        private System.Windows.Forms.Label lbl_chyba_tabulka;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox_chybna_castka;
        private System.Windows.Forms.Button button_export_chyba;
        private System.Windows.Forms.Button button_zkopiruj_email_chyba;
        private System.Windows.Forms.Label lbl_prijmeni_vsichni;
        private System.Windows.Forms.TextBox textBox_jmeno_vsichni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email_vsichni;
        private System.Windows.Forms.TextBox textBox_prijmeni_vsichni;
        private System.Windows.Forms.Label lbl_prijmeni_zaplaceno;
        private System.Windows.Forms.Label lbl_skupina_vsichni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_id_vsichni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_skupina_zaplaceno;
        private System.Windows.Forms.Label Skupina;
        private System.Windows.Forms.Label lbl_id_zaplaceno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_export_vsichni;
        private System.Windows.Forms.NumericUpDown numericUpDown_id_vsichni;
        private System.Windows.Forms.RadioButton radioButton_nezaplaceno;
        private System.Windows.Forms.RadioButton radioButton_zaplaceno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_skupina_nezaplaceno;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_id_nezaplaceno;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_prijmeni_nezaplaceno;
        private System.Windows.Forms.Label lbl_email_nezaplaceni;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lbl_jmeno_nezaplaceno;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_castka_chyba;
        private System.Windows.Forms.Label lbl_skupina_chyba;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_id_chyba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_prijmeni_chyba;
        private System.Windows.Forms.Label lbl_datum_chyba;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_email_chyba;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_jmeno_chyba;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_porovnej;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_oddelovac;
        private System.Windows.Forms.NumericUpDown numericUpDown_druzstva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_pripravka;
        private System.Windows.Forms.Label lbl_import_plateb_cesta;
        private System.Windows.Forms.Label lbl_import_osob_cesta;
    }
}

