
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
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.laskuTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.laskuTableAdapter();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.palveluhallintabtn = new System.Windows.Forms.Button();
            this.toimintahbtn = new System.Windows.Forms.Button();
            this.asiakashallintabtn = new System.Windows.Forms.Button();
            this.mokkienhallinta = new System.Windows.Forms.Button();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.asiakasTableAdapter();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLisaaVaraus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 0;
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
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vnDataSetBindingSource;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraus.Location = new System.Drawing.Point(274, 176);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(102, 20);
            this.lblVaraus.TabIndex = 37;
            this.lblVaraus.Text = "Lisää Varaus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnLisaaVaraus);
            this.panel1.Location = new System.Drawing.Point(278, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 256);
            this.panel1.TabIndex = 38;
            // 
            // btnLisaaVaraus
            // 
            this.btnLisaaVaraus.Location = new System.Drawing.Point(659, 230);
            this.btnLisaaVaraus.Name = "btnLisaaVaraus";
            this.btnLisaaVaraus.Size = new System.Drawing.Size(99, 23);
            this.btnLisaaVaraus.TabIndex = 0;
            this.btnLisaaVaraus.Text = "Lisää varaus";
            this.btnLisaaVaraus.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "asiakas";
            this.asiakasBindingSource1.DataSource = this.vnDataSetBindingSource;
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 467);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.laskutusbtn);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.palveluhallintabtn);
            this.Controls.Add(this.toimintahbtn);
            this.Controls.Add(this.asiakashallintabtn);
            this.Controls.Add(this.mokkienhallinta);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vnDataSetBindingSource;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private VnDataSetTableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button palveluhallintabtn;
        private System.Windows.Forms.Button toimintahbtn;
        private System.Windows.Forms.Button asiakashallintabtn;
        private System.Windows.Forms.Button mokkienhallinta;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VnDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLisaaVaraus;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
    }
}