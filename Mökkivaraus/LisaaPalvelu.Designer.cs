
namespace Mökkivaraus
{
    partial class LisaaPalvelu
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
            this.btn_lisaapalvelu = new System.Windows.Forms.Button();
            this.tbpalvelu_id = new System.Windows.Forms.TextBox();
            this.tbalue_id = new System.Windows.Forms.TextBox();
            this.tbnimi = new System.Windows.Forms.TextBox();
            this.tbtyyppi = new System.Windows.Forms.TextBox();
            this.tbkuvaus = new System.Windows.Forms.TextBox();
            this.tbhinta = new System.Windows.Forms.TextBox();
            this.tbalv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tyhjenna = new System.Windows.Forms.Button();
            this.btn_keskeyta = new System.Windows.Forms.Button();
            this.palveluTableAdapter = new Mökkivaraus.VnDataSetTableAdapters.palveluTableAdapter();
            this.vnDataSet = new Mökkivaraus.VnDataSet();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lisaapalvelu
            // 
            this.btn_lisaapalvelu.Location = new System.Drawing.Point(289, 271);
            this.btn_lisaapalvelu.Name = "btn_lisaapalvelu";
            this.btn_lisaapalvelu.Size = new System.Drawing.Size(75, 23);
            this.btn_lisaapalvelu.TabIndex = 1;
            this.btn_lisaapalvelu.Text = "Lisää";
            this.btn_lisaapalvelu.UseVisualStyleBackColor = true;
            this.btn_lisaapalvelu.Click += new System.EventHandler(this.btn_lisaapalvelu_Click);
            // 
            // tbpalvelu_id
            // 
            this.tbpalvelu_id.Location = new System.Drawing.Point(138, 73);
            this.tbpalvelu_id.Name = "tbpalvelu_id";
            this.tbpalvelu_id.Size = new System.Drawing.Size(100, 20);
            this.tbpalvelu_id.TabIndex = 2;
            this.tbpalvelu_id.TextChanged += new System.EventHandler(this.tbpalvelu_id_TextChanged);
            // 
            // tbalue_id
            // 
            this.tbalue_id.Location = new System.Drawing.Point(138, 118);
            this.tbalue_id.Name = "tbalue_id";
            this.tbalue_id.Size = new System.Drawing.Size(100, 20);
            this.tbalue_id.TabIndex = 3;
            // 
            // tbnimi
            // 
            this.tbnimi.Location = new System.Drawing.Point(138, 162);
            this.tbnimi.Name = "tbnimi";
            this.tbnimi.Size = new System.Drawing.Size(100, 20);
            this.tbnimi.TabIndex = 4;
            // 
            // tbtyyppi
            // 
            this.tbtyyppi.Location = new System.Drawing.Point(138, 205);
            this.tbtyyppi.Name = "tbtyyppi";
            this.tbtyyppi.Size = new System.Drawing.Size(100, 20);
            this.tbtyyppi.TabIndex = 5;
            // 
            // tbkuvaus
            // 
            this.tbkuvaus.Location = new System.Drawing.Point(460, 73);
            this.tbkuvaus.Name = "tbkuvaus";
            this.tbkuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbkuvaus.TabIndex = 6;
            // 
            // tbhinta
            // 
            this.tbhinta.Location = new System.Drawing.Point(460, 118);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(100, 20);
            this.tbhinta.TabIndex = 7;
            // 
            // tbalv
            // 
            this.tbalv.Location = new System.Drawing.Point(460, 162);
            this.tbalv.Name = "tbalv";
            this.tbalv.Size = new System.Drawing.Size(100, 20);
            this.tbalv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palvelu tietojen lisäys";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palvelu_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alue_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tyyppi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kuvaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hinta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arvolisävero";
            // 
            // btn_tyhjenna
            // 
            this.btn_tyhjenna.Location = new System.Drawing.Point(440, 271);
            this.btn_tyhjenna.Name = "btn_tyhjenna";
            this.btn_tyhjenna.Size = new System.Drawing.Size(75, 23);
            this.btn_tyhjenna.TabIndex = 17;
            this.btn_tyhjenna.Text = "Tyhjennä";
            this.btn_tyhjenna.UseVisualStyleBackColor = true;
            this.btn_tyhjenna.Click += new System.EventHandler(this.btn_tyhjenna_Click);
            // 
            // btn_keskeyta
            // 
            this.btn_keskeyta.Location = new System.Drawing.Point(633, 36);
            this.btn_keskeyta.Name = "btn_keskeyta";
            this.btn_keskeyta.Size = new System.Drawing.Size(75, 23);
            this.btn_keskeyta.TabIndex = 18;
            this.btn_keskeyta.Text = "X";
            this.btn_keskeyta.UseVisualStyleBackColor = true;
            this.btn_keskeyta.Click += new System.EventHandler(this.btn_keskeyta_Click);
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // vnDataSet
            // 
            this.vnDataSet.DataSetName = "VnDataSet";
            this.vnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataSource = this.vnDataSet;
            this.palveluBindingSource.Position = 0;
            // 
            // LisaaPalvelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_keskeyta);
            this.Controls.Add(this.btn_tyhjenna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbalv);
            this.Controls.Add(this.tbhinta);
            this.Controls.Add(this.tbkuvaus);
            this.Controls.Add(this.tbtyyppi);
            this.Controls.Add(this.tbnimi);
            this.Controls.Add(this.tbalue_id);
            this.Controls.Add(this.tbpalvelu_id);
            this.Controls.Add(this.btn_lisaapalvelu);
            this.Name = "LisaaPalvelu";
            this.Text = "LisaaPalvelu";
            this.Load += new System.EventHandler(this.LisaaPalvelu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lisaapalvelu;
        private System.Windows.Forms.TextBox tbpalvelu_id;
        private System.Windows.Forms.TextBox tbalue_id;
        private System.Windows.Forms.TextBox tbnimi;
        private System.Windows.Forms.TextBox tbtyyppi;
        private System.Windows.Forms.TextBox tbkuvaus;
        private System.Windows.Forms.TextBox tbhinta;
        private System.Windows.Forms.TextBox tbalv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_tyhjenna;
        private System.Windows.Forms.Button btn_keskeyta;
        private VnDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private VnDataSet vnDataSet;
        private System.Windows.Forms.BindingSource palveluBindingSource;
    }
}