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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ToimintaAlueLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // indeksin haku
            object alue_id = cb_toimintaAlueLista.SelectedValue;
            int luku =  Convert.ToInt32(alue_id);

            populateDGV(luku);
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
            System.Environment.Exit(1);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLisaaAlue_Click(object sender, EventArgs e)
        {
            LisaaAlue ikkuna_alue = new LisaaAlue();
            ikkuna_alue.FormClosed += new FormClosedEventHandler(LisaaAlue_FormClosed);
            ikkuna_alue.Show();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbToimintaA_Click(object sender, EventArgs e)
        {

        }

        private void tbPaivitaAlueTaulukko_Click(object sender, EventArgs e)
        {
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh();
        
        }


        private void LisaaAlue_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh();
        }

        private void btnPoistaAlueTaulukosta_Click(object sender, EventArgs e)
        {
            Validate();
            alueBindingSource.EndEdit();
            alueTableAdapter.Delete(long.Parse(tb_id.Text), tb_nimi.Text);
            this.alueTableAdapter.Fill(this.vnDataSet.alue);
            dgvAlueet.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAlueetCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btPaivitaToimintaAlue_Click(object sender, EventArgs e)
        {
            Validate();
            alueBindingSource.EndEdit();
            alueTableAdapter.Update(this.vnDataSet);
        }

        private void dgvAlueet_MouseClick(object sender, MouseEventArgs e)
        {
            //tb_id.Text = dgvAlueet.CurrentRow.Cells[0].Value.ToString();
            //tb_nimi.Text = dgvAlueet.CurrentRow.Cells[1].Value.ToString();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }  
        }
    }
}
