using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obssistemi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnogretmenler_Click(object sender, EventArgs e)
        {
            ogretmen git = new ogretmen();
            git.Show();
            this.Hide();
        }
        private void btnogrenciler_Click(object sender, EventArgs e)
        {
            ogrenci git = new ogrenci();
            git.Show();
            this.Hide();
        }
        private void btndersler_Click(object sender, EventArgs e)
        {
            dersler git = new dersler();
            git.Show();
            this.Hide();
        }
        private void btnnotlar_Click(object sender, EventArgs e)
        {
            notlar git = new notlar();
            git.Show();
            this.Hide();
        }
        private void btnbolumler_Click(object sender, EventArgs e)
        {
            bolumler git = new bolumler();
            git.Show();
            this.Hide();
        }
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            xmlislemleri git = new xmlislemleri();
            git.Show();
            this.Hide();
        }      
    }
}
