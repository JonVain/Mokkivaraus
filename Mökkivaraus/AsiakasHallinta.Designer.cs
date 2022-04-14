
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsiakasHallinta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdAsiakas = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmEtusivu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmToiminta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdAsiakas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdAsiakas
            // 
            this.tsdAsiakas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdAsiakas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEtusivu,
            this.tsmToiminta,
            this.tsmPalvelut});
            this.tsdAsiakas.Image = ((System.Drawing.Image)(resources.GetObject("tsdAsiakas.Image")));
            this.tsdAsiakas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAsiakas.Name = "tsdAsiakas";
            this.tsdAsiakas.Size = new System.Drawing.Size(61, 22);
            this.tsdAsiakas.Text = "Hallinta";
            // 
            // tsmEtusivu
            // 
            this.tsmEtusivu.Name = "tsmEtusivu";
            this.tsmEtusivu.Size = new System.Drawing.Size(191, 22);
            this.tsmEtusivu.Text = "Takaisin Etusivulle";
            // 
            // tsmToiminta
            // 
            this.tsmToiminta.Name = "tsmToiminta";
            this.tsmToiminta.Size = new System.Drawing.Size(191, 22);
            this.tsmToiminta.Text = "Toiminta-alue Hallinta";
            // 
            // tsmPalvelut
            // 
            this.tsmPalvelut.Name = "tsmPalvelut";
            this.tsmPalvelut.Size = new System.Drawing.Size(191, 22);
            this.tsmPalvelut.Text = "Palveluiden Hallinta";
            // 
            // AsiakasHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AsiakasHallinta";
            this.Text = "Asiakas Hallinta";
            this.Load += new System.EventHandler(this.AsiakasHallinta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdAsiakas;
        private System.Windows.Forms.ToolStripMenuItem tsmEtusivu;
        private System.Windows.Forms.ToolStripMenuItem tsmToiminta;
        private System.Windows.Forms.ToolStripMenuItem tsmPalvelut;
    }
}