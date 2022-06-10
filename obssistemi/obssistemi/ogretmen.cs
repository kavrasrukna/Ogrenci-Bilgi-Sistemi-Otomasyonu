using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;
using ObsLayer;

namespace obssistemi
{
    public partial class ogretmen : Form
    {
        public ogretmen()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            List<EOgretmen> ogretmenlistele = BLOgretmen.Listele();
            dataGridView1.DataSource = ogretmenlistele;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            EOgretmen ekleme = new EOgretmen();
            ekleme.ogretmen_adi = txtogretmenadi.Text;
            ekleme.ogretmen_soyadi = txtogretmensoyadi.Text;
            ekleme.ogretmen_brans = txtbrans.Text;
            if (BLOgretmen.Ekleme(ekleme) > 0) //verinin eklenip eklenmediğini kontrol ediyoruz >0 ise veri eklenmiştir değise eklenmemiştir
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
            Liste();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Liste();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtogretmenadi.Tag = row.Cells["ogretmen_id"].Value;
            txtogretmenadi.Text = row.Cells["ogretmen_adi"].Value.ToString();
            txtogretmensoyadi.Text = row.Cells["ogretmen_soyadi"].Value.ToString();
            txtbrans.Text = row.Cells["ogretmen_brans"].Value.ToString();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EOgretmen k = new EOgretmen();
            k.ogretmen_id = (int)txtogretmenadi.Tag;
            k.ogretmen_adi = txtogretmenadi.Text;
            k.ogretmen_soyadi = txtogretmensoyadi.Text;
            k.ogretmen_brans = txtbrans.Text;
            if (FOgretmen.Guncelle(k))
            {
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }
            Liste();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            EOgretmen k = new EOgretmen();
            k.ogretmen_id = (int)dataGridView1.CurrentRow.Cells["ogretmen_id"].Value;

            if (FOgretmen.Sil(k))
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }
            Liste();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            EOgretmen aa = new EOgretmen();
            aa.ogretmen_adi = txtogretmenadi.Text;
            aa.ogretmen_brans = txtbrans.Text;
            dataGridView1.DataSource = FOgretmen.Ara(aa);
        }
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
    }
}
