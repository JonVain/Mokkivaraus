
namespace Mökkivaraus
{
    partial class ToimintaAlueHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToimintaAlueHallinta));
            this.lbToimintaA = new System.Windows.Forms.Label();
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.cb_toimintaAlueLista = new System.Windows.Forms.ComboBox();
            this.alueBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbMokit = new System.Windows.Forms.Label();
            this.gridMokkiTaulukko = new System.Windows.Forms.DataGridView();
            this.alue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.mokkiTableAdapter();
            this.alueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alueBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.dgvAlueet = new System.Windows.Forms.DataGridView();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPoistaAlueTaulukosta = new System.Windows.Forms.Button();
            this.tbPaivitaAlueTaulukko = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nimi = new System.Windows.Forms.TextBox();
            this.alueBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMokkiTaulukko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource10)).BeginInit();
            this.SuspendLayout();
            // 
            // lbToimintaA
            // 
            this.lbToimintaA.AutoSize = true;
            this.lbToimintaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToimintaA.Location = new System.Drawing.Point(306, 53);
            this.lbToimintaA.Name = "lbToimintaA";
            this.lbToimintaA.Size = new System.Drawing.Size(152, 20);
            this.lbToimintaA.TabIndex = 3;
            this.lbToimintaA.Text = "Valitse toiminta-alue";
            this.lbToimintaA.Click += new System.EventHandler(this.lbToimintaA_Click);
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cb_toimintaAlueLista
            // 
            this.cb_toimintaAlueLista.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alueBindingSource4, "alue_id", true));
            this.cb_toimintaAlueLista.DataSource = this.alueBindingSource7;
            this.cb_toimintaAlueLista.DisplayMember = "nimi";
            this.cb_toimintaAlueLista.FormattingEnabled = true;
            this.cb_toimintaAlueLista.Location = new System.Drawing.Point(310, 76);
            this.cb_toimintaAlueLista.Name = "cb_toimintaAlueLista";
            this.cb_toimintaAlueLista.Size = new System.Drawing.Size(164, 21);
            this.cb_toimintaAlueLista.TabIndex = 5;
            this.cb_toimintaAlueLista.ValueMember = "alue_id";
            this.cb_toimintaAlueLista.SelectedIndexChanged += new System.EventHandler(this.ToimintaAlueLista_SelectedIndexChanged);
            // 
            // alueBindingSource4
            // 
            this.alueBindingSource4.DataMember = "alue";
            this.alueBindingSource4.DataSource = this.vnDataSet;
            // 
            // alueBindingSource7
            // 
            this.alueBindingSource7.DataMember = "alue";
            this.alueBindingSource7.DataSource = this.vnDataSet;
            // 
            // alueBindingSource5
            // 
            this.alueBindingSource5.DataMember = "alue";
            this.alueBindingSource5.DataSource = this.vnDataSet;
            // 
            // alueBindingSource3
            // 
            this.alueBindingSource3.DataMember = "alue";
            this.alueBindingSource3.DataSource = this.vnDataSet;
            // 
            // alueBindingSource1
            // 
            this.alueBindingSource1.DataMember = "alue";
            this.alueBindingSource1.DataSource = this.vnDataSet;
            // 
            // lbMokit
            // 
            this.lbMokit.AutoSize = true;
            this.lbMokit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMokit.Location = new System.Drawing.Point(306, 193);
            this.lbMokit.Name = "lbMokit";
            this.lbMokit.Size = new System.Drawing.Size(51, 20);
            this.lbMokit.TabIndex = 6;
            this.lbMokit.Text = "Mökit:";
            this.lbMokit.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridMokkiTaulukko
            // 
            this.gridMokkiTaulukko.AutoGenerateColumns = false;
            this.gridMokkiTaulukko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMokkiTaulukko.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alue_id,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.gridMokkiTaulukko.DataSource = this.mokkiBindingSource;
            this.gridMokkiTaulukko.Location = new System.Drawing.Point(310, 216);
            this.gridMokkiTaulukko.Name = "gridMokkiTaulukko";
            this.gridMokkiTaulukko.Size = new System.Drawing.Size(845, 185);
            this.gridMokkiTaulukko.TabIndex = 7;
            // 
            // alue_id
            // 
            this.alue_id.DataPropertyName = "alue_id";
            this.alue_id.HeaderText = "alue_id";
            this.alue_id.Name = "alue_id";
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
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
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
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // alueBindingSource2
            // 
            this.alueBindingSource2.DataMember = "alue";
            this.alueBindingSource2.DataSource = this.vnDataSet;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 781);
            this.panel2.TabIndex = 21;
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
            this.button1.Click += new System.EventHandler(this.tsmMokki_Click);
            // 
            // alueBindingSource6
            // 
            this.alueBindingSource6.DataMember = "alue";
            this.alueBindingSource6.DataSource = this.vnDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(310, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 34);
            this.button6.TabIndex = 22;
            this.button6.Text = "Lisää uusi alue";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnLisaaAlue_Click);
            // 
            // dgvAlueet
            // 
            this.dgvAlueet.AutoGenerateColumns = false;
            this.dgvAlueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn});
            this.dgvAlueet.DataSource = this.alueBindingSource8;
            this.dgvAlueet.Location = new System.Drawing.Point(469, 454);
            this.dgvAlueet.Name = "dgvAlueet";
            this.dgvAlueet.Size = new System.Drawing.Size(243, 253);
            this.dgvAlueet.TabIndex = 24;
            this.dgvAlueet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "alue_id";
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // alueBindingSource8
            // 
            this.alueBindingSource8.DataMember = "alue";
            this.alueBindingSource8.DataSource = this.vnDataSet;
            // 
            // btnPoistaAlueTaulukosta
            // 
            this.btnPoistaAlueTaulukosta.Location = new System.Drawing.Point(310, 494);
            this.btnPoistaAlueTaulukosta.Name = "btnPoistaAlueTaulukosta";
            this.btnPoistaAlueTaulukosta.Size = new System.Drawing.Size(125, 34);
            this.btnPoistaAlueTaulukosta.TabIndex = 22;
            this.btnPoistaAlueTaulukosta.Text = "Poista toiminta-alue";
            this.btnPoistaAlueTaulukosta.UseVisualStyleBackColor = true;
            this.btnPoistaAlueTaulukosta.Click += new System.EventHandler(this.btnPoistaAlueTaulukosta_Click);
            // 
            // tbPaivitaAlueTaulukko
            // 
            this.tbPaivitaAlueTaulukko.Location = new System.Drawing.Point(310, 454);
            this.tbPaivitaAlueTaulukko.Name = "tbPaivitaAlueTaulukko";
            this.tbPaivitaAlueTaulukko.Size = new System.Drawing.Size(125, 34);
            this.tbPaivitaAlueTaulukko.TabIndex = 22;
            this.tbPaivitaAlueTaulukko.Text = "Päivitä taulukko";
            this.tbPaivitaAlueTaulukko.UseVisualStyleBackColor = true;
            this.tbPaivitaAlueTaulukko.Click += new System.EventHandler(this.tbPaivitaAlueTaulukko_Click);
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alueBindingSource9, "alue_id", true));
            this.tb_id.Location = new System.Drawing.Point(827, 454);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 25;
            this.tb_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_nimi
            // 
            this.tb_nimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alueBindingSource10, "nimi", true));
            this.tb_nimi.Location = new System.Drawing.Point(827, 480);
            this.tb_nimi.Name = "tb_nimi";
            this.tb_nimi.Size = new System.Drawing.Size(100, 20);
            this.tb_nimi.TabIndex = 25;
            this.tb_nimi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // alueBindingSource9
            // 
            this.alueBindingSource9.DataMember = "alue";
            this.alueBindingSource9.DataSource = this.vnDataSet;
            // 
            // alueBindingSource10
            // 
            this.alueBindingSource10.DataMember = "alue";
            this.alueBindingSource10.DataSource = this.vnDataSet;
            // 
            // ToimintaAlueHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.tb_nimi);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.dgvAlueet);
            this.Controls.Add(this.btnPoistaAlueTaulukosta);
            this.Controls.Add(this.tbPaivitaAlueTaulukko);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridMokkiTaulukko);
            this.Controls.Add(this.lbMokit);
            this.Controls.Add(this.cb_toimintaAlueLista);
            this.Controls.Add(this.lbToimintaA);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ToimintaAlueHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toiminta-alue Hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToimintaAlueHallinta_FormClosed);
            this.Load += new System.EventHandler(this.ToimintaAlueHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMokkiTaulukko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbToimintaA;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.ComboBox cb_toimintaAlueLista;
        private System.Windows.Forms.BindingSource alueBindingSource1;
        private System.Windows.Forms.Label lbMokit;
        private System.Windows.Forms.DataGridView gridMokkiTaulukko;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource alueBindingSource2;
        private System.Windows.Forms.BindingSource alueBindingSource4;
        private System.Windows.Forms.BindingSource alueBindingSource3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource alueBindingSource5;
        private System.Windows.Forms.BindingSource alueBindingSource7;
        private System.Windows.Forms.BindingSource alueBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn alue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvAlueet;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alueBindingSource8;
        private System.Windows.Forms.Button btnPoistaAlueTaulukosta;
        private System.Windows.Forms.Button tbPaivitaAlueTaulukko;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nimi;
        private System.Windows.Forms.BindingSource alueBindingSource9;
        private System.Windows.Forms.BindingSource alueBindingSource10;
    }
}