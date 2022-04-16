
namespace Mökkivaraus
{
    partial class AsiakasHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsiakasHallinta));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.asiakasTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.asiakasTableAdapter();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPostnro = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblPostnro = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPuhnro = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUusAsiakas = new System.Windows.Forms.Label();
            this.tbUusPostinro = new System.Windows.Forms.TextBox();
            this.tbUusSukunimi = new System.Windows.Forms.TextBox();
            this.tbUusEtunimi = new System.Windows.Forms.TextBox();
            this.tbUusEmail = new System.Windows.Forms.TextBox();
            this.tbUusOsoite = new System.Windows.Forms.TextBox();
            this.tbUusPuhnro = new System.Windows.Forms.TextBox();
            this.lblNykyinenAsiakas = new System.Windows.Forms.Label();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.mokkiTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asiakasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(446, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 166);
            this.dataGridView1.TabIndex = 1;
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
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vnDataSet;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "asiakas_id", true));
            this.tbID.Location = new System.Drawing.Point(727, 217);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(162, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbPostnro
            // 
            this.tbPostnro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "postinro", true));
            this.tbPostnro.Location = new System.Drawing.Point(727, 243);
            this.tbPostnro.Name = "tbPostnro";
            this.tbPostnro.Size = new System.Drawing.Size(162, 20);
            this.tbPostnro.TabIndex = 3;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "etunimi", true));
            this.tbEtunimi.Location = new System.Drawing.Point(727, 270);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(162, 20);
            this.tbEtunimi.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "email", true));
            this.tbEmail.Location = new System.Drawing.Point(727, 349);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // tbOsoite
            // 
            this.tbOsoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "lahiosoite", true));
            this.tbOsoite.Location = new System.Drawing.Point(727, 322);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(162, 20);
            this.tbOsoite.TabIndex = 6;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "sukunimi", true));
            this.tbSukunimi.Location = new System.Drawing.Point(727, 296);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(162, 20);
            this.tbSukunimi.TabIndex = 5;
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "puhelinnro", true));
            this.tbPuhnro.Location = new System.Drawing.Point(727, 375);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(162, 20);
            this.tbPuhnro.TabIndex = 8;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(625, 220);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID";
            // 
            // lblPostnro
            // 
            this.lblPostnro.AutoSize = true;
            this.lblPostnro.Location = new System.Drawing.Point(625, 246);
            this.lblPostnro.Name = "lblPostnro";
            this.lblPostnro.Size = new System.Drawing.Size(45, 13);
            this.lblPostnro.TabIndex = 10;
            this.lblPostnro.Text = "Postinro";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(625, 273);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimi.TabIndex = 11;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(625, 299);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 14;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Location = new System.Drawing.Point(625, 325);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(37, 13);
            this.lblOsoite.TabIndex = 13;
            this.lblOsoite.Text = "Osoite";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(625, 352);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Sähköposti";
            // 
            // lblPuhnro
            // 
            this.lblPuhnro.AutoSize = true;
            this.lblPuhnro.Location = new System.Drawing.Point(625, 378);
            this.lblPuhnro.Name = "lblPuhnro";
            this.lblPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblPuhnro.TabIndex = 15;
            this.lblPuhnro.Text = "Puhelinnumero";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(493, 399);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 16;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Puhelinnumero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Osoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sähköposti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Etunimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Postinro";
            // 
            // lblUusAsiakas
            // 
            this.lblUusAsiakas.AutoSize = true;
            this.lblUusAsiakas.Location = new System.Drawing.Point(443, 220);
            this.lblUusAsiakas.Name = "lblUusAsiakas";
            this.lblUusAsiakas.Size = new System.Drawing.Size(114, 13);
            this.lblUusAsiakas.TabIndex = 24;
            this.lblUusAsiakas.Text = "LISÄÄ UUSI ASIAKAS";
            // 
            // tbUusPostinro
            // 
            this.tbUusPostinro.Location = new System.Drawing.Point(446, 241);
            this.tbUusPostinro.Name = "tbUusPostinro";
            this.tbUusPostinro.Size = new System.Drawing.Size(169, 20);
            this.tbUusPostinro.TabIndex = 26;
            // 
            // tbUusSukunimi
            // 
            this.tbUusSukunimi.Location = new System.Drawing.Point(446, 294);
            this.tbUusSukunimi.Name = "tbUusSukunimi";
            this.tbUusSukunimi.Size = new System.Drawing.Size(169, 20);
            this.tbUusSukunimi.TabIndex = 28;
            // 
            // tbUusEtunimi
            // 
            this.tbUusEtunimi.Location = new System.Drawing.Point(446, 268);
            this.tbUusEtunimi.Name = "tbUusEtunimi";
            this.tbUusEtunimi.Size = new System.Drawing.Size(169, 20);
            this.tbUusEtunimi.TabIndex = 27;
            // 
            // tbUusEmail
            // 
            this.tbUusEmail.Location = new System.Drawing.Point(446, 347);
            this.tbUusEmail.Name = "tbUusEmail";
            this.tbUusEmail.Size = new System.Drawing.Size(169, 20);
            this.tbUusEmail.TabIndex = 30;
            // 
            // tbUusOsoite
            // 
            this.tbUusOsoite.Location = new System.Drawing.Point(446, 320);
            this.tbUusOsoite.Name = "tbUusOsoite";
            this.tbUusOsoite.Size = new System.Drawing.Size(169, 20);
            this.tbUusOsoite.TabIndex = 29;
            // 
            // tbUusPuhnro
            // 
            this.tbUusPuhnro.Location = new System.Drawing.Point(446, 373);
            this.tbUusPuhnro.Name = "tbUusPuhnro";
            this.tbUusPuhnro.Size = new System.Drawing.Size(169, 20);
            this.tbUusPuhnro.TabIndex = 31;
            // 
            // lblNykyinenAsiakas
            // 
            this.lblNykyinenAsiakas.AutoSize = true;
            this.lblNykyinenAsiakas.Location = new System.Drawing.Point(651, 201);
            this.lblNykyinenAsiakas.Name = "lblNykyinenAsiakas";
            this.lblNykyinenAsiakas.Size = new System.Drawing.Size(238, 13);
            this.lblNykyinenAsiakas.TabIndex = 32;
            this.lblNykyinenAsiakas.Text = "NYKYISTEN ASIAKKAIDEN TIEDOT LISTALTA";
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
            this.panel2.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Toiminta-alue Hallinta";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.tsmToiminta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Asiakas Hallinta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // AsiakasHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNykyinenAsiakas);
            this.Controls.Add(this.tbUusPuhnro);
            this.Controls.Add(this.tbUusEmail);
            this.Controls.Add(this.tbUusOsoite);
            this.Controls.Add(this.tbUusSukunimi);
            this.Controls.Add(this.tbUusEtunimi);
            this.Controls.Add(this.tbUusPostinro);
            this.Controls.Add(this.lblUusAsiakas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lblPuhnro);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblOsoite);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.lblPostnro);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.tbPuhnro);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbOsoite);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbPostnro);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "AsiakasHallinta";
            this.Text = "Asiakas Hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsiakasHallinta_FormClosed);
            this.Load += new System.EventHandler(this.AsiakasHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VnDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPostnro;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblPostnro;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPuhnro;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUusAsiakas;
        private System.Windows.Forms.TextBox tbUusPostinro;
        private System.Windows.Forms.TextBox tbUusSukunimi;
        private System.Windows.Forms.TextBox tbUusEtunimi;
        private System.Windows.Forms.TextBox tbUusEmail;
        private System.Windows.Forms.TextBox tbUusOsoite;
        private System.Windows.Forms.TextBox tbUusPuhnro;
        private System.Windows.Forms.Label lblNykyinenAsiakas;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VnDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}