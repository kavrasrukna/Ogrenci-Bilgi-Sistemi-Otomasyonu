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
    public partial class ogrenci : Form
    {
        public ogrenci()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            List<EOgrenci> ogrencilistele = BLOgrenci.Listele();
            dataGridView1.DataSource = ogrencilistele;
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
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Liste();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            EOgrenci ekleme = new EOgrenci();
            ekleme.ogrenci_adi = txtogrenciadi.Text;
            ekleme.ogrenci_soyadi = txtogrencisoyadi.Text;
            ekleme.bolum_id = Convert.ToInt32(txtbolumid.Text);
            if (BLOgrenci.Ekleme(ekleme) > 0) //verinin eklenip eklenmediğini kontrol ediyoruz >0 ise veri eklenmiştir değise eklenmemiştir
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
            txtogrencino.Text = row.Cells["ogrenci_no"].Value.ToString();
            txtogrenciadi.Text = row.Cells["ogrenci_adi"].Value.ToString();
            txtogrencisoyadi.Text = row.Cells["ogrenci_soyadi"].Value.ToString();
            txtbolumid.Text = row.Cells["bolum_id"].Value.ToString();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EOgrenci k = new EOgrenci();
            k.ogrenci_no = Convert.ToInt32(txtogrencino.Text);
            k.ogrenci_adi = txtogrenciadi.Text;
            k.ogrenci_soyadi = txtogrencisoyadi.Text;
            k.bolum_id =Convert.ToInt32(txtbolumid.Text);
            if (FOgrenci.Guncelle(k))
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
            EOgrenci k = new EOgrenci();
            k.ogrenci_no = (int)dataGridView1.CurrentRow.Cells["ogrenci_no"].Value;

            if (FOgrenci.Sil(k))
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
            EOgrenci aa = new EOgrenci();
            aa.ogrenci_no = Convert.ToInt32(txtogrencino.Text); 
            aa.ogrenci_adi = txtogrenciadi.Text;
            dataGridView1.DataSource = FOgrenci.Ara(aa);
        }
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
    }
}
