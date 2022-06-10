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
    public partial class notlar : Form
    {
        public notlar()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            List<ENot> notlistele = BLNot.Listele();
            dataGridView1.DataSource = notlistele;
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
            ENot ekleme = new ENot();
            ekleme.ders_id = Convert.ToInt32(txtdersid.Text);
            ekleme.ogrenci_no = Convert.ToInt32(txtogrencino.Text);
            ekleme.vize = Convert.ToInt32(txtvize.Text);
            ekleme.final = Convert.ToInt32(txtfinal.Text);
            ekleme.ortalama = Convert.ToInt32(txtortalama.Text);
            ekleme.durum = comboBox1.Text;
            if (BLNot.Ekleme(ekleme) > 0) //verinin eklenip eklenmediğini kontrol ediyoruz >0 ise veri eklenmiştir değise eklenmemiştir
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenmedi");
            }
            Liste();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ENot k = new ENot();
            k.not_id = (int)txtdersid.Tag;
            k.ders_id = Convert.ToInt32(txtdersid.Text);
            k.ogrenci_no = Convert.ToInt32(txtogrencino.Text);
            k.vize = Convert.ToInt32(txtvize.Text);
            k.final = Convert.ToInt32(txtfinal.Text);
            k.ortalama = Convert.ToInt32(txtortalama.Text);
            k.durum = comboBox1.Text;
            if (FNot.Guncelle(k))
            {
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtdersid.Tag = row.Cells["not_id"].Value;
            txtdersid.Text = row.Cells["ders_id"].Value.ToString();
            txtogrencino.Text = row.Cells["ogrenci_no"].Value.ToString();
            txtvize.Text = row.Cells["vize"].Value.ToString();
            txtfinal.Text = row.Cells["final"].Value.ToString();
            txtortalama.Text = row.Cells["ortalama"].Value.ToString();
            comboBox1.Text = row.Cells["durum"].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            ENot k = new ENot();
            k.not_id = (int)dataGridView1.CurrentRow.Cells["not_id"].Value;

            if (FNot.Sil(k))
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
            ENot nn = new ENot();
            nn.ders_id = Convert.ToInt32(txtdersid.Text);
           
            nn.ogrenci_no = Convert.ToInt32(txtogrencino.Text);
            nn.durum = comboBox1.Text;
            dataGridView1.DataSource = FNot.Ara(nn);
        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
    }
}
