using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkivaraus
{
    public partial class AsiakasHallinta : Form
    {
        public AsiakasHallinta()
        {
            InitializeComponent();
        }

        private void AsiakasHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);

        }

        private void tsmMokki_Click(object sender, EventArgs e)
        {
            MokkienHallinta mh = new MokkienHallinta();
            mh.Show();
            this.Hide();
        }

        private void tsmEtusivu_Click(object sender, EventArgs e)
        {
            Etusivu es = new Etusivu();
            es.Show();
            this.Hide();
        }

        private void tsmPalvelut_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta ph = new PalveluidenHallinta();
            ph.Show();
            this.Hide();
        }

        private void tsmToiminta_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
            this.Hide();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            LisaaAsiakas la = new LisaaAsiakas();
            la.Show();
        }

        private void AsiakasHallinta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh();
        }
        private void LisaaAsiakas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet);
            asiakasTableAdapter.Delete(long.Parse(tbID.Text), tbPostnro.Text, tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbEmail.Text, tbPuhnro.Text);
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh();
        }

        private void btnPaivitaAsiakas_Click(object sender, EventArgs e)
        {
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet.asiakas);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
