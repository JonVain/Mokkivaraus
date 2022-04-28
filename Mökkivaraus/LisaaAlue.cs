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
    public partial class LisaaAlue : Form
    {
        public LisaaAlue()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
            this.Dispose();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            alueBindingSource8.EndEdit();
            alueTableAdapter.Update(this.vnDataSet);
            alueTableAdapter.Insert(tbUusiAlue.Text);
            this.Close();
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbUusiAlue.Text = "";
           
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {

        }

        private void LisaaAsiakas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void asiakasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbUusiAlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUusiAlue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
