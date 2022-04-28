using MySql.Data.MySqlClient;
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
    public partial class Laskutus : Form
    {
        public Laskutus()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=Ruutti");

        private void Laskutus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            // TODO: This line of code loads data into the 'vnDataSet.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vnDataSet.lasku);
        }

        private void etsiasiakasBtn_Click(object sender, EventArgs e)
        {
            EtsiAsiakas etsias = new EtsiAsiakas(this);
            etsias.Show();
        }        

        private void button5_Click(object sender, EventArgs e) // etusivu nappi
        {
            Etusivu ets = new Etusivu();
            this.Hide();
            ets.Show();
        }

        private void mokkienhallinta_Click(object sender, EventArgs e)
        {
            MokkienHallinta mh = new MokkienHallinta();
            this.Hide();
            mh.Show();
        }

        private void asiakashallintabtn_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ash = new AsiakasHallinta();
            this.Hide();
            ash.Show();
        }

        private void toimintahbtn_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            this.Hide();
            tah.Show();
        }

        private void palveluhallintabtn_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta ph = new PalveluidenHallinta();
            this.Hide();
            ph.Show();
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi raportointi = new Raportointi();
            this.Hide();
            raportointi.Show();
        }

        private void laskutusbtn_Click(object sender, EventArgs e)
        {

        }
        public void EtsiLaskut(int asiakasid) // valitaan rivi ja tuodaan gridviewiin.
        {            
            string queryLaskut = "SELECT lasku.lasku_id, lasku.varaus_id, lasku.summa, lasku.alv " +
                "FROM lasku " +
                "LEFT JOIN varaus ON varaus.varaus_id = lasku.varaus_id " + 
                "WHERE varaus.asiakas_id = ";            

            string query = queryLaskut + asiakasid;
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table3);
            laskuBindingSource.DataSource = table3;
            int index = asiakasBindingSource.Find("asiakas_id", asiakasid);
            if (index >= 0) asiakasBindingSource.Position = index;
        }
    }
}
