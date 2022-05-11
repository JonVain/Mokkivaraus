
namespace Mökkivaraus
{
    partial class Laskutus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laskutus));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.laskuTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.laskuTableAdapter();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.palveluhallintabtn = new System.Windows.Forms.Button();
            this.toimintahbtn = new System.Windows.Forms.Button();
            this.asiakashallintabtn = new System.Windows.Forms.Button();
            this.mokkienhallinta = new System.Windows.Forms.Button();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.asiakasTableAdapter();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHinta = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.lblVivia = new System.Windows.Forms.Label();
            this.lblVarausmokkiin = new System.Windows.Forms.Label();
            this.lblLaskuntyyppi = new System.Windows.Forms.Label();
            this.rbPaperi = new System.Windows.Forms.RadioButton();
            this.rbSahko = new System.Windows.Forms.RadioButton();
            this.lblMokki = new System.Windows.Forms.Label();
            this.lblAsiakas = new System.Windows.Forms.Label();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.cbMaksettu = new System.Windows.Forms.CheckBox();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.cbMokki = new System.Windows.Forms.ComboBox();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLisaaVaraus = new System.Windows.Forms.Button();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.mokkiTableAdapter();
            this.asiakasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter1 = new Mökkivaraus.VnDataSetTableAdapters.varausTableAdapter();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.palveluTableAdapter();
            this.clbPalvelut = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // vnDataSetBindingSource
            // 
            this.vnDataSetBindingSource.DataSource = this.vnDataSet;
            this.vnDataSetBindingSource.Position = 0;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // laskutusbtn
            // 
            this.laskutusbtn.BackColor = System.Drawing.Color.Transparent;
            this.laskutusbtn.FlatAppearance.BorderSize = 0;
            this.laskutusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laskutusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskutusbtn.Image = ((System.Drawing.Image)(resources.GetObject("laskutusbtn.Image")));
            this.laskutusbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laskutusbtn.Location = new System.Drawing.Point(12, 397);
            this.laskutusbtn.Name = "laskutusbtn";
            this.laskutusbtn.Size = new System.Drawing.Size(260, 60);
            this.laskutusbtn.TabIndex = 36;
            this.laskutusbtn.Text = "Laskutus";
            this.laskutusbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laskutusbtn.UseVisualStyleBackColor = false;
            // 
            // btnRaportit
            // 
            this.btnRaportit.BackColor = System.Drawing.Color.Transparent;
            this.btnRaportit.FlatAppearance.BorderSize = 0;
            this.btnRaportit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportit.Image = ((System.Drawing.Image)(resources.GetObject("btnRaportit.Image")));
            this.btnRaportit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportit.Location = new System.Drawing.Point(12, 331);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Size = new System.Drawing.Size(260, 60);
            this.btnRaportit.TabIndex = 35;
            this.btnRaportit.Text = "Raporttien Hallinta";
            this.btnRaportit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaportit.UseVisualStyleBackColor = false;
            this.btnRaportit.Click += new System.EventHandler(this.btnRaportit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 60);
            this.button5.TabIndex = 34;
            this.button5.Text = "Etusivu";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // palveluhallintabtn
            // 
            this.palveluhallintabtn.BackColor = System.Drawing.Color.Transparent;
            this.palveluhallintabtn.FlatAppearance.BorderSize = 0;
            this.palveluhallintabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.palveluhallintabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palveluhallintabtn.Image = ((System.Drawing.Image)(resources.GetObject("palveluhallintabtn.Image")));
            this.palveluhallintabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.palveluhallintabtn.Location = new System.Drawing.Point(12, 265);
            this.palveluhallintabtn.Name = "palveluhallintabtn";
            this.palveluhallintabtn.Size = new System.Drawing.Size(260, 60);
            this.palveluhallintabtn.TabIndex = 33;
            this.palveluhallintabtn.Text = "Palveluiden Hallinta";
            this.palveluhallintabtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.palveluhallintabtn.UseVisualStyleBackColor = false;
            this.palveluhallintabtn.Click += new System.EventHandler(this.palveluhallintabtn_Click);
            // 
            // toimintahbtn
            // 
            this.toimintahbtn.BackColor = System.Drawing.Color.Transparent;
            this.toimintahbtn.FlatAppearance.BorderSize = 0;
            this.toimintahbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toimintahbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toimintahbtn.Image = ((System.Drawing.Image)(resources.GetObject("toimintahbtn.Image")));
            this.toimintahbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toimintahbtn.Location = new System.Drawing.Point(12, 199);
            this.toimintahbtn.Name = "toimintahbtn";
            this.toimintahbtn.Size = new System.Drawing.Size(260, 60);
            this.toimintahbtn.TabIndex = 32;
            this.toimintahbtn.Text = "Toiminta-aluehallinta";
            this.toimintahbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toimintahbtn.UseVisualStyleBackColor = false;
            this.toimintahbtn.Click += new System.EventHandler(this.toimintahbtn_Click);
            // 
            // asiakashallintabtn
            // 
            this.asiakashallintabtn.BackColor = System.Drawing.Color.Transparent;
            this.asiakashallintabtn.FlatAppearance.BorderSize = 0;
            this.asiakashallintabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asiakashallintabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakashallintabtn.Image = ((System.Drawing.Image)(resources.GetObject("asiakashallintabtn.Image")));
            this.asiakashallintabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.asiakashallintabtn.Location = new System.Drawing.Point(12, 133);
            this.asiakashallintabtn.Name = "asiakashallintabtn";
            this.asiakashallintabtn.Size = new System.Drawing.Size(260, 60);
            this.asiakashallintabtn.TabIndex = 31;
            this.asiakashallintabtn.Text = "Asiakashallinta";
            this.asiakashallintabtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.asiakashallintabtn.UseVisualStyleBackColor = false;
            this.asiakashallintabtn.Click += new System.EventHandler(this.asiakashallintabtn_Click);
            // 
            // mokkienhallinta
            // 
            this.mokkienhallinta.BackColor = System.Drawing.Color.Transparent;
            this.mokkienhallinta.FlatAppearance.BorderSize = 0;
            this.mokkienhallinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mokkienhallinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mokkienhallinta.Image = ((System.Drawing.Image)(resources.GetObject("mokkienhallinta.Image")));
            this.mokkienhallinta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mokkienhallinta.Location = new System.Drawing.Point(12, 67);
            this.mokkienhallinta.Name = "mokkienhallinta";
            this.mokkienhallinta.Size = new System.Drawing.Size(260, 60);
            this.mokkienhallinta.TabIndex = 30;
            this.mokkienhallinta.Text = "Mökkien Hallinta";
            this.mokkienhallinta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mokkienhallinta.UseVisualStyleBackColor = false;
            this.mokkienhallinta.Click += new System.EventHandler(this.mokkienhallinta_Click);
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraus.Location = new System.Drawing.Point(274, 176);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(102, 20);
            this.lblVaraus.TabIndex = 37;
            this.lblVaraus.Text = "Lisää Varaus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clbPalvelut);
            this.panel1.Controls.Add(this.lblHinta);
            this.panel1.Controls.Add(this.tbHinta);
            this.panel1.Controls.Add(this.lblVivia);
            this.panel1.Controls.Add(this.lblVarausmokkiin);
            this.panel1.Controls.Add(this.lblLaskuntyyppi);
            this.panel1.Controls.Add(this.rbPaperi);
            this.panel1.Controls.Add(this.rbSahko);
            this.panel1.Controls.Add(this.lblMokki);
            this.panel1.Controls.Add(this.lblAsiakas);
            this.panel1.Controls.Add(this.cbAsiakas);
            this.panel1.Controls.Add(this.cbMaksettu);
            this.panel1.Controls.Add(this.dtpLoppu);
            this.panel1.Controls.Add(this.dtpAlku);
            this.panel1.Controls.Add(this.cbMokki);
            this.panel1.Controls.Add(this.btnLisaaVaraus);
            this.panel1.Location = new System.Drawing.Point(278, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 256);
            this.panel1.TabIndex = 38;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(25, 80);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(66, 13);
            this.lblHinta.TabIndex = 40;
            this.lblHinta.Text = "Sovittu hinta";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(105, 77);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(150, 20);
            this.tbHinta.TabIndex = 39;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            // 
            // lblVivia
            // 
            this.lblVivia.AutoSize = true;
            this.lblVivia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVivia.Location = new System.Drawing.Point(122, 216);
            this.lblVivia.Name = "lblVivia";
            this.lblVivia.Size = new System.Drawing.Size(14, 20);
            this.lblVivia.TabIndex = 17;
            this.lblVivia.Text = "-";
            this.lblVivia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVarausmokkiin
            // 
            this.lblVarausmokkiin.AutoSize = true;
            this.lblVarausmokkiin.Location = new System.Drawing.Point(17, 198);
            this.lblVarausmokkiin.Name = "lblVarausmokkiin";
            this.lblVarausmokkiin.Size = new System.Drawing.Size(99, 13);
            this.lblVarausmokkiin.TabIndex = 16;
            this.lblVarausmokkiin.Text = "Varattu aika mökille";
            // 
            // lblLaskuntyyppi
            // 
            this.lblLaskuntyyppi.AutoSize = true;
            this.lblLaskuntyyppi.Location = new System.Drawing.Point(274, 22);
            this.lblLaskuntyyppi.Name = "lblLaskuntyyppi";
            this.lblLaskuntyyppi.Size = new System.Drawing.Size(72, 13);
            this.lblLaskuntyyppi.TabIndex = 13;
            this.lblLaskuntyyppi.Text = "Laskun tyyppi";
            // 
            // rbPaperi
            // 
            this.rbPaperi.AutoSize = true;
            this.rbPaperi.Location = new System.Drawing.Point(277, 58);
            this.rbPaperi.Name = "rbPaperi";
            this.rbPaperi.Size = new System.Drawing.Size(55, 17);
            this.rbPaperi.TabIndex = 12;
            this.rbPaperi.TabStop = true;
            this.rbPaperi.Text = "Paperi";
            this.rbPaperi.UseVisualStyleBackColor = true;
            // 
            // rbSahko
            // 
            this.rbSahko.AutoSize = true;
            this.rbSahko.Checked = true;
            this.rbSahko.Location = new System.Drawing.Point(277, 38);
            this.rbSahko.Name = "rbSahko";
            this.rbSahko.Size = new System.Drawing.Size(78, 17);
            this.rbSahko.TabIndex = 11;
            this.rbSahko.TabStop = true;
            this.rbSahko.Text = "Sähköposti";
            this.rbSahko.UseVisualStyleBackColor = true;
            // 
            // lblMokki
            // 
            this.lblMokki.AutoSize = true;
            this.lblMokki.Location = new System.Drawing.Point(25, 53);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(36, 13);
            this.lblMokki.TabIndex = 8;
            this.lblMokki.Text = "Mökki";
            // 
            // lblAsiakas
            // 
            this.lblAsiakas.AutoSize = true;
            this.lblAsiakas.Location = new System.Drawing.Point(25, 26);
            this.lblAsiakas.Name = "lblAsiakas";
            this.lblAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lblAsiakas.TabIndex = 7;
            this.lblAsiakas.Text = "Asiakas";
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.DataSource = this.asiakasBindingSource;
            this.cbAsiakas.DisplayMember = "email";
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(105, 23);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(150, 21);
            this.cbAsiakas.TabIndex = 6;
            this.cbAsiakas.ValueMember = "asiakas_id";
            // 
            // cbMaksettu
            // 
            this.cbMaksettu.AutoSize = true;
            this.cbMaksettu.Location = new System.Drawing.Point(277, 81);
            this.cbMaksettu.Name = "cbMaksettu";
            this.cbMaksettu.Size = new System.Drawing.Size(76, 17);
            this.cbMaksettu.TabIndex = 5;
            this.cbMaksettu.Text = "Maksettu?";
            this.cbMaksettu.UseVisualStyleBackColor = true;
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.CustomFormat = "yyyy-MM-dd";
            this.dtpLoppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppu.Location = new System.Drawing.Point(142, 217);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(96, 20);
            this.dtpLoppu.TabIndex = 4;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // dtpAlku
            // 
            this.dtpAlku.CustomFormat = "yyyy-MM-dd";
            this.dtpAlku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlku.Location = new System.Drawing.Point(20, 217);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(96, 20);
            this.dtpAlku.TabIndex = 3;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // cbMokki
            // 
            this.cbMokki.DataSource = this.mokkiBindingSource;
            this.cbMokki.DisplayMember = "mokkinimi";
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(105, 50);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(150, 21);
            this.cbMokki.TabIndex = 2;
            this.cbMokki.ValueMember = "mokki_id";
            this.cbMokki.SelectedIndexChanged += new System.EventHandler(this.cbMokki_SelectedIndexChanged);
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // btnLisaaVaraus
            // 
            this.btnLisaaVaraus.Location = new System.Drawing.Point(254, 218);
            this.btnLisaaVaraus.Name = "btnLisaaVaraus";
            this.btnLisaaVaraus.Size = new System.Drawing.Size(99, 23);
            this.btnLisaaVaraus.TabIndex = 0;
            this.btnLisaaVaraus.Text = "Lisää varaus";
            this.btnLisaaVaraus.UseVisualStyleBackColor = true;
            this.btnLisaaVaraus.Click += new System.EventHandler(this.btnLisaaVaraus_Click);
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "asiakas";
            this.asiakasBindingSource1.DataSource = this.vnDataSetBindingSource;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasBindingSource2
            // 
            this.asiakasBindingSource2.DataMember = "asiakas";
            this.asiakasBindingSource2.DataSource = this.vnDataSetBindingSource;
            // 
            // varausTableAdapter1
            // 
            this.varausTableAdapter1.ClearBeforeFill = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.vnDataSet;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // clbPalvelut
            // 
            this.clbPalvelut.FormattingEnabled = true;
            this.clbPalvelut.Items.AddRange(new object[] {
            "test",
            "test2",
            "test3",
            "test4"});
            this.clbPalvelut.Location = new System.Drawing.Point(28, 103);
            this.clbPalvelut.Name = "clbPalvelut";
            this.clbPalvelut.Size = new System.Drawing.Size(227, 94);
            this.clbPalvelut.TabIndex = 41;
            this.clbPalvelut.SelectedIndexChanged += new System.EventHandler(this.clbPalvelut_SelectedIndexChanged);
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 467);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.laskutusbtn);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.palveluhallintabtn);
            this.Controls.Add(this.toimintahbtn);
            this.Controls.Add(this.asiakashallintabtn);
            this.Controls.Add(this.mokkienhallinta);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Laskutus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Laskutus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Laskutus_FormClosed);
            this.Load += new System.EventHandler(this.Laskutus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private VnDataSetTableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button palveluhallintabtn;
        private System.Windows.Forms.Button toimintahbtn;
        private System.Windows.Forms.Button asiakashallintabtn;
        private System.Windows.Forms.Button mokkienhallinta;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VnDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMokki;
        private System.Windows.Forms.Button btnLisaaVaraus;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.Label lblLaskuntyyppi;
        private System.Windows.Forms.RadioButton rbPaperi;
        private System.Windows.Forms.RadioButton rbSahko;
        private System.Windows.Forms.Label lblMokki;
        private System.Windows.Forms.Label lblAsiakas;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.BindingSource asiakasBindingSource2;
        private System.Windows.Forms.CheckBox cbMaksettu;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label lblVivia;
        private System.Windows.Forms.Label lblVarausmokkiin;
        private VnDataSetTableAdapters.varausTableAdapter varausTableAdapter1;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VnDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.CheckedListBox clbPalvelut;
    }
}