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
            tbPostinumero.MaxLength = 5; // postinumerolle limitoitu pituus
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ah = new AsiakasHallinta(); // nämä kolme koodiriviä piilottaa
            ah.Show();                                  // nykyisen ikkunan ja tuo klikatun ikkunan esille
            this.Dispose();                             // samaa koodia käytetään kaikissa siirtymisnapeissa
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Validate();
            asiakasBindingSource.EndEdit();
            asiakasTableAdapter.Update(this.vnDataSet);
            asiakasTableAdapter.Insert(tbPostinumero.Text, tbEtunimi.Text, tbSukunimi.Text, tbOsoite.Text, tbEmail.Text, tbPuhnro.Text);
            this.Close();
            AsiakasHallinta ah = new AsiakasHallinta();
            ah.Show();
            // tällä lisätään tietokantaan ja datagrid listaan asiakas tietoineen.
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbPostinumero.Text = "";
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbOsoite.Text = "";
            tbEmail.Text = "";
            tbPuhnro.Text = "";
            // napilla voidaan nopeasti tyhjentää kaikki laatikot tiedoistaan
        }

        private void LisaaAsiakas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
        }

        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // varmistetaan että postinumerolle ei annetaa väärää inputtia
            }
        }

        private void tbPuhnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // varmistetaan että puhelinnumerolle ei anneta väärää inputtia
            }
        }
    }
}
