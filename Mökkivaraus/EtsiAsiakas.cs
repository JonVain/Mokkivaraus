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
    public partial class EtsiAsiakas : Form
    {        
        Laskutus laskutus = null;
        public EtsiAsiakas(Laskutus laskutus)
        {
            InitializeComponent();
            this.laskutus = laskutus;
        }

        private void EtsiAsiakas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            // TODO: This line of code loads data into the 'vnDataSet.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vnDataSet.lasku);

        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            this.Hide(); // piilotetaan nykyinen ikkuna
            laskutus.Show(); // laskutus ikkuna tuodaan takaisin näkyville
            laskutus.EtsiLaskut(int.Parse(asiakasID.Text)); // etsitään asiakkaan laskut tietokannasta 
        }
    }
}
