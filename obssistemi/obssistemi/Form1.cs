using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//kütüphane ekledik

namespace obssistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=OBS;Integrated Security=true");
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "kullanicigirisi";
            komut.Parameters.AddWithValue("kullaniciadi", txtgkullaniciadi.Text);
            komut.Parameters.AddWithValue("sifre", txtgsifre.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                anasayfa git = new anasayfa();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı.Tekrar deneyiniz");
                txtgkullaniciadi.Clear();
                txtgsifre.Clear();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kayitol.Visible = false;
        }
        private void checkBoxkayit_CheckedChanged(object sender, EventArgs e)
        {
            kayitol.Visible = true;
        }
        private void btnkayit_Click(object sender, EventArgs e)
        {
            if (kayitkullaniciadi.Text == "" || kayitsifre.Text == "" || txtmail.Text == "" || maskedtxttel.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
                MessageBox.Show("Üyeliğiniz oluşturuldu.Giriş yapınız.");

                // veri ekleme komutu
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "kullaniciekle";//prosedürün adı 
                baglanti.Open();
                komut.Parameters.AddWithValue("kullaniciadi", kayitkullaniciadi.Text);// addwithvalue:değeriyle beraber ekle  demek
                komut.Parameters.AddWithValue("sifre", kayitsifre.Text); //"" sql tablomdaki kolonlarla aynı adda olmalı
                komut.Parameters.AddWithValue("mail", txtmail.Text); //prosedürdeki alanlar ""
                komut.Parameters.AddWithValue("telefon", maskedtxttel.Text);
                komut.ExecuteNonQuery();//kaydet
                baglanti.Close();
                kayitkullaniciadi.Clear();
                kayitsifre.Clear();
                txtmail.Clear();
                maskedtxttel.Clear();
            }
        }
    }
}