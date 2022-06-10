using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//ekledik
using System.Xml.Linq;//ekledik

namespace obssistemi
{
    public partial class bolumcrud : Form
    {
        public bolumcrud()
        {
            InitializeComponent();
        }
        void yukle()
        {
            XmlDocument i = new XmlDocument(); //var olan bir dosya ile çalışacaksam nesne böyle üretilir.
            DataSet ds = new DataSet();
            //xml dosyasını okumak için bir reader oluşturuyoruz.
            XmlReader XmlFile;
            XmlFile = XmlReader.Create(@"bolumobs.xml", new XmlReaderSettings());
            //readerin içine pathini verdiğimiz dosyayı dolduruyoruz.Burada önemli olan bir nokta var ya pathimizin başına @ yazacağız çift tırnak kullanacağız.
            ds.ReadXml(XmlFile); //içeriği datasete aktarıyoruz
            dataGridView2.DataSource = ds.Tables[0];   //gridviewin kaynağı olarak dataseti gösteriyoruz.
            XmlFile.Close();
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
        private void button4_Click(object sender, EventArgs e)
        {
            yukle();
        }
        private void button1_Click(object sender, EventArgs e)
        {//ekle
            XDocument x = XDocument.Load(@"bolumobs.xml"); //ossistemi klasörü içinde bin debug klasörü altında bolumobs.xml adlı dosya oluşturdu
            x.Element("bolumler").Add(new XElement("bolum", new XElement("bolumid", textBox1.Text),
                new XElement("bolumadi", txtbolumadi.Text),
                new XElement("ogrencisayisi", txtogrencisayisi.Text)));
            x.Save(@"bolumobs.xml");
            yukle();
        }
        private void button2_Click(object sender, EventArgs e)
        {//sil
            XDocument x = XDocument.Load(@"bolumobs.xml");
            //id=textbox'a girilen numaraya göre öğrenciyi siler
            x.Root.Elements().Where(a => a.Element("bolumid").Value == textBox1.Text).Remove(); //=>lambda işareti=> a değişken aslında idsine göre o çatının altındaki tüm satırı sil
            x.Save(@"bolumobs.xml");
            yukle();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //güncelle
            XDocument x = XDocument.Load(@"bolumobs.xml");
            XElement node = x.Element("bolumler").Elements("bolum").FirstOrDefault(a => a.Element("bolumid").Value.Trim() == textBox1.Text);
            //trim boşluk hassasiyetini ortadan kaldırır. ilk bulduğu boşta çalışır. bu boşlukları kaldırır
            if (node != null)
            {
                node.SetElementValue("bolumadi", txtbolumadi.Text);
                node.SetElementValue("ogrencisayisi", txtogrencisayisi.Text);
                x.Save(@"bolumobs.xml");
                yukle();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridden textlere veri çekme
            DataGridViewRow satir = dataGridView2.CurrentRow;
            textBox1.Text = satir.Cells["bolumid"].Value.ToString();
            txtbolumadi.Text = satir.Cells["bolumadi"].Value.ToString();
            txtogrencisayisi.Text = satir.Cells["ogrencisayisi"].Value.ToString();
        }
    }
}
