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
    public partial class Etusivu : Form
    {
        public Etusivu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vnDataSet.lasku);
            // TODO: This line of code loads data into the 'vnDataSet.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);

        }

        private void tsmToimintaAlueet_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
            this.Hide();
        }

        private void tsmPalvelut_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta ph = new PalveluidenHallinta();
            ph.Show();
            this.Hide();
        }


        private void tsmMokki_Click(object sender, EventArgs e)
        {
            MokkienHallinta mh = new MokkienHallinta();
            mh.Show();
            this.Hide();
        }

        private void tsmAsiakasHallinta_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ah = new AsiakasHallinta();
            ah.Show();
            this.Hide();
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi rap = new Raportointi();
            rap.Show();
            this.Hide();
        }

        private void Etusivu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void laskutusbtn_Click(object sender, EventArgs e)
        {
            Laskutus lks = new Laskutus();
            lks.Show();
            this.Hide();
        }
    }
}
