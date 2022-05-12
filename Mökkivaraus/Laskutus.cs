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


        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;Password=Ruutti");
        MySqlCommand command;

        public Laskutus()
        {
            InitializeComponent();
        }

        private void Laskutus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            // TODO: This line of code loads data into the 'vnDataSet.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vnDataSet.asiakas);
            // TODO: This line of code loads data into the 'vnDataSet.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vnDataSet.lasku);
            this.palveluTableAdapter.Fill(this.vnDataSet.palvelu);

            populateDGV();
            
            TaytaPalvelut();
        }

        private void TaytaPalvelut() //checklistbox täyttö tietokannasta
        {
            var mokki = (DataRowView)cbMokki.SelectedItem;
            long alueid = (long)mokki["alue_id"];
            clbPalvelut.Items.Clear();
            palveluBindingSource.Filter = $"alue_id = {alueid}";
            foreach (var palvelu in palveluBindingSource.List)
            {
                var rivi = (DataRowView)palvelu;
                var data = new PalveluStruct() {
                    alueid = alueid,
                    nimi = (string)rivi["nimi"],
                    palveluid = (long)rivi["palvelu_id"]
                };              
                clbPalvelut.Items.Add(data);
            }
        }
        private struct PalveluStruct
        {
            public long alueid;
            public string nimi;
            public long palveluid;
            public override string ToString()
            {
                return nimi;
            }
        }

        private List<PalveluStruct> KeraaPalvelut()
        {            
            List<PalveluStruct> valitutpalvelut = new List<PalveluStruct>();
            foreach (var palvelu in clbPalvelut.CheckedItems)
            {                
                var p = (PalveluStruct)palvelu;
                valitutpalvelut.Add(p);
            }            
            return valitutpalvelut;
        }

        private void etsiasiakasBtn_Click(object sender, EventArgs e)
        {
            EtsiAsiakas etsias = new EtsiAsiakas(this);
            etsias.Show(); // tuo esille asiakkaan valinnan
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

        private void btnLisaaVaraus_Click(object sender, EventArgs e)
        {
            Validate();
            mokkiBindingSource.EndEdit();
            asiakasBindingSource.EndEdit();
            object asiakas_id = cbAsiakas.SelectedValue;
            int asiakas = Convert.ToInt32(asiakas_id);
            object mokki_id = cbMokki.SelectedValue;
            int mokki = Convert.ToInt32(mokki_id);
            varausTableAdapter1.Update(this.vnDataSet);
            if (rbSahko.Checked)
            {
                if (cbMaksettu.Checked)
                {
                    varausTableAdapter1.Insert(asiakas, mokki, DateTime.Now, DateTime.Now, dtpAlku.Value, dtpLoppu.Value, "Maksettu", "Sähköposti");
                }
                else
                {
                    varausTableAdapter1.Insert(asiakas, mokki, DateTime.Now, DateTime.Now, dtpAlku.Value, dtpLoppu.Value, "Ei maksettu", "Sähköposti");
                }
            }
            else if (rbPaperi.Checked)
            {
                if (cbMaksettu.Checked)
                {
                    varausTableAdapter1.Insert(asiakas, mokki, DateTime.Now, DateTime.Now, dtpAlku.Value, dtpLoppu.Value, "Maksettu", "Paperi");
                }
                else
                {
                    varausTableAdapter1.Insert(asiakas, mokki, DateTime.Now, DateTime.Now, dtpAlku.Value, dtpLoppu.Value, "Ei maksettu", "Paperi");
                }
            }
            var varausid = varausTableAdapter1.GetData().Count();
            laskuTableAdapter.Insert(varausid, 24, int.Parse(tbHinta.Text));            
            populateDGV();
            var palvelut = KeraaPalvelut();
            foreach (var palvelu in palvelut) {
                varauksen_palvelutTableAdapter1.Insert(varausid, palvelu.palveluid, 1);
            }
        }

        private void Laskutus_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1); // tämä varmistaa sen että ohjelma sulkeutuu jos ikkuna suljetaan
        }

        public void populateDGV()
        {
            string query1 = "SELECT asiakas.etunimi, asiakas.sukunimi, asiakas.email, lasku.summa, lasku.alv, varaus.maskun_tila AS maksun_tila, varaus.laskun_muoto " +
                "FROM lasku, varaus, asiakas " +
                "WHERE lasku.varaus_id = varaus.varaus_id AND varaus.asiakas_id = asiakas.asiakas_id ";
            string query = query1;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
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

        private void dtpAlku_ValueChanged(object sender, EventArgs e)
        {
            dtpLoppu.MinDate = dtpAlku.Value; // limitoidaan väärän inputin anto 
            dtpAlku.MaxDate = dtpLoppu.Value; // että se ei ole mahdollista
        }

        private void dtpLoppu_ValueChanged(object sender, EventArgs e)
        {
            dtpLoppu.MinDate = dtpAlku.Value; // limitoidaan väärän inputin anto 
            dtpAlku.MaxDate = dtpLoppu.Value; // että se ei ole mahdollista
        }

        private void tbHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // varmistetaan että hinnalle ei anneta väärää inputtia
            }
        }

        private void clbPalvelut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMokki_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaytaPalvelut();
        }
    }
}