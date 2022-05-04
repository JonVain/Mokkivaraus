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
            Validate();
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vnDataSet);
            palveluTableAdapter.Insert(int.Parse(tbpalvelu_id.Text),int.Parse(tbalue_id.Text),tbnimi.Text,int.Parse(tbtyyppi.Text),tbkuvaus.Text,double.Parse(tbhinta.Text),double.Parse(tbalv.Text) );
            this.Close();
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
    }
}
