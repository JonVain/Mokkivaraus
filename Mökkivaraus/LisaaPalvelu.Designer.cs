
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LisaaPalvelu));
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
            this.btn_lisaapalvelu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lisaapalvelu.Location = new System.Drawing.Point(280, 313);
            this.btn_lisaapalvelu.Name = "btn_lisaapalvelu";
            this.btn_lisaapalvelu.Size = new System.Drawing.Size(75, 23);
            this.btn_lisaapalvelu.TabIndex = 1;
            this.btn_lisaapalvelu.Text = "Lisää";
            this.btn_lisaapalvelu.UseVisualStyleBackColor = true;
            this.btn_lisaapalvelu.Click += new System.EventHandler(this.btn_lisaapalvelu_Click);
            // 
            // tbpalvelu_id
            // 
            this.tbpalvelu_id.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpalvelu_id.Location = new System.Drawing.Point(148, 76);
            this.tbpalvelu_id.Name = "tbpalvelu_id";
            this.tbpalvelu_id.Size = new System.Drawing.Size(100, 23);
            this.tbpalvelu_id.TabIndex = 2;
            this.tbpalvelu_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpalvelu_id_KeyPress);
            this.tbpalvelu_id.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbalue_id
            // 
            this.tbalue_id.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbalue_id.Location = new System.Drawing.Point(148, 121);
            this.tbalue_id.Name = "tbalue_id";
            this.tbalue_id.Size = new System.Drawing.Size(100, 23);
            this.tbalue_id.TabIndex = 3;
            this.tbalue_id.TextChanged += new System.EventHandler(this.tbalue_id_TextChanged);
            this.tbalue_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbalue_id_KeyPress);
            this.tbalue_id.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbnimi
            // 
            this.tbnimi.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnimi.Location = new System.Drawing.Point(148, 165);
            this.tbnimi.Name = "tbnimi";
            this.tbnimi.Size = new System.Drawing.Size(100, 23);
            this.tbnimi.TabIndex = 4;
            this.tbnimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnimi_KeyPress);
            this.tbnimi.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbtyyppi
            // 
            this.tbtyyppi.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtyyppi.Location = new System.Drawing.Point(148, 208);
            this.tbtyyppi.Name = "tbtyyppi";
            this.tbtyyppi.Size = new System.Drawing.Size(100, 23);
            this.tbtyyppi.TabIndex = 5;
            this.tbtyyppi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtyyppi_KeyPress);
            this.tbtyyppi.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbkuvaus
            // 
            this.tbkuvaus.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkuvaus.Location = new System.Drawing.Point(148, 251);
            this.tbkuvaus.Name = "tbkuvaus";
            this.tbkuvaus.Size = new System.Drawing.Size(100, 23);
            this.tbkuvaus.TabIndex = 6;
            this.tbkuvaus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbkuvaus_KeyPress);
            this.tbkuvaus.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbhinta
            // 
            this.tbhinta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhinta.Location = new System.Drawing.Point(148, 293);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(100, 23);
            this.tbhinta.TabIndex = 7;
            this.tbhinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbhinta_KeyPress);
            this.tbhinta.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // tbalv
            // 
            this.tbalv.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbalv.Location = new System.Drawing.Point(148, 336);
            this.tbalv.Name = "tbalv";
            this.tbalv.Size = new System.Drawing.Size(100, 23);
            this.tbalv.TabIndex = 8;
            this.tbalv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbalv_KeyPress);
            this.tbalv.Leave += new System.EventHandler(this.tbKaikki_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palvelu tietojen lisäys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palvelu_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alue_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tyyppi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kuvaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hinta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arvolisävero";
            // 
            // btn_tyhjenna
            // 
            this.btn_tyhjenna.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tyhjenna.Location = new System.Drawing.Point(280, 247);
            this.btn_tyhjenna.Name = "btn_tyhjenna";
            this.btn_tyhjenna.Size = new System.Drawing.Size(75, 23);
            this.btn_tyhjenna.TabIndex = 17;
            this.btn_tyhjenna.Text = "Tyhjennä";
            this.btn_tyhjenna.UseVisualStyleBackColor = true;
            this.btn_tyhjenna.Click += new System.EventHandler(this.btn_tyhjenna_Click);
            // 
            // btn_keskeyta
            // 
            this.btn_keskeyta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_keskeyta.BackgroundImage")));
            this.btn_keskeyta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_keskeyta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_keskeyta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keskeyta.Location = new System.Drawing.Point(330, 24);
            this.btn_keskeyta.Name = "btn_keskeyta";
            this.btn_keskeyta.Size = new System.Drawing.Size(25, 20);
            this.btn_keskeyta.TabIndex = 18;
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
            this.ClientSize = new System.Drawing.Size(378, 406);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LisaaPalvelu_KeyPress);
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