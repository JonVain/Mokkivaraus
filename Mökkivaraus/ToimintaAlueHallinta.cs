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
    public partial class ToimintaAlueHallinta : Form
    {
        public ToimintaAlueHallinta()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=Ruutti");
        MySqlCommand command;

        private void tsmEtusivu_Click(object sender, EventArgs e)
        {
            Etusivu es = new Etusivu(); // nämä kolme koodiriviä piilottaa
            es.Show();                  // nykyisen ikkunan ja tuo klikatun ikkunan esille
            this.Hide();                // samaa koodia käytetään kaikissa siirtymisnapeissa
        }

        private void tsmPalvelut_Click(object sender, EventArgs e)
        {
            PalveluidenHallinta ph = new PalveluidenHallinta();
            ph.Show();
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

        private void ToimintaAlueHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            // TODO: This line of code loads data into the 'vnDataSet.alue' table. You can move, or remove it, as needed.
            this.alueTableAdapter.Fill(this.vnDataSet.alue);

        }

        private void ToimintaAlueLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // indeksin haku
            object alue_id = cb_toimintaAlueLista.SelectedValue;
            int luku =  Convert.ToInt32(alue_id);

            populateDGV(luku);

            if (gridMokkiTaulukko.RowCount <= 1)
                btnPoistaAlueTaulukosta.Enabled = true;
            else
                btnPoistaAlueTaulukosta.Enabled = false;
        }


        // Taulukon päivitys-osio
        public void populateDGV(int luku)
        {
            string query1 = "SELECT * FROM mokki WHERE alue_id=";
            string query = query1 + luku;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            gridMokkiTaulukko.DataSource = table;
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

        private void ToimintaAlueHallinta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1); // tämä varmistaa sen että ohjelma sulkeutuu jos ikkuna suljetaan
        }

        private void btnLisaaAlue_Click(object sender, EventArgs e)
        {
            LisaaAlue ikkuna_alue = new LisaaAlue();
            ikkuna_alue.FormClosed += new FormClosedEventHandler(LisaaAlue_FormClosed);
            ikkuna_alue.Show();
            this.Hide(); 
            // aukaistaan alueen lisäys ikkuna ja piilotetaan nykyinen
        }

        private void tbPaivitaAlueTaulukko_Click(object sender, EventArgs e)
        {
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh(); // päivitetään alueet taulukko
        }

        private void LisaaAlue_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh(); // päivitetään alueet taulukko
        }

        private void btnPoistaAlueTaulukosta_Click(object sender, EventArgs e)
        {
            Validate();
            alueBindingSource.EndEdit();
            alueTableAdapter.Delete(long.Parse(tb_id.Text), tb_nimi.Text);
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh(); 
            // poistetaan nykyinen valinta taulukosta
        }

        private void btPaivitaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            alueBindingSource.EndEdit();
            alueTableAdapter.Update(this.vnDataSet);
            //Päivitetään toiminta alue tiedot annetuilla tiedoilla
        }

        private void dgvAlueet_MouseClick(object sender, MouseEventArgs e)
        {
            //tb_id.Text = dgvAlueet.CurrentRow.Cells[0].Value.ToString();
            //tb_nimi.Text = dgvAlueet.CurrentRow.Cells[1].Value.ToString();
        }

        private void tb_nimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // ei anneta pistää väärää inputtia
            }  
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportointi rap = new Raportointi();
            rap.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus();
            this.Hide();
            laskutus.Show();
        }
    }
}