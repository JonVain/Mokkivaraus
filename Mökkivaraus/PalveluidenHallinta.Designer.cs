
namespace Mökkivaraus
{
    partial class PalveluidenHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalveluidenHallinta));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_plvlisaa = new System.Windows.Forms.Button();
            this.Btn_plvpoista = new System.Windows.Forms.Button();
            this.btn_paivita = new System.Windows.Forms.Button();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.tbpalvelu_id = new System.Windows.Forms.TextBox();
            this.tbalue_id = new System.Windows.Forms.TextBox();
            this.tbnimi = new System.Windows.Forms.TextBox();
            this.tbtyyppi = new System.Windows.Forms.TextBox();
            this.tbkuvaus = new System.Windows.Forms.TextBox();
            this.tbhinta = new System.Windows.Forms.TextBox();
            this.tbalvi = new System.Windows.Forms.TextBox();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.palveluTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_paivitaplv = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
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
            this.panel2.TabIndex = 21;
            // 
            // Btn_plvlisaa
            // 
            this.Btn_plvlisaa.Location = new System.Drawing.Point(311, 413);
            this.Btn_plvlisaa.Name = "Btn_plvlisaa";
            this.Btn_plvlisaa.Size = new System.Drawing.Size(106, 23);
            this.Btn_plvlisaa.TabIndex = 22;
            this.Btn_plvlisaa.Text = "Lisää palvelu";
            this.Btn_plvlisaa.UseVisualStyleBackColor = true;
            this.Btn_plvlisaa.Click += new System.EventHandler(this.Btn_plvlisaa_Click);
            // 
            // Btn_plvpoista
            // 
            this.Btn_plvpoista.Location = new System.Drawing.Point(311, 442);
            this.Btn_plvpoista.Name = "Btn_plvpoista";
            this.Btn_plvpoista.Size = new System.Drawing.Size(106, 23);
            this.Btn_plvpoista.TabIndex = 23;
            this.Btn_plvpoista.Text = "Poista palvelu";
            this.Btn_plvpoista.UseVisualStyleBackColor = true;
            this.Btn_plvpoista.Click += new System.EventHandler(this.Btn_plvpoista_Click);
            // 
            // btn_paivita
            // 
            this.btn_paivita.Location = new System.Drawing.Point(311, 471);
            this.btn_paivita.Name = "btn_paivita";
            this.btn_paivita.Size = new System.Drawing.Size(106, 23);
            this.btn_paivita.TabIndex = 24;
            this.btn_paivita.Text = "Päivitä tiedot";
            this.btn_paivita.UseVisualStyleBackColor = true;
            this.btn_paivita.Click += new System.EventHandler(this.btn_paivita_Click);
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.AllowUserToDeleteRows = false;
            this.dgvPalvelut.AutoGenerateColumns = false;
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dgvPalvelut.DataSource = this.palveluBindingSource1;
            this.dgvPalvelut.Location = new System.Drawing.Point(302, 12);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(745, 150);
            this.dgvPalvelut.TabIndex = 25;
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
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
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // palveluBindingSource1
            // 
            this.palveluBindingSource1.DataMember = "palvelu";
            this.palveluBindingSource1.DataSource = this.vnDataSet;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpalvelu_id
            // 
            this.tbpalvelu_id.Location = new System.Drawing.Point(594, 404);
            this.tbpalvelu_id.Name = "tbpalvelu_id";
            this.tbpalvelu_id.Size = new System.Drawing.Size(100, 20);
            this.tbpalvelu_id.TabIndex = 26;
            // 
            // tbalue_id
            // 
            this.tbalue_id.Location = new System.Drawing.Point(594, 430);
            this.tbalue_id.Name = "tbalue_id";
            this.tbalue_id.Size = new System.Drawing.Size(100, 20);
            this.tbalue_id.TabIndex = 27;
            // 
            // tbnimi
            // 
            this.tbnimi.Location = new System.Drawing.Point(594, 456);
            this.tbnimi.Name = "tbnimi";
            this.tbnimi.Size = new System.Drawing.Size(100, 20);
            this.tbnimi.TabIndex = 28;
            // 
            // tbtyyppi
            // 
            this.tbtyyppi.Location = new System.Drawing.Point(594, 482);
            this.tbtyyppi.Name = "tbtyyppi";
            this.tbtyyppi.Size = new System.Drawing.Size(100, 20);
            this.tbtyyppi.TabIndex = 29;
            // 
            // tbkuvaus
            // 
            this.tbkuvaus.Location = new System.Drawing.Point(804, 404);
            this.tbkuvaus.Name = "tbkuvaus";
            this.tbkuvaus.Size = new System.Drawing.Size(317, 20);
            this.tbkuvaus.TabIndex = 30;
            // 
            // tbhinta
            // 
            this.tbhinta.Location = new System.Drawing.Point(804, 430);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(317, 20);
            this.tbhinta.TabIndex = 31;
            // 
            // tbalvi
            // 
            this.tbalvi.Location = new System.Drawing.Point(804, 455);
            this.tbalvi.Name = "tbalvi";
            this.tbalvi.Size = new System.Drawing.Size(317, 20);
            this.tbalvi.TabIndex = 32;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Palvelu id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Alue id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "tyyppi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "kuvaus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "hinta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "alv";
            // 
            // btn_paivitaplv
            // 
            this.btn_paivitaplv.Location = new System.Drawing.Point(804, 485);
            this.btn_paivitaplv.Name = "btn_paivitaplv";
            this.btn_paivitaplv.Size = new System.Drawing.Size(155, 23);
            this.btn_paivitaplv.TabIndex = 40;
            this.btn_paivitaplv.Text = "Päivitä palvelu tiedot";
            this.btn_paivitaplv.UseVisualStyleBackColor = true;
            this.btn_paivitaplv.Click += new System.EventHandler(this.button6_Click);
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
            this.button3.Click += new System.EventHandler(this.tsmToimintaAlueet_Click);
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
            // PalveluidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 781);
            this.Controls.Add(this.btn_paivitaplv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbalvi);
            this.Controls.Add(this.tbhinta);
            this.Controls.Add(this.tbkuvaus);
            this.Controls.Add(this.tbtyyppi);
            this.Controls.Add(this.tbnimi);
            this.Controls.Add(this.tbalue_id);
            this.Controls.Add(this.tbpalvelu_id);
            this.Controls.Add(this.dgvPalvelut);
            this.Controls.Add(this.btn_paivita);
            this.Controls.Add(this.Btn_plvpoista);
            this.Controls.Add(this.Btn_plvlisaa);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "PalveluidenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Palveluiden Hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PalveluidenHallinta_FormClosed);
            this.Load += new System.EventHandler(this.PalveluidenHallinta_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_plvlisaa;
        private System.Windows.Forms.Button Btn_plvpoista;
        private System.Windows.Forms.Button btn_paivita;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VnDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource palveluBindingSource1;
        private System.Windows.Forms.TextBox tbpalvelu_id;
        private System.Windows.Forms.TextBox tbalue_id;
        private System.Windows.Forms.TextBox tbnimi;
        private System.Windows.Forms.TextBox tbtyyppi;
        private System.Windows.Forms.TextBox tbkuvaus;
        private System.Windows.Forms.TextBox tbhinta;
        private System.Windows.Forms.TextBox tbalvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_paivitaplv;
        private System.Windows.Forms.Button btnRaportit;
    }
}