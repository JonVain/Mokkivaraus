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
    public partial class LisaaPalvelu : Form
    {
        public LisaaPalvelu()
        {
            InitializeComponent();
        }

        private void btn_lisaapalvelu_Click(object sender, EventArgs e)
        {
            try
            {//System.Data.Odbc.OdbcException
                Validate();
                palveluBindingSource.EndEdit();
                palveluTableAdapter.Update(this.vnDataSet);
                palveluTableAdapter.Insert(int.Parse(tbpalvelu_id.Text), int.Parse(tbalue_id.Text), tbnimi.Text, int.Parse(tbtyyppi.Text), tbkuvaus.Text, double.Parse(tbhinta.Text), double.Parse(tbalv.Text));
                this.Close();
            }

            catch (System.Data.Odbc.OdbcException)
            {
                //estetään saman palvelu id:n käytön
                MessageBox.Show("!!!SAMAA PALVELU_ID:TÄ EI SAA KÄYTTÄÄ!!!");
                return;
            }


        }
        //(long.Parse()tbpalvelu_id.Text, tbalue_id.Text, tbnimi.Text, tbtyyppi.Text, tbkuvaus.Text, tbhinta.Text, tbalv.Text);
        //int.Parse(tbhinta.Text)

        private void btn_keskeyta_Click(object sender, EventArgs e)
        {
            this.Dispose(); // sulkee nykyisen ikkunan
        }

        private void btn_tyhjenna_Click(object sender, EventArgs e)
        {
            tbpalvelu_id.Text = "";
            tbalue_id.Text = "";
            tbnimi.Text = "";
            tbtyyppi.Text = "";
            tbkuvaus.Text = "";
            tbhinta.Text = "";
            tbalv.Text = "";
            // puhdistaa tekstilaatikot teksteistään
        }

        private void LisaaPalvelu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
        }

        private void tbhinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että hinnalle ei anneta väärää inputtia
            }
        }


        //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true; //
        //    }

        private void LisaaPalvelu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbalv_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true; // varmistetaan että alue_id:lle ei anneta väärää inputtia
            }
        }

        private void tbpalvelu_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että palvelu_id:lle ei anneta väärää inputtia
            }
        }

        private void tbnimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; // varmistetaan että nimelle ei anneta väärää inputtia
            }
        }

        private void tbtyyppi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // varmistetaan että tyypille ei anneta väärää inputtia
            }
        }

        private void tbkuvaus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; // varmistetaan että kuvaukselle ei anneta väärää inputtia
            }
        }
    }
}
