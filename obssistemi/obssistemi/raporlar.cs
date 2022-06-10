using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facade;//Kütüphanemizi ekledik facadedaki prosedürü çağırabilmek için

namespace obssistemi
{
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
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

        private void button15_Click(object sender, EventArgs e)
        {
            /*Öğrencileri bölümlerine göre grupla ve sayılarını listele*/
            dataGridView1.DataSource = FOgrenci.Listele1();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*Bölümü "BÖTE" olan öğrencileri listele*/
            dataGridView1.DataSource = FOgrenci.Listele2();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*"Programlama Dilleri 1" dersini veren öğretmenin bilgileri*/
            dataGridView1.DataSource = FOgrenci.Listele3();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*Branşı "Bilgisayar" olan öğretmenlerin verdiği dersleri listele*/
            dataGridView1.DataSource = FOgrenci.Listele4();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*Branşı "Matematik" olan öğretmenleri listele*/
            dataGridView1.DataSource = FOgrenci.Listele5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Öğrenci sayısı 30'un altında olan bölümleri listele*/
            dataGridView1.DataSource = FOgrenci.Listele6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*Durumu "kaldı" olan öğrencilerin bölüm,ders ve not bilgilerini listele*/
            dataGridView1.DataSource = FOgrenci.Listele7();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*"Ayşe Çetin" adlı öğrencinin bölüm,ders ve not bilgilerini listele*/
            dataGridView1.DataSource = FOgrenci.Listele8();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*Ortalaması 65'in altında olan öğrencilerin ders,bölüm ve not bilgilerini listele*/
            dataGridView1.DataSource = FOgrenci.Listele9();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*Dersin vize sınavına girip final sınavına girmeyen öğrencilerin bölüm, ders ve not bilgileri*/
            dataGridView1.DataSource = FOgrenci.Listele10();
        }
    }
}
