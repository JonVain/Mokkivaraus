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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void palveluBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void PalveluidenHallinta_Shown(object sender, EventArgs e)
        {
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            dgvPalvelut.Refresh(); // päivitetään asiakaslista että uudet tiedot tulevat esille
        }

        private void dgvPalvelut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPalvelut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbpalvelu_id.DataBindings.Count > 0)
                tbpalvelu_id.DataBindings.RemoveAt(0);
            if (tbalue_id.DataBindings.Count > 0)
                tbalue_id.DataBindings.RemoveAt(0);
            if (tbnimi.DataBindings.Count > 0)
                tbnimi.DataBindings.RemoveAt(0);
            if (tbtyyppi.DataBindings.Count > 0)
                tbtyyppi.DataBindings.RemoveAt(0);
            if (tbkuvaus.DataBindings.Count > 0)
                tbkuvaus.DataBindings.RemoveAt(0);
            if (tbhinta.DataBindings.Count > 0)
                tbhinta.DataBindings.RemoveAt(0);
            if (tbalvi.DataBindings.Count > 0)
                tbalvi.DataBindings.RemoveAt(0);

            // The code binds column index 2 to the TextBox control
            tbpalvelu_id.DataBindings.Add(
                new Binding("Text", dgvPalvelut[0, e.RowIndex], "Value", false));
            tbalue_id.DataBindings.Add(
                new Binding("Text", dgvPalvelut[1, e.RowIndex], "Value", false));
            tbnimi.DataBindings.Add(
                new Binding("Text", dgvPalvelut[2, e.RowIndex], "Value", false));
            tbtyyppi.DataBindings.Add(
                new Binding("Text", dgvPalvelut[3, e.RowIndex], "Value", false));
            tbkuvaus.DataBindings.Add(
                new Binding("Text", dgvPalvelut[4, e.RowIndex], "Value", false));
            tbhinta.DataBindings.Add(
                new Binding("Text", dgvPalvelut[5, e.RowIndex], "Value", false));
            tbalvi.DataBindings.Add(
                new Binding("Text", dgvPalvelut[6, e.RowIndex], "Value", false));
        }

        private void tbpalvelu_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }

        private void tbalue_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }

        private void tbnimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }

        private void tbtyyppi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }

        private void tbkuvaus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }

        private void tbhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että hinnalle ei anneta väärää inputtia
            }
        }

        private void tbalvi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että arvolisäverolle ei anneta väärää inputtia
            }
        }
    }
}
