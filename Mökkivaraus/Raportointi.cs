using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mökkivaraus
{
    public partial class Raportointi : Form
    {
        public Raportointi()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=Ruutti");
        MySqlCommand command;

        private void btnEtusivu_Click(object sender, EventArgs e)
        {
            Etusivu es = new Etusivu();
            es.Show();
            this.Hide();
        }

        private void tsmToimintaAlueet_Click(object sender, EventArgs e)
        {
            ToimintaAlueHallinta tah = new ToimintaAlueHallinta();
            tah.Show();
            this.Hide();
        }

        private void tsmPalvelut_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta ph = new PalveluidenHallinta();
            ph.Show();
            this.Hide();
        }

        private void tsmMokki_Click(object sender, EventArgs e)
        {
            MokkienHallinta mh = new MokkienHallinta();
            mh.Show();
            this.Hide();
        }

        private void tsmAsiakasHallinta_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ah = new AsiakasHallinta();
            ah.Show();
            this.Hide();
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi rap = new Raportointi();
            rap.Show();
            this.Hide();
        }

        private void Raportointi_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_Varaus_Loppu.MinDate = dtp_Varaus_Alku.Value;
            dtp_Varaus_Alku.MaxDate = dtp_Varaus_Loppu.Value;
        }
        private void dtp_Varaus_Loppu_ValueChanged(object sender, EventArgs e)
        {

            dtp_Varaus_Loppu.MinDate = dtp_Varaus_Alku.Value;
            dtp_Varaus_Alku.MaxDate = dtp_Varaus_Loppu.Value;

        }

        private void Raportointi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            // TODO: This line of code loads data into the 'vnDataSet.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);
            // TODO: This line of code loads data into the 'vnDataSet.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vnDataSet.varaus);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Taulukon päivitys-osio
        public void populateDGV_Varaukset(string yhtasuuruusJAluku)
        {
            string queryVaraus = "SELECT mokki.mokkinimi, mokki.katuosoite, varaus.varattu_pvm, " +
                "varaus.vahvistus_pvm, varaus.varattu_alkupvm, varaus.varattu_loppupvm, varaus.varaus_id " +
                "FROM mokki, alue, varaus " +
                "WHERE mokki.alue_id = alue.alue_id AND mokki.mokki_id = varaus.mokki_mokki_id AND alue.alue_id" ; // yhtäsuuruus-merkki poistettu
            
            // Uusi yhtasuuruusJAluku muuttuja sisältää yhtäsuuruusmerkin ja luvun
            
            string query = queryVaraus + yhtasuuruusJAluku;
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table3);
            dgvVaraus.DataSource = table3;
        }

        public void populateDGV_Palvelut(string yhtasuuruusJAluku2)
        {
            string queryPalvelu = "SELECT palvelu.nimi, palvelu.tyyppi, varaus.varattu_pvm, varaus.vahvistus_pvm," +
                " varaus.varattu_alkupvm, varaus.varattu_loppupvm " +
                "FROM palvelu, varauksen_palvelut, varaus " +
                "WHERE palvelu.palvelu_id = varauksen_palvelut.palvelu_id AND varauksen_palvelut.varaus_id = varaus.varaus_id AND palvelu.palvelu_id"; // yhtäsuuruus-merkki poistettu

            // Uusi yhtasuuruusJAluku2 muuttuja sisältää yhtäsuuruusmerkin ja luvun

            string query2 = queryPalvelu + yhtasuuruusJAluku2;
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query2, connection);
            adapter.Fill(table2);
            dgvPalvelu.DataSource = table2;
        }


        // SQL lauseiden suoritus
        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Yhteyden avaus
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Yhteys kiinni
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void Alueen_Valinta(object sender, EventArgs e)
        {
            // indeksin haku
            object alue_id = cb_toimintaAlueLista.SelectedValue;
            string luku = "=" + Convert.ToString(alue_id);

            populateDGV_Varaukset(luku);
            
        }

        

        private void PalvelunValinta(object sender, EventArgs e)
        {
            // indeksin haku
            object palvelu_id = cbPalveluLista.SelectedValue;
            string luku2 = "=" + Convert.ToString(palvelu_id);
            populateDGV_Palvelut(luku2);
        }

        private void dtp_Palvelu_Alku_ValueChanged(object sender, EventArgs e)
        {
            dtp_Palvelu_Loppu.MinDate = dtp_Palvelu_Alku.Value;
            dtp_Palvelu_Alku.MaxDate = dtp_Palvelu_Loppu.Value;
        }

        private void dtp_Palvelu_Loppu_ValueChanged(object sender, EventArgs e)
        {
            dtp_Palvelu_Loppu.MinDate = dtp_Palvelu_Alku.Value;
            dtp_Palvelu_Alku.MaxDate = dtp_Palvelu_Loppu.Value;
        }

        private void TaytaCombobox()
        {

        }

        private void btValitseKaikkiTAH_Click(object sender, EventArgs e)
        {
            // valistee kaikki id:t mitkä ovat suurempaa kuin -1, eli kaiken tiedon
            populateDGV_Varaukset(" > -1");
        }

        private void btnValitseKaikkiPalvelut_Click(object sender, EventArgs e)
        {
            // valistee kaikki id:t mitkä ovat suurempaa kuin -1, eli kaiken tiedon
            populateDGV_Palvelut(" > -1");
        }

        private void laskutusbtn_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus();
            this.Hide();
            laskutus.Show();
        }
    }
}
