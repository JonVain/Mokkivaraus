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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSalasana_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalasana_Click(object sender, EventArgs e)
        {
            if (txtTunnus.Text == "admin" && txtSalasana.Text == "admin" || txtTunnus.Text == "testi" && txtSalasana.Text == "1234")
            {                
                Etusivu es = new Etusivu();
                es.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tunnus tai salasana väärin, yritä uudestaan.");
                txtTunnus.Clear();
                txtSalasana.Clear();
                txtTunnus.Focus();
            }
            }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
