
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
            this.dataGridView1.Location = new System.Drawing.Point(171, 273);
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
            this.etsiasiakasBtn.Location = new System.Drawing.Point(30, 34);
            this.etsiasiakasBtn.Name = "etsiasiakasBtn";
            this.etsiasiakasBtn.Size = new System.Drawing.Size(86, 32);
            this.etsiasiakasBtn.TabIndex = 1;
            this.etsiasiakasBtn.Text = "Etsi asiakas";
            this.etsiasiakasBtn.UseVisualStyleBackColor = true;
            this.etsiasiakasBtn.Click += new System.EventHandler(this.etsiasiakasBtn_Click);
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}