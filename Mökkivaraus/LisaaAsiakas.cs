using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkivaraus
{
    public partial class LisaaAsiakas : Form
    {
        public LisaaAsiakas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet);
            asiakasTableAdapter.Insert(tbPostinumero.Text, tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbEmail.Text, tbPuhnro.Text);
            this.Close();
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbPostinumero.Text = "";
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbOsoite.Text = "";
            tbEmail.Text = "";
            tbPuhnro.Text = "";
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {

        }

        private void LisaaAsiakas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
        }
    }
}
