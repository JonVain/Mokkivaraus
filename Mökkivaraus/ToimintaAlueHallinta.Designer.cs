
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmEtusivu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAsiakas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMokki = new System.Windows.Forms.ToolStripMenuItem();
            this.lbToimintaA = new System.Windows.Forms.Label();
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.ToimintaAlueLista = new System.Windows.Forms.ComboBox();
            this.alueBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbMokit = new System.Windows.Forms.Label();
            this.gridMokkiTaulukko = new System.Windows.Forms.DataGridView();
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
            this.mokkiTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.mokkiTableAdapter();
            this.alueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMokkiTaulukko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(990, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEtusivu,
            this.tsmPalvelut,
            this.tsmAsiakas,
            this.tsmMokki});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Hallinta";
            // 
            // tsmEtusivu
            // 
            this.tsmEtusivu.Name = "tsmEtusivu";
            this.tsmEtusivu.Size = new System.Drawing.Size(179, 22);
            this.tsmEtusivu.Text = "Takaisin Etusivulle";
            this.tsmEtusivu.Click += new System.EventHandler(this.tsmEtusivu_Click);
            // 
            // tsmPalvelut
            // 
            this.tsmPalvelut.Name = "tsmPalvelut";
            this.tsmPalvelut.Size = new System.Drawing.Size(179, 22);
            this.tsmPalvelut.Text = "Palveluiden Hallinta";
            this.tsmPalvelut.Click += new System.EventHandler(this.tsmPalvelut_Click);
            // 
            // tsmAsiakas
            // 
            this.tsmAsiakas.Name = "tsmAsiakas";
            this.tsmAsiakas.Size = new System.Drawing.Size(179, 22);
            this.tsmAsiakas.Text = "Asiakas Hallinta";
            this.tsmAsiakas.Click += new System.EventHandler(this.tsmAsiakas_Click);
            // 
            // tsmMokki
            // 
            this.tsmMokki.Name = "tsmMokki";
            this.tsmMokki.Size = new System.Drawing.Size(179, 22);
            this.tsmMokki.Text = "Mökkien Hallinta";
            this.tsmMokki.Click += new System.EventHandler(this.tsmMokki_Click);
            // 
            // lbToimintaA
            // 
            this.lbToimintaA.AutoSize = true;
            this.lbToimintaA.Location = new System.Drawing.Point(63, 54);
            this.lbToimintaA.Name = "lbToimintaA";
            this.lbToimintaA.Size = new System.Drawing.Size(70, 13);
            this.lbToimintaA.TabIndex = 3;
            this.lbToimintaA.Text = "Toiminta-alue";
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
            // ToimintaAlueLista
            // 
            this.ToimintaAlueLista.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alueBindingSource4, "alue_id", true));
            this.ToimintaAlueLista.DataSource = this.alueBindingSource3;
            this.ToimintaAlueLista.DisplayMember = "nimi";
            this.ToimintaAlueLista.FormattingEnabled = true;
            this.ToimintaAlueLista.Location = new System.Drawing.Point(66, 79);
            this.ToimintaAlueLista.Name = "ToimintaAlueLista";
            this.ToimintaAlueLista.Size = new System.Drawing.Size(164, 21);
            this.ToimintaAlueLista.TabIndex = 5;
            this.ToimintaAlueLista.ValueMember = "alue_id";
            this.ToimintaAlueLista.SelectedIndexChanged += new System.EventHandler(this.ToimintaAlueLista_SelectedIndexChanged);
            // 
            // alueBindingSource4
            // 
            this.alueBindingSource4.DataMember = "alue";
            this.alueBindingSource4.DataSource = this.vnDataSet;
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
            this.lbMokit.Location = new System.Drawing.Point(268, 54);
            this.lbMokit.Name = "lbMokit";
            this.lbMokit.Size = new System.Drawing.Size(36, 13);
            this.lbMokit.TabIndex = 6;
            this.lbMokit.Text = "Mökit:";
            this.lbMokit.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridMokkiTaulukko
            // 
            this.gridMokkiTaulukko.AutoGenerateColumns = false;
            this.gridMokkiTaulukko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMokkiTaulukko.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.gridMokkiTaulukko.DataSource = this.mokkiBindingSource;
            this.gridMokkiTaulukko.Location = new System.Drawing.Point(271, 79);
            this.gridMokkiTaulukko.Name = "gridMokkiTaulukko";
            this.gridMokkiTaulukko.Size = new System.Drawing.Size(649, 150);
            this.gridMokkiTaulukko.TabIndex = 7;
            this.gridMokkiTaulukko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMokkiTaulukko_CellContentClick);
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
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // alueBindingSource2
            // 
            this.alueBindingSource2.DataMember = "alue";
            this.alueBindingSource2.DataSource = this.vnDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(990, 25);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // ToimintaAlueHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 613);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.gridMokkiTaulukko);
            this.Controls.Add(this.lbMokit);
            this.Controls.Add(this.ToimintaAlueLista);
            this.Controls.Add(this.lbToimintaA);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToimintaAlueHallinta";
            this.Text = "Toiminta-alue Hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToimintaAlueHallinta_FormClosed);
            this.Load += new System.EventHandler(this.ToimintaAlueHallinta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMokkiTaulukko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmEtusivu;
        private System.Windows.Forms.ToolStripMenuItem tsmPalvelut;
        private System.Windows.Forms.ToolStripMenuItem tsmAsiakas;
        private System.Windows.Forms.ToolStripMenuItem tsmMokki;
        private System.Windows.Forms.Label lbToimintaA;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.ComboBox ToimintaAlueLista;
        private System.Windows.Forms.BindingSource alueBindingSource1;
        private System.Windows.Forms.Label lbMokit;
        private System.Windows.Forms.DataGridView gridMokkiTaulukko;
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
        private System.Windows.Forms.BindingSource alueBindingSource2;
        private System.Windows.Forms.BindingSource alueBindingSource4;
        private System.Windows.Forms.BindingSource alueBindingSource3;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}