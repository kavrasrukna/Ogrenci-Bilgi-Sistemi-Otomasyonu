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
using System.Data.SqlClient;//ekledik
namespace obssistemi
{
    public partial class xmlislemleri : Form
    {
        public xmlislemleri()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlElement root = xdoc.CreateElement("Bolumler"); //başlangıç ve bitiş değeri dosyada <Bolumler>...</Bolumler> şeklinde

            SqlConnection baglanti = new SqlConnection("server=.; database=OBS; Integrated Security=true;");
            SqlCommand tedkom = new SqlCommand("select*from Bolumler", baglanti);
            baglanti.Open();
            SqlDataReader oku = tedkom.ExecuteReader();
            while (oku.Read())
            {
                XmlElement bolum = xdoc.CreateElement("Bolumsayfasi");//bunun adına herhangi bir şey verebiliriz

                XmlAttribute bolumadi = xdoc.CreateAttribute("bolum_adi");
                bolumadi.Value = oku["bolum_adi"].ToString();

                XmlAttribute ogrencisayisi = xdoc.CreateAttribute("ogrencisayisi");
                ogrencisayisi.Value = oku["ogrencisayisi"].ToString();

                bolum.Attributes.Append(bolumadi); //attribute kolonların adını çeker
                bolum.Attributes.Append(ogrencisayisi);
                root.AppendChild(bolum);
            }
            baglanti.Close();
            xdoc.AppendChild(root);//Bolumlerin altına ekliyor. append:eklemek
            xdoc.Save("bolumverileri.xml"); //obsistemi klasörü içinde bin debug klasörü altında bolumverileri.xml adlı dosya oluşturdu
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bolumcrud git = new bolumcrud();
            git.Show();
            this.Hide();
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
    }
}
