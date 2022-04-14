
namespace Mökkivaraus
{
    partial class Etusivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etusivu));
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.asiakasTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.asiakasTableAdapter();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdHallinta = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmToimintaAlueet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vnDataSetBindingSource;
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
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "asiakas";
            this.asiakasBindingSource1.DataSource = this.vnDataSetBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 786);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdHallinta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1023, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdHallinta
            // 
            this.tsdHallinta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdHallinta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmToimintaAlueet,
            this.tsmPalvelut});
            this.tsdHallinta.Image = ((System.Drawing.Image)(resources.GetObject("tsdHallinta.Image")));
            this.tsdHallinta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdHallinta.Name = "tsdHallinta";
            this.tsdHallinta.Size = new System.Drawing.Size(61, 22);
            this.tsdHallinta.Text = "Hallinta";
            // 
            // tsmToimintaAlueet
            // 
            this.tsmToimintaAlueet.Name = "tsmToimintaAlueet";
            this.tsmToimintaAlueet.Size = new System.Drawing.Size(191, 22);
            this.tsmToimintaAlueet.Text = "Toiminta-alue Hallinta";
            this.tsmToimintaAlueet.Click += new System.EventHandler(this.tsmToimintaAlueet_Click);
            // 
            // tsmPalvelut
            // 
            this.tsmPalvelut.Name = "tsmPalvelut";
            this.tsmPalvelut.Size = new System.Drawing.Size(191, 22);
            this.tsmPalvelut.Text = "Palveluiden Hallinta";
            this.tsmPalvelut.Click += new System.EventHandler(this.tsmPalvelut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Tekstiä";
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 783);
            this.Controls.Add(this.panel1);
            this.Name = "Etusivu";
            this.Text = "Mökki varaus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VnDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdHallinta;
        private System.Windows.Forms.ToolStripMenuItem tsmToimintaAlueet;
        private System.Windows.Forms.ToolStripMenuItem tsmPalvelut;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

