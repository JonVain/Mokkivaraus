
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
            this.testibox = new System.Windows.Forms.TextBox();
            this.laskutusbtn = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.palveluhallintabtn = new System.Windows.Forms.Button();
            this.toimintahbtn = new System.Windows.Forms.Button();
            this.asiakashallintabtn = new System.Windows.Forms.Button();
            this.mokkienhallinta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
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
            // testibox
            // 
            this.testibox.Location = new System.Drawing.Point(344, 107);
            this.testibox.Name = "testibox";
            this.testibox.Size = new System.Drawing.Size(444, 20);
            this.testibox.TabIndex = 2;
            // 
            // laskutusbtn
            // 
            this.laskutusbtn.BackColor = System.Drawing.Color.Transparent;
            this.laskutusbtn.FlatAppearance.BorderSize = 0;
            this.laskutusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laskutusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskutusbtn.Image = ((System.Drawing.Image)(resources.GetObject("laskutusbtn.Image")));
            this.laskutusbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laskutusbtn.Location = new System.Drawing.Point(12, 388);
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
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskutusbtn);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.palveluhallintabtn);
            this.Controls.Add(this.toimintahbtn);
            this.Controls.Add(this.asiakashallintabtn);
            this.Controls.Add(this.mokkienhallinta);
            this.Controls.Add(this.testibox);
            this.Controls.Add(this.etsiasiakasBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Laskutus";
            this.Text = "Laskutus";
            this.Load += new System.EventHandler(this.Laskutus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox testibox;
        private System.Windows.Forms.Button laskutusbtn;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button palveluhallintabtn;
        private System.Windows.Forms.Button toimintahbtn;
        private System.Windows.Forms.Button asiakashallintabtn;
        private System.Windows.Forms.Button mokkienhallinta;
    }
}