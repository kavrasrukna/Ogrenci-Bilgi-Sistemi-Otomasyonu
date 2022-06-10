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
    public partial class dersler : Form
    {
        public dersler()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            List<EDers> derslistele = BLDers.Listele();
            dataGridView1.DataSource = derslistele;
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
            EDers ekleme = new EDers();
            ekleme.ders_adi = txtdersadi.Text;
            ekleme.ogretmen_id = Convert.ToInt32(txtogretmenid.Text);
            if (BLDers.Ekleme(ekleme) > 0) //verinin eklenip eklenmediğini kontrol ediyoruz >0 ise veri eklenmiştir değise eklenmemiştir
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
            Liste();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtdersadi.Tag = row.Cells["ders_id"].Value;
            txtdersadi.Text = row.Cells["ders_adi"].Value.ToString();
            txtogretmenid.Text = row.Cells["ogretmen_id"].Value.ToString();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EDers k = new EDers();
            k.ders_id = (int)txtdersadi.Tag;
            k.ders_adi = txtdersadi.Text;
            k.ogretmen_id =Convert.ToInt32(txtogretmenid.Text);
            if (FDers.Guncelle(k))
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
            EDers k = new EDers();
            k.ders_id = (int)dataGridView1.CurrentRow.Cells["ders_id"].Value;

            if (FDers.Sil(k))
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
            EDers aa = new EDers();
            aa.ders_adi = txtdersadi.Text;
            dataGridView1.DataSource = FDers.Ara(aa);
        }
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}
