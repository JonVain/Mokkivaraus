
namespace Mökkivaraus
{
    partial class Raportointi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportointi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.btnEtusivu = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnToimintaAlue = new System.Windows.Forms.Button();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.btnMokki = new System.Windows.Forms.Button();
            this.dtp_Varaus_Alku = new System.Windows.Forms.DateTimePicker();
            this.dgvVaraus = new System.Windows.Forms.DataGridView();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.varausTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.varausTableAdapter();
            this.lbToimintaA = new System.Windows.Forms.Label();
            this.cb_toimintaAlueLista = new System.Windows.Forms.ComboBox();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPalvelu = new System.Windows.Forms.DataGridView();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.palveluTableAdapter();
            this.cbPalveluLista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Palvelu_Alku = new System.Windows.Forms.DateTimePicker();
            this.dtp_Palvelu_Loppu = new System.Windows.Forms.DateTimePicker();
            this.dtp_Varaus_Loppu = new System.Windows.Forms.DateTimePicker();
            this.lbAlkupvm1 = new System.Windows.Forms.Label();
            this.Alkupvm2 = new System.Windows.Forms.Label();
            this.Loppupvm1 = new System.Windows.Forms.Label();
            this.tbLoppupvm2 = new System.Windows.Forms.Label();
            this.btValitseKaikkiTAH = new System.Windows.Forms.Button();
            this.btnValitseKaikkiPalvelut = new System.Windows.Forms.Button();
            this.btValitseTAHaika = new System.Windows.Forms.Button();
            this.btvValitsePalveluAika = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.laskutusbtn);
            this.panel2.Controls.Add(this.btnRaportit);
            this.panel2.Controls.Add(this.btnEtusivu);
            this.panel2.Controls.Add(this.btnPalvelut);
            this.panel2.Controls.Add(this.btnToimintaAlue);
            this.panel2.Controls.Add(this.btnAsiakas);
            this.panel2.Controls.Add(this.btnMokki);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 594);
            this.panel2.TabIndex = 22;
            // 
            // laskutusbtn
            // 
            this.laskutusbtn.BackColor = System.Drawing.Color.Transparent;
            this.laskutusbtn.FlatAppearance.BorderSize = 0;
            this.laskutusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laskutusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskutusbtn.Image = ((System.Drawing.Image)(resources.GetObject("laskutusbtn.Image")));
            this.laskutusbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laskutusbtn.Location = new System.Drawing.Point(3, 400);
            this.laskutusbtn.Name = "laskutusbtn";
            this.laskutusbtn.Size = new System.Drawing.Size(260, 60);
            this.laskutusbtn.TabIndex = 41;
            this.laskutusbtn.Text = "Laskutus";
            this.laskutusbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laskutusbtn.UseVisualStyleBackColor = false;
            this.laskutusbtn.Click += new System.EventHandler(this.laskutusbtn_Click);
            // 
            // btnRaportit
            // 
            this.btnRaportit.BackColor = System.Drawing.Color.Transparent;
            this.btnRaportit.FlatAppearance.BorderSize = 0;
            this.btnRaportit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportit.Image = ((System.Drawing.Image)(resources.GetObject("btnRaportit.Image")));
            this.btnRaportit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportit.Location = new System.Drawing.Point(3, 334);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Size = new System.Drawing.Size(260, 60);
            this.btnRaportit.TabIndex = 28;
            this.btnRaportit.Text = "Raporttien Hallinta";
            this.btnRaportit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaportit.UseVisualStyleBackColor = false;
            // 
            // btnEtusivu
            // 
            this.btnEtusivu.BackColor = System.Drawing.Color.Transparent;
            this.btnEtusivu.FlatAppearance.BorderSize = 0;
            this.btnEtusivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtusivu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtusivu.Image = ((System.Drawing.Image)(resources.GetObject("btnEtusivu.Image")));
            this.btnEtusivu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtusivu.Location = new System.Drawing.Point(3, 4);
            this.btnEtusivu.Name = "btnEtusivu";
            this.btnEtusivu.Size = new System.Drawing.Size(260, 60);
            this.btnEtusivu.TabIndex = 4;
            this.btnEtusivu.Text = "Etusivu";
            this.btnEtusivu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEtusivu.UseVisualStyleBackColor = false;
            this.btnEtusivu.Click += new System.EventHandler(this.btnEtusivu_Click);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.BackColor = System.Drawing.Color.Transparent;
            this.btnPalvelut.FlatAppearance.BorderSize = 0;
            this.btnPalvelut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalvelut.Image = ((System.Drawing.Image)(resources.GetObject("btnPalvelut.Image")));
            this.btnPalvelut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPalvelut.Location = new System.Drawing.Point(3, 268);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(260, 60);
            this.btnPalvelut.TabIndex = 3;
            this.btnPalvelut.Text = "Palveluiden Hallinta";
            this.btnPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPalvelut.UseVisualStyleBackColor = false;
            this.btnPalvelut.Click += new System.EventHandler(this.tsmPalvelut_Click);
            // 
            // btnToimintaAlue
            // 
            this.btnToimintaAlue.BackColor = System.Drawing.Color.Transparent;
            this.btnToimintaAlue.FlatAppearance.BorderSize = 0;
            this.btnToimintaAlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToimintaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToimintaAlue.Image = ((System.Drawing.Image)(resources.GetObject("btnToimintaAlue.Image")));
            this.btnToimintaAlue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToimintaAlue.Location = new System.Drawing.Point(3, 202);
            this.btnToimintaAlue.Name = "btnToimintaAlue";
            this.btnToimintaAlue.Size = new System.Drawing.Size(260, 60);
            this.btnToimintaAlue.TabIndex = 2;
            this.btnToimintaAlue.Text = "Toiminta-aluehallinta";
            this.btnToimintaAlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToimintaAlue.UseVisualStyleBackColor = false;
            this.btnToimintaAlue.Click += new System.EventHandler(this.tsmToimintaAlueet_Click);
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.BackColor = System.Drawing.Color.Transparent;
            this.btnAsiakas.FlatAppearance.BorderSize = 0;
            this.btnAsiakas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakas.Image = ((System.Drawing.Image)(resources.GetObject("btnAsiakas.Image")));
            this.btnAsiakas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsiakas.Location = new System.Drawing.Point(3, 136);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(260, 60);
            this.btnAsiakas.TabIndex = 1;
            this.btnAsiakas.Text = "Asiakashallinta";
            this.btnAsiakas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiakas.UseVisualStyleBackColor = false;
            this.btnAsiakas.Click += new System.EventHandler(this.tsmAsiakasHallinta_Click);
            // 
            // btnMokki
            // 
            this.btnMokki.BackColor = System.Drawing.Color.Transparent;
            this.btnMokki.FlatAppearance.BorderSize = 0;
            this.btnMokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokki.Image = ((System.Drawing.Image)(resources.GetObject("btnMokki.Image")));
            this.btnMokki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMokki.Location = new System.Drawing.Point(3, 70);
            this.btnMokki.Name = "btnMokki";
            this.btnMokki.Size = new System.Drawing.Size(260, 60);
            this.btnMokki.TabIndex = 0;
            this.btnMokki.Text = "Mökkien Hallinta";
            this.btnMokki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMokki.UseVisualStyleBackColor = false;
            this.btnMokki.Click += new System.EventHandler(this.tsmMokki_Click);
            // 
            // dtp_Varaus_Alku
            // 
            this.dtp_Varaus_Alku.CustomFormat = "yyyy-MM-dd";
            this.dtp_Varaus_Alku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Varaus_Alku.Location = new System.Drawing.Point(592, 88);
            this.dtp_Varaus_Alku.Name = "dtp_Varaus_Alku";
            this.dtp_Varaus_Alku.Size = new System.Drawing.Size(127, 20);
            this.dtp_Varaus_Alku.TabIndex = 23;
            this.dtp_Varaus_Alku.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(302, 122);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.Size = new System.Drawing.Size(800, 165);
            this.dgvVaraus.TabIndex = 24;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.vnDataSet;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // lbToimintaA
            // 
            this.lbToimintaA.AutoSize = true;
            this.lbToimintaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToimintaA.Location = new System.Drawing.Point(298, 44);
            this.lbToimintaA.Name = "lbToimintaA";
            this.lbToimintaA.Size = new System.Drawing.Size(156, 20);
            this.lbToimintaA.TabIndex = 25;
            this.lbToimintaA.Text = "Valitse toiminta-alue:";
            // 
            // cb_toimintaAlueLista
            // 
            this.cb_toimintaAlueLista.DataSource = this.alueBindingSource;
            this.cb_toimintaAlueLista.DisplayMember = "nimi";
            this.cb_toimintaAlueLista.FormattingEnabled = true;
            this.cb_toimintaAlueLista.Location = new System.Drawing.Point(302, 88);
            this.cb_toimintaAlueLista.Name = "cb_toimintaAlueLista";
            this.cb_toimintaAlueLista.Size = new System.Drawing.Size(164, 21);
            this.cb_toimintaAlueLista.TabIndex = 26;
            this.cb_toimintaAlueLista.ValueMember = "alue_id";
            this.cb_toimintaAlueLista.SelectedIndexChanged += new System.EventHandler(this.Alueen_Valinta);
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.vnDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valitse aikajakso:";
            // 
            // dgvPalvelu
            // 
            this.dgvPalvelu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelu.Location = new System.Drawing.Point(302, 393);
            this.dgvPalvelu.Name = "dgvPalvelu";
            this.dgvPalvelu.Size = new System.Drawing.Size(800, 181);
            this.dgvPalvelu.TabIndex = 28;
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
            // cbPalveluLista
            // 
            this.cbPalveluLista.DataSource = this.palveluBindingSource;
            this.cbPalveluLista.DisplayMember = "nimi";
            this.cbPalveluLista.FormattingEnabled = true;
            this.cbPalveluLista.Location = new System.Drawing.Point(302, 356);
            this.cbPalveluLista.Name = "cbPalveluLista";
            this.cbPalveluLista.Size = new System.Drawing.Size(164, 21);
            this.cbPalveluLista.TabIndex = 30;
            this.cbPalveluLista.ValueMember = "palvelu_id";
            this.cbPalveluLista.SelectedIndexChanged += new System.EventHandler(this.PalvelunValinta);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valitse palvelu:";
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valitse aikajakso:";
            // 
            // dtp_Palvelu_Alku
            // 
            this.dtp_Palvelu_Alku.CustomFormat = "yyyy-MM-dd";
            this.dtp_Palvelu_Alku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Palvelu_Alku.Location = new System.Drawing.Point(592, 357);
            this.dtp_Palvelu_Alku.Name = "dtp_Palvelu_Alku";
            this.dtp_Palvelu_Alku.Size = new System.Drawing.Size(127, 20);
            this.dtp_Palvelu_Alku.TabIndex = 31;
            this.dtp_Palvelu_Alku.ValueChanged += new System.EventHandler(this.dtp_Palvelu_Alku_ValueChanged);
            // 
            // dtp_Palvelu_Loppu
            // 
            this.dtp_Palvelu_Loppu.Checked = false;
            this.dtp_Palvelu_Loppu.CustomFormat = "yyyy-MM-dd";
            this.dtp_Palvelu_Loppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Palvelu_Loppu.Location = new System.Drawing.Point(767, 357);
            this.dtp_Palvelu_Loppu.Name = "dtp_Palvelu_Loppu";
            this.dtp_Palvelu_Loppu.Size = new System.Drawing.Size(127, 20);
            this.dtp_Palvelu_Loppu.TabIndex = 33;
            this.dtp_Palvelu_Loppu.ValueChanged += new System.EventHandler(this.dtp_Palvelu_Loppu_ValueChanged);
            // 
            // dtp_Varaus_Loppu
            // 
            this.dtp_Varaus_Loppu.CustomFormat = "yyyy-MM-dd";
            this.dtp_Varaus_Loppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Varaus_Loppu.Location = new System.Drawing.Point(767, 89);
            this.dtp_Varaus_Loppu.Name = "dtp_Varaus_Loppu";
            this.dtp_Varaus_Loppu.Size = new System.Drawing.Size(127, 20);
            this.dtp_Varaus_Loppu.TabIndex = 34;
            this.dtp_Varaus_Loppu.ValueChanged += new System.EventHandler(this.dtp_Varaus_Loppu_ValueChanged);
            // 
            // lbAlkupvm1
            // 
            this.lbAlkupvm1.AutoSize = true;
            this.lbAlkupvm1.Location = new System.Drawing.Point(589, 72);
            this.lbAlkupvm1.Name = "lbAlkupvm1";
            this.lbAlkupvm1.Size = new System.Drawing.Size(54, 13);
            this.lbAlkupvm1.TabIndex = 35;
            this.lbAlkupvm1.Text = "Alku pvm.";
            // 
            // Alkupvm2
            // 
            this.Alkupvm2.AutoSize = true;
            this.Alkupvm2.Location = new System.Drawing.Point(589, 341);
            this.Alkupvm2.Name = "Alkupvm2";
            this.Alkupvm2.Size = new System.Drawing.Size(54, 13);
            this.Alkupvm2.TabIndex = 36;
            this.Alkupvm2.Text = "Alku pvm.";
            // 
            // Loppupvm1
            // 
            this.Loppupvm1.AutoSize = true;
            this.Loppupvm1.Location = new System.Drawing.Point(764, 72);
            this.Loppupvm1.Name = "Loppupvm1";
            this.Loppupvm1.Size = new System.Drawing.Size(63, 13);
            this.Loppupvm1.TabIndex = 37;
            this.Loppupvm1.Text = "Loppu pvm.";
            // 
            // tbLoppupvm2
            // 
            this.tbLoppupvm2.AutoSize = true;
            this.tbLoppupvm2.Location = new System.Drawing.Point(764, 341);
            this.tbLoppupvm2.Name = "tbLoppupvm2";
            this.tbLoppupvm2.Size = new System.Drawing.Size(63, 13);
            this.tbLoppupvm2.TabIndex = 38;
            this.tbLoppupvm2.Text = "Loppu pvm.";
            // 
            // btValitseKaikkiTAH
            // 
            this.btValitseKaikkiTAH.Location = new System.Drawing.Point(484, 88);
            this.btValitseKaikkiTAH.Name = "btValitseKaikkiTAH";
            this.btValitseKaikkiTAH.Size = new System.Drawing.Size(77, 20);
            this.btValitseKaikkiTAH.TabIndex = 39;
            this.btValitseKaikkiTAH.Text = "Valitse kaikki";
            this.btValitseKaikkiTAH.UseVisualStyleBackColor = true;
            this.btValitseKaikkiTAH.Click += new System.EventHandler(this.btValitseKaikkiTAH_Click);
            // 
            // btnValitseKaikkiPalvelut
            // 
            this.btnValitseKaikkiPalvelut.Location = new System.Drawing.Point(484, 357);
            this.btnValitseKaikkiPalvelut.Name = "btnValitseKaikkiPalvelut";
            this.btnValitseKaikkiPalvelut.Size = new System.Drawing.Size(77, 20);
            this.btnValitseKaikkiPalvelut.TabIndex = 40;
            this.btnValitseKaikkiPalvelut.Text = "Valitse kaikki";
            this.btnValitseKaikkiPalvelut.UseVisualStyleBackColor = true;
            this.btnValitseKaikkiPalvelut.Click += new System.EventHandler(this.btnValitseKaikkiPalvelut_Click);
            // 
            // btValitseTAHaika
            // 
            this.btValitseTAHaika.Location = new System.Drawing.Point(926, 87);
            this.btValitseTAHaika.Name = "btValitseTAHaika";
            this.btValitseTAHaika.Size = new System.Drawing.Size(104, 23);
            this.btValitseTAHaika.TabIndex = 41;
            this.btValitseTAHaika.Text = "Valitse aika";
            this.btValitseTAHaika.UseVisualStyleBackColor = true;
            this.btValitseTAHaika.Click += new System.EventHandler(this.btValitseTAHaika_Click);
            // 
            // btvValitsePalveluAika
            // 
            this.btvValitsePalveluAika.Location = new System.Drawing.Point(926, 356);
            this.btvValitsePalveluAika.Name = "btvValitsePalveluAika";
            this.btvValitsePalveluAika.Size = new System.Drawing.Size(104, 23);
            this.btvValitsePalveluAika.TabIndex = 42;
            this.btvValitsePalveluAika.Text = "Valitse aika";
            this.btvValitsePalveluAika.UseVisualStyleBackColor = true;
            this.btvValitsePalveluAika.Click += new System.EventHandler(this.btvValitsePalveluAika_Click);
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 594);
            this.Controls.Add(this.btvValitsePalveluAika);
            this.Controls.Add(this.btValitseTAHaika);
            this.Controls.Add(this.btnValitseKaikkiPalvelut);
            this.Controls.Add(this.btValitseKaikkiTAH);
            this.Controls.Add(this.tbLoppupvm2);
            this.Controls.Add(this.Loppupvm1);
            this.Controls.Add(this.Alkupvm2);
            this.Controls.Add(this.lbAlkupvm1);
            this.Controls.Add(this.dtp_Varaus_Loppu);
            this.Controls.Add(this.dtp_Palvelu_Loppu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Palvelu_Alku);
            this.Controls.Add(this.cbPalveluLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPalvelu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_toimintaAlueLista);
            this.Controls.Add(this.lbToimintaA);
            this.Controls.Add(this.dgvVaraus);
            this.Controls.Add(this.dtp_Varaus_Alku);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Raportointi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Raportointi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raportointi_FormClosed);
            this.Load += new System.EventHandler(this.Raportointi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button btnEtusivu;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Button btnToimintaAlue;
        private System.Windows.Forms.Button btnAsiakas;
        private System.Windows.Forms.Button btnMokki;
        private System.Windows.Forms.DateTimePicker dtp_Varaus_Alku;
        private System.Windows.Forms.DataGridView dgvVaraus;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private VnDataSetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.Label lbToimintaA;
        private System.Windows.Forms.ComboBox cb_toimintaAlueLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPalvelu;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VnDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.ComboBox cbPalveluLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Palvelu_Alku;
        private System.Windows.Forms.DateTimePicker dtp_Palvelu_Loppu;
        private System.Windows.Forms.DateTimePicker dtp_Varaus_Loppu;
        private System.Windows.Forms.Label lbAlkupvm1;
        private System.Windows.Forms.Label Alkupvm2;
        private System.Windows.Forms.Label Loppupvm1;
        private System.Windows.Forms.Label tbLoppupvm2;
        private System.Windows.Forms.Button btValitseKaikkiTAH;
        private System.Windows.Forms.Button btnValitseKaikkiPalvelut;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.Button btValitseTAHaika;
        private System.Windows.Forms.Button btvValitsePalveluAika;
    }
}