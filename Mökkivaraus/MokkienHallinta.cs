﻿using System;
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
    public partial class MokkienHallinta : Form
    {
        public MokkienHallinta()
        {
            InitializeComponent();
            tbPostinro.MaxLength = 5;
        }

        private void tsmEtusivu_Click(object sender, EventArgs e)
        {
            Etusivu es = new Etusivu(); // nämä kolme koodiriviä piilottaa
            es.Show();                  // nykyisen ikkunan ja tuo klikatun ikkunan esille
            this.Hide();                // samaa koodia käytetään kaikissa siirtymisnapeissa
        }

        private void tsmToiminta_Click(object sender, EventArgs e)
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

        private void tsmAsiakas_Click(object sender, EventArgs e)
        {
            AsiakasHallinta ah = new AsiakasHallinta();
            ah.Show();
            this.Hide();
        }

        private void MokkienHallinta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vnDataSet.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            this.alueTableAdapter.Fill(this.vnDataSet.alue);

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            var alue = long.Parse(tbAlue.SelectedValue.ToString());
            var postinro = tbPostinro.Text;
            var mokki = tbMokki.Text;
            var katuosoite = tbKatuosoite.Text;
            var hinta = double.Parse(tbHinta.Text);
            var kuvaus = tbKuvaus.Text;
            var hlomaara = int.Parse(tbHlomaara.Text);
            var varustelu = tbVarustelu.Text;
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vnDataSet);
            mokkiTableAdapter.Insert(alue, postinro, mokki, katuosoite, hinta, kuvaus, hlomaara, varustelu);
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            dgvMokki.Refresh();
        }

        private void MokkienHallinta_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
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

        private void tbPoista_Click(object sender, EventArgs e)
        {            
            Validate();
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vnDataSet);            
            mokkiTableAdapter.Delete(long.Parse(tbMokkiID.Text), (long)tbAlue.SelectedValue, tbPostinro.Text, tbMokki.Text, tbKatuosoite.Text, double.Parse(tbHinta.Text), tbKuvaus.Text, int.Parse(tbHlomaara.Text), tbVarustelu.Text);            
            this.mokkiTableAdapter.Fill(this.vnDataSet.mokki);
            dgvMokki.Refresh();
        }

        private void tbPäivitä_Click(object sender, EventArgs e)
        {            
            mokkiBindingSource.EndEdit();
            mokkiTableAdapter.Update(this.vnDataSet.mokki);
        }

        private void tbAlue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
