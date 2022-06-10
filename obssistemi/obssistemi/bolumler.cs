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
    public partial class bolumler : Form
    {
        public bolumler()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            List<EBolum> bolumlistele = BLBolum.Listele();
            dataGridView1.DataSource = bolumlistele;
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

        private void bolumler_Load(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            EBolum ekleme = new EBolum();
            ekleme.bolum_adi = txtbolumadi.Text;
            ekleme.ogrencisayisi = Convert.ToInt32(txtogrencisayisi.Text);
            if (BLBolum.Ekleme(ekleme) > 0) //verinin eklenip eklenmediğini kontrol ediyoruz >0 ise veri eklenmiştir değise eklenmemiştir
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
            txtbolumadi.Tag = row.Cells["bolum_id"].Value;
            txtbolumadi.Text = row.Cells["bolum_adi"].Value.ToString();
            txtogrencisayisi.Text = row.Cells["ogrencisayisi"].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EBolum k = new EBolum();
            k.bolum_id = (int)txtbolumadi.Tag;
            k.bolum_adi = txtbolumadi.Text;
            k.ogrencisayisi = Convert.ToInt32(txtogrencisayisi.Text);
            if (FBolum.Guncelle(k))
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
            EBolum k = new EBolum();
            k.bolum_id = (int)dataGridView1.CurrentRow.Cells["bolum_id"].Value;

            if (FBolum.Sil(k))
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }
            Liste();
        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            EBolum aa = new EBolum();//entitydeki ad
            aa.bolum_adi = txtbolumadi.Text;
            dataGridView1.DataSource = FBolum.Ara(aa);//facade daki ad
        }
    }
}
