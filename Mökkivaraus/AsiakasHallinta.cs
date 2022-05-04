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
            tbPostnro.MaxLength = 5; // limitoidaan maksimipituus postinumerolle 5:teen
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
            MokkienHallinta mh = new MokkienHallinta(); // nämä kolme koodiriviä piilottaa
            mh.Show();                                  // nykyisen ikkunan ja tuo klikatun ikkunan esille
            this.Hide();                                // samaa koodia käytetään kaikissa siirtymisnapeissa
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
            this.Hide();
        }

        private void AsiakasHallinta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1); // tämä varmistaa sen että ohjelma sulkeutuu jos ikkuna suljetaan
        }

        private void LisaaAsiakas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh(); // päivitetään asiakaslista että uudet tiedot tulevat esille
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet);
            asiakasTableAdapter.Delete(long.Parse(tbID.Text), tbPostnro.Text, tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbEmail.Text, tbPuhnro.Text);
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh(); 
            // tällä koko koodipätkillä poistetaan se nykyinen valittu asiakas
            // jonka jälkeen päivitetään lista että poistettua asiakasta ei enää näy
        }

        private void btnPaivitaAsiakas_Click(object sender, EventArgs e)
        {
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet.asiakas); 
            //Päivitetään valitun henkilön tiedot uusilla syötteillä
        }

        private void tbPostnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true; // ei anneta laittaa muita merkkejä kuin kirjaimia postinumeroon
            }
        }

        private void tbPuhnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // ei anneta laittaa muita merkkejä kuin kirjaimia postinumeroon
            }
        }

        private void AsiakasHallinta_Shown(object sender, EventArgs e)
        {
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            dgvAsiakkaat.Refresh(); // päivitetään asiakaslista että uudet tiedot tulevat esille
        }

        private void btnLaskutus_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus();
            this.Hide();
            laskutus.Show();
        }
    }
}
