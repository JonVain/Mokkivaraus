
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmEtusivu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmToiminta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAsiakas = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tbAlue = new System.Windows.Forms.TextBox();
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1126, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEtusivu,
            this.tsmToiminta,
            this.tsmPalvelut,
            this.tsmAsiakas});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Hallinta";
            // 
            // tsmEtusivu
            // 
            this.tsmEtusivu.Name = "tsmEtusivu";
            this.tsmEtusivu.Size = new System.Drawing.Size(191, 22);
            this.tsmEtusivu.Text = "Takaisin Etusivulle";
            this.tsmEtusivu.Click += new System.EventHandler(this.tsmEtusivu_Click);
            // 
            // tsmToiminta
            // 
            this.tsmToiminta.Name = "tsmToiminta";
            this.tsmToiminta.Size = new System.Drawing.Size(191, 22);
            this.tsmToiminta.Text = "Toiminta-alue Hallinta";
            this.tsmToiminta.Click += new System.EventHandler(this.tsmToiminta_Click);
            // 
            // tsmPalvelut
            // 
            this.tsmPalvelut.Name = "tsmPalvelut";
            this.tsmPalvelut.Size = new System.Drawing.Size(191, 22);
            this.tsmPalvelut.Text = "Palveluiden Hallinta";
            this.tsmPalvelut.Click += new System.EventHandler(this.tsmPalvelut_Click);
            // 
            // tsmAsiakas
            // 
            this.tsmAsiakas.Name = "tsmAsiakas";
            this.tsmAsiakas.Size = new System.Drawing.Size(191, 22);
            this.tsmAsiakas.Text = "Asiakas Hallinta";
            this.tsmAsiakas.Click += new System.EventHandler(this.tsmAsiakas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mokkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(113, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 220);
            this.dataGridView1.TabIndex = 1;
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
            this.btnLisaa.Location = new System.Drawing.Point(452, 351);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(258, 48);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbAlue
            // 
            this.tbAlue.Location = new System.Drawing.Point(167, 76);
            this.tbAlue.Name = "tbAlue";
            this.tbAlue.Size = new System.Drawing.Size(100, 20);
            this.tbAlue.TabIndex = 3;
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(167, 102);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(100, 20);
            this.tbPostinro.TabIndex = 4;
            // 
            // tbMokki
            // 
            this.tbMokki.Location = new System.Drawing.Point(167, 128);
            this.tbMokki.Name = "tbMokki";
            this.tbMokki.Size = new System.Drawing.Size(100, 20);
            this.tbMokki.TabIndex = 5;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(167, 154);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(100, 20);
            this.tbKatuosoite.TabIndex = 6;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(167, 180);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 7;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(167, 206);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbKuvaus.TabIndex = 8;
            // 
            // tbHlomaara
            // 
            this.tbHlomaara.Location = new System.Drawing.Point(167, 232);
            this.tbHlomaara.Name = "tbHlomaara";
            this.tbHlomaara.Size = new System.Drawing.Size(100, 20);
            this.tbHlomaara.TabIndex = 9;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(167, 258);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(100, 20);
            this.tbVarustelu.TabIndex = 10;
            // 
            // Alue
            // 
            this.Alue.AutoSize = true;
            this.Alue.Location = new System.Drawing.Point(70, 76);
            this.Alue.Name = "Alue";
            this.Alue.Size = new System.Drawing.Size(28, 13);
            this.Alue.TabIndex = 12;
            this.Alue.Text = "Alue";
            this.Alue.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Postinumero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mökkinimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Katuosoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hinta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kuvaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Henkilömäärä";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Varustelu";
            // 
            // MokkienHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 637);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Alue);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbHlomaara);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokki);
            this.Controls.Add(this.tbPostinro);
            this.Controls.Add(this.tbAlue);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MokkienHallinta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MokkienHallinta_FormClosing);
            this.Load += new System.EventHandler(this.MokkienHallinta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmEtusivu;
        private System.Windows.Forms.ToolStripMenuItem tsmToiminta;
        private System.Windows.Forms.ToolStripMenuItem tsmPalvelut;
        private System.Windows.Forms.ToolStripMenuItem tsmAsiakas;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox tbAlue;
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
    }
}