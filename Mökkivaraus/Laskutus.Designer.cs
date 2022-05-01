
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
            this.laskuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.laskuTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.laskuTableAdapter();
            this.etsiasiakasBtn = new System.Windows.Forms.Button();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.palveluhallintabtn = new System.Windows.Forms.Button();
            this.toimintahbtn = new System.Windows.Forms.Button();
            this.asiakashallintabtn = new System.Windows.Forms.Button();
            this.mokkienhallinta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblPostnro = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblPuhnro = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.asiakasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laskuidDataGridViewTextBoxColumn,
            this.varausidDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.laskuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // laskuidDataGridViewTextBoxColumn
            // 
            this.laskuidDataGridViewTextBoxColumn.DataPropertyName = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.HeaderText = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.Name = "laskuidDataGridViewTextBoxColumn";
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
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
            // etsiasiakasBtn
            // 
            this.etsiasiakasBtn.Location = new System.Drawing.Point(613, 57);
            this.etsiasiakasBtn.Name = "etsiasiakasBtn";
            this.etsiasiakasBtn.Size = new System.Drawing.Size(86, 32);
            this.etsiasiakasBtn.TabIndex = 1;
            this.etsiasiakasBtn.Text = "Etsi asiakas";
            this.etsiasiakasBtn.UseVisualStyleBackColor = true;
            this.etsiasiakasBtn.Click += new System.EventHandler(this.etsiasiakasBtn_Click);
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "etunimi", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(402, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 37;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "postinro", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(402, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "email", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(402, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(341, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Sähköposti";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(341, 164);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimi.TabIndex = 44;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblPostnro
            // 
            this.lblPostnro.AutoSize = true;
            this.lblPostnro.Location = new System.Drawing.Point(341, 199);
            this.lblPostnro.Name = "lblPostnro";
            this.lblPostnro.Size = new System.Drawing.Size(45, 13);
            this.lblPostnro.TabIndex = 43;
            this.lblPostnro.Text = "Postinro";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "puhelinnro", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(641, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 20);
            this.textBox4.TabIndex = 48;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "lahiosoite", true));
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(641, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 20);
            this.textBox5.TabIndex = 47;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "sukunimi", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(641, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 20);
            this.textBox6.TabIndex = 46;
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Location = new System.Drawing.Point(577, 199);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(37, 13);
            this.lblOsoite.TabIndex = 49;
            this.lblOsoite.Text = "Osoite";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(577, 158);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 50;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblPuhnro
            // 
            this.lblPuhnro.AutoSize = true;
            this.lblPuhnro.Location = new System.Drawing.Point(558, 239);
            this.lblPuhnro.Name = "lblPuhnro";
            this.lblPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblPuhnro.TabIndex = 51;
            this.lblPuhnro.Text = "Puhelinnumero";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.asiakasBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(309, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 52;
            this.dataGridView2.Visible = false;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 467);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblOsoite);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblPuhnro);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.lblPostnro);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laskutusbtn);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.palveluhallintabtn);
            this.Controls.Add(this.toimintahbtn);
            this.Controls.Add(this.asiakashallintabtn);
            this.Controls.Add(this.mokkienhallinta);
            this.Controls.Add(this.etsiasiakasBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private VnDataSetTableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn laskuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button etsiasiakasBtn;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button palveluhallintabtn;
        private System.Windows.Forms.Button toimintahbtn;
        private System.Windows.Forms.Button asiakashallintabtn;
        private System.Windows.Forms.Button mokkienhallinta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblPostnro;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblPuhnro;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VnDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
    }
}