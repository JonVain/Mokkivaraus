
namespace Mökkivaraus
{
    partial class LisaaAlue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_otsikko = new System.Windows.Forms.Label();
            this.lbUusiAlue = new System.Windows.Forms.Label();
            this.tbUusiAlue = new System.Windows.Forms.TextBox();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.alueTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.alueTableAdapter();
            this.alueBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 22);
            this.panel1.TabIndex = 0;
            // 
            // lb_otsikko
            // 
            this.lb_otsikko.AutoSize = true;
            this.lb_otsikko.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_otsikko.Location = new System.Drawing.Point(14, 30);
            this.lb_otsikko.Name = "lb_otsikko";
            this.lb_otsikko.Size = new System.Drawing.Size(239, 21);
            this.lb_otsikko.TabIndex = 1;
            this.lb_otsikko.Text = "LISÄÄ UUSI TOIMINTA-ALUE";
            this.lb_otsikko.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbUusiAlue
            // 
            this.lbUusiAlue.AutoSize = true;
            this.lbUusiAlue.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUusiAlue.Location = new System.Drawing.Point(14, 85);
            this.lbUusiAlue.Name = "lbUusiAlue";
            this.lbUusiAlue.Size = new System.Drawing.Size(160, 19);
            this.lbUusiAlue.TabIndex = 2;
            this.lbUusiAlue.Text = "Toiminta-Alueen nimi";
            this.lbUusiAlue.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbUusiAlue
            // 
            this.tbUusiAlue.Location = new System.Drawing.Point(217, 85);
            this.tbUusiAlue.Name = "tbUusiAlue";
            this.tbUusiAlue.Size = new System.Drawing.Size(240, 22);
            this.tbUusiAlue.TabIndex = 2;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyhjenna.Location = new System.Drawing.Point(269, 148);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(112, 56);
            this.btnTyhjenna.TabIndex = 9;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(123, 148);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(112, 56);
            this.btnLisaa.TabIndex = 7;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // alueBindingSource8
            // 
            this.alueBindingSource8.DataMember = "alue";
            this.alueBindingSource8.DataSource = this.vnDataSet;
            // 
            // LisaaAlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 238);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.tbUusiAlue);
            this.Controls.Add(this.lbUusiAlue);
            this.Controls.Add(this.lb_otsikko);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "LisaaAlue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lisää Asiakas";
            this.Load += new System.EventHandler(this.LisaaAsiakas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_otsikko;
        private System.Windows.Forms.Label lbUusiAlue;
        private System.Windows.Forms.TextBox tbUusiAlue;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnClose;
        private VnDataSet vnDataSet;
        private VnDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.BindingSource alueBindingSource8;
    }
}