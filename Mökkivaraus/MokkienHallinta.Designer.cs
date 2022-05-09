
namespace Mökkivaraus
{
    partial class MokkienHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MokkienHallinta));
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.mokkiTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.mokkiTableAdapter();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.tbMokki = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHlomaara = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.Alue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.tbPäivitä = new System.Windows.Forms.Button();
            this.tbPoista = new System.Windows.Forms.Button();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.mökkienID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAlue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMokki
            // 
            this.dgvMokki.AutoGenerateColumns = false;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokki.DataSource = this.mokkiBindingSource;
            this.dgvMokki.Location = new System.Drawing.Point(22, 542);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.Size = new System.Drawing.Size(944, 220);
            this.dgvMokki.TabIndex = 1;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "alue_id";
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.vnDataSet;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(289, 479);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(172, 48);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbPostinro
            // 
            this.tbPostinro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "postinro", true));
            this.tbPostinro.Location = new System.Drawing.Point(152, 351);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(100, 20);
            this.tbPostinro.TabIndex = 4;
            // 
            // tbMokki
            // 
            this.tbMokki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "mokkinimi", true));
            this.tbMokki.Location = new System.Drawing.Point(152, 377);
            this.tbMokki.Name = "tbMokki";
            this.tbMokki.Size = new System.Drawing.Size(100, 20);
            this.tbMokki.TabIndex = 5;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "katuosoite", true));
            this.tbKatuosoite.Location = new System.Drawing.Point(152, 403);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(100, 20);
            this.tbKatuosoite.TabIndex = 6;
            // 
            // tbHinta
            // 
            this.tbHinta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "hinta", true));
            this.tbHinta.Location = new System.Drawing.Point(152, 429);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 7;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "kuvaus", true));
            this.tbKuvaus.Location = new System.Drawing.Point(152, 455);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbHlomaara
            // 
            this.tbHlomaara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "henkilomaara", true));
            this.tbHlomaara.Location = new System.Drawing.Point(152, 481);
            this.tbHlomaara.Name = "tbHlomaara";
            this.tbHlomaara.Size = new System.Drawing.Size(100, 20);
            this.tbHlomaara.TabIndex = 9;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "varustelu", true));
            this.tbVarustelu.Location = new System.Drawing.Point(152, 507);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(100, 20);
            this.tbVarustelu.TabIndex = 10;
            // 
            // Alue
            // 
            this.Alue.AutoSize = true;
            this.Alue.Location = new System.Drawing.Point(55, 325);
            this.Alue.Name = "Alue";
            this.Alue.Size = new System.Drawing.Size(28, 13);
            this.Alue.TabIndex = 12;
            this.Alue.Text = "Alue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Postinumero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mökkinimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Katuosoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kuvaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Henkilömäärä";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Varustelu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.laskutusbtn);
            this.panel2.Controls.Add(this.btnRaportit);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 781);
            this.panel2.TabIndex = 20;
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
            this.laskutusbtn.TabIndex = 30;
            this.laskutusbtn.Text = "Laskutus";
            this.laskutusbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laskutusbtn.UseVisualStyleBackColor = false;
            this.laskutusbtn.Click += new System.EventHandler(this.button6_Click);
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
            this.button5.Location = new System.Drawing.Point(3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Etusivu";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.tsmEtusivu_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Palveluiden Hallinta";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.tsmPalvelut_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Toiminta-aluehallinta";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.tsmToiminta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Asiakashallinta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.tsmAsiakas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mökkien Hallinta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.vnDataSet;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // tbPäivitä
            // 
            this.tbPäivitä.Location = new System.Drawing.Point(538, 479);
            this.tbPäivitä.Name = "tbPäivitä";
            this.tbPäivitä.Size = new System.Drawing.Size(172, 48);
            this.tbPäivitä.TabIndex = 22;
            this.tbPäivitä.Text = "Päivitä";
            this.tbPäivitä.UseVisualStyleBackColor = true;
            this.tbPäivitä.Click += new System.EventHandler(this.tbPäivitä_Click);
            // 
            // tbPoista
            // 
            this.tbPoista.Location = new System.Drawing.Point(794, 479);
            this.tbPoista.Name = "tbPoista";
            this.tbPoista.Size = new System.Drawing.Size(172, 48);
            this.tbPoista.TabIndex = 23;
            this.tbPoista.Text = "Poista";
            this.tbPoista.UseVisualStyleBackColor = true;
            this.tbPoista.Click += new System.EventHandler(this.tbPoista_Click);
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mokkiBindingSource, "mokki_id", true));
            this.tbMokkiID.Location = new System.Drawing.Point(794, 415);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.ReadOnly = true;
            this.tbMokkiID.Size = new System.Drawing.Size(172, 20);
            this.tbMokkiID.TabIndex = 24;
            // 
            // mökkienID
            // 
            this.mökkienID.AutoSize = true;
            this.mökkienID.Location = new System.Drawing.Point(874, 393);
            this.mökkienID.Name = "mökkienID";
            this.mökkienID.Size = new System.Drawing.Size(18, 13);
            this.mökkienID.TabIndex = 25;
            this.mökkienID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Mökkivaraus.Properties.Resources.cottage;
            this.panel1.Controls.Add(this.tbAlue);
            this.panel1.Controls.Add(this.mökkienID);
            this.panel1.Controls.Add(this.tbMokkiID);
            this.panel1.Controls.Add(this.tbPoista);
            this.panel1.Controls.Add(this.tbPäivitä);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Alue);
            this.panel1.Controls.Add(this.tbVarustelu);
            this.panel1.Controls.Add(this.tbHlomaara);
            this.panel1.Controls.Add(this.tbKuvaus);
            this.panel1.Controls.Add(this.tbHinta);
            this.panel1.Controls.Add(this.tbKatuosoite);
            this.panel1.Controls.Add(this.tbMokki);
            this.panel1.Controls.Add(this.tbPostinro);
            this.panel1.Controls.Add(this.btnLisaa);
            this.panel1.Controls.Add(this.dgvMokki);
            this.panel1.Location = new System.Drawing.Point(273, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 773);
            this.panel1.TabIndex = 26;
            // 
            // tbAlue
            // 
            this.tbAlue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mokkiBindingSource, "alue_id", true));
            this.tbAlue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mokkiBindingSource, "alue_id", true));
            this.tbAlue.DataSource = this.alueBindingSource;
            this.tbAlue.DisplayMember = "nimi";
            this.tbAlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbAlue.FormattingEnabled = true;
            this.tbAlue.Location = new System.Drawing.Point(152, 317);
            this.tbAlue.Name = "tbAlue";
            this.tbAlue.Size = new System.Drawing.Size(121, 21);
            this.tbAlue.TabIndex = 26;
            this.tbAlue.ValueMember = "alue_id";
            // 
            // MokkienHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "MokkienHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mökkien Hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MokkienHallinta_FormClosed);
            this.Load += new System.EventHandler(this.MokkienHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMokki;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.TextBox tbMokki;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHlomaara;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.Label Alue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.Button tbPäivitä;
        private System.Windows.Forms.Button tbPoista;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.Label mökkienID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tbAlue;
    }
}