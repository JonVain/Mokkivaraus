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
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta(); // nämä kolme koodiriviä piilottaa
            tah.Show();                                            // nykyisen ikkunan ja tuo klikatun ikkunan esille
            this.Hide();                                           // samaa koodia käytetään kaikissa siirtymisnapeissa
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
            System.Environment.Exit(1); // tämä varmistaa sen että ohjelma sulkeutuu jos ikkuna suljetaan
        }

        private void PalveluidenHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);

        }

        private void Btn_plvlisaa_Click(object sender, EventArgs e)
        {
            LisaaPalvelu lp = new LisaaPalvelu();
            lp.Show(); // tuodaan palvelun lisäys ikkuna näkyville
        }

        private void btn_paivita_Click(object sender, EventArgs e)
        {
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh(); // päivitetään palvelut lista
        }
        private void LisaaPalvelu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh(); // päivitetään palvelut lista
        }

        private void Btn_plvpoista_Click(object sender, EventArgs e)
        {
            Validate();
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vnDataSet);
            palveluTableAdapter.Delete(int.Parse(tbpalvelu_id.Text), int.Parse(tbalue_id.Text), tbnimi.Text, int.Parse(tbtyyppi.Text), tbkuvaus.Text, double.Parse(tbhinta.Text), double.Parse(tbalvi.Text));
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh(); // poistetaan valittu palvelu ja päivitetään lista
        }

        private void button6_Click(object sender, EventArgs e)
        {
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vnDataSet.palvelu); // päivitetään valittua uusilla tiedoilla
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi rap = new Raportointi();
            rap.Show();
            this.Hide();
        }

        private void laskutusbtn_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus();
            this.Hide();
            laskutus.Show();
        }
    }
}
