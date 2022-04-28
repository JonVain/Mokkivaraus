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
    public partial class PalveluidenHallinta : Form
    {
        public PalveluidenHallinta()
        {
            InitializeComponent();
        }

        private void tsmToimintaAlueet_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
            this.Hide();
        }

        private void tsmEtusivu_Click(object sender, EventArgs e)
        {
            Etusivu es = new Etusivu();
            es.Show();
            this.Hide();
        }

        private void tsmAsiakas_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ah = new AsiakasHallinta();
            ah.Show();
            this.Hide();
        }

        private void tsmMokki_Click(object sender, EventArgs e)
        {
            MokkienHallinta mh = new MokkienHallinta();
            mh.Show();
            this.Hide();
        }

        private void PalveluidenHallinta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void PalveluidenHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);

        }

        private void Btn_plvlisaa_Click(object sender, EventArgs e)
        {
            LisaaPalvelu lp = new LisaaPalvelu();
            lp.Show();
        }

        private void btn_paivita_Click(object sender, EventArgs e)
        {
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh();
        }
        private void LisaaPalvelu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh();
        }

        private void Btn_plvpoista_Click(object sender, EventArgs e)
        {
            Validate();
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vnDataSet);
            palveluTableAdapter.Delete(int.Parse(tbpalvelu_id.Text), int.Parse(tbalue_id.Text), tbnimi.Text, int.Parse(tbtyyppi.Text), tbkuvaus.Text, double.Parse(tbhinta.Text), double.Parse(tbalvi.Text));
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vnDataSet.palvelu);
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi rap = new Raportointi();
            rap.Show();
            this.Hide();
        }
    }
}
