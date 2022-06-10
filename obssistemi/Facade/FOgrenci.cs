using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class FOgrenci
    {
        public static int Ekleme(EOgrenci veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("ogrenciekle", Baglanti.con);//baglanti facade dında bağlantı açık mı kapalı mı durumunu kontrol etmediğimiz için onu if içinde kontrol ediyoruz
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("ogrenci_adi", veri.ogrenci_adi);
                komut.Parameters.AddWithValue("ogrenci_soyadi", veri.ogrenci_soyadi);
                komut.Parameters.AddWithValue("bolum_id", veri.bolum_id);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        /*listeleme*/
        public static List<EOgrenci> Listele()
        {
            List<EOgrenci> itemlist = null;
            SqlCommand con = new SqlCommand("ogrencilistele", Baglanti.con);
            try
            {

                con.CommandType = CommandType.StoredProcedure;
                if (con.Connection.State != ConnectionState.Open)
                {
                    con.Connection.Open();
                }

                SqlDataReader rdr = con.ExecuteReader();
                //Datatablereader ve sqldatareader nesnelerinin HasRows propertiesinin data olması durumunda true bir değer eğer data yoksa false değeri döndürmesidir.
                //İşlem yaparken if ile dönen değeri kontrol ettiririz.true ise veriyi tabloya basabiliriz.false ise veri olmadığı için tabloya data yollayamayız.
                if (rdr.HasRows)
                {
                    itemlist = new List<EOgrenci>();
                    while (rdr.Read())
                    {
                        EOgrenci item = new EOgrenci();
                        item.ogrenci_no = Convert.ToInt32(rdr["ogrenci_no"]);
                        item.ogrenci_adi = rdr["ogrenci_adi"].ToString();
                        item.ogrenci_soyadi = rdr["ogrenci_soyadi"].ToString();
                        item.bolum_id = Convert.ToInt32(rdr["bolum_id"]);
                        itemlist.Add(item);
                    }
                }
            }
            catch
            {
                itemlist = null;
            }
            finally
            {
                con.Connection.Close();
            }
            return itemlist;
        }

        /*güncelle*/
        public static bool Guncelle(EOgrenci islem)
        {
            SqlCommand komut = new SqlCommand("ogrenciguncelle", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ogrenci_no", islem.ogrenci_no);
            komut.Parameters.AddWithValue("@ogrenci_adi", islem.ogrenci_adi);
            komut.Parameters.AddWithValue("@ogrenci_soyadi", islem.ogrenci_soyadi);
            komut.Parameters.AddWithValue("@bolum_id", islem.bolum_id);
            return Digerbaglanti.ExecuteNonQuery(komut);
        }

        /*sil*/
        public static bool Sil(EOgrenci islem)
        {
            SqlCommand komut = new SqlCommand("ogrencisil", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@ogrenci_no", islem.ogrenci_no);
            return Digerbaglanti.ExecuteNonQuery(komut);
        }
        /*ara*/
        public static DataTable Ara(EOgrenci ara1)
        {
            SqlCommand ara = new SqlCommand("ogrenciara", Digerbaglanti.con);
            ara.CommandType = CommandType.StoredProcedure;
            ara.Parameters.AddWithValue("ogrenci_no", ara1.ogrenci_no); 
            ara.Parameters.AddWithValue("ogrenci_adi", ara1.ogrenci_adi);
            Digerbaglanti.ExecuteNonQuery(ara);

            SqlDataAdapter adapter = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele1()//procesürleri facade da çağırıyoruz (FOgrenci). Buradaki Listele1 metodunuda raporlar içinde çağırıyorum
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_bolum_grupla", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele2()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_bolum_bote", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele3()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogretmen_ders", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele4()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogretmen_brans", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele5()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogretmen_brans_matematik", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele6()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_sayisi_bolum", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele7()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_durum_kaldi", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele8()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_bolum_ders_not", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele9()
        { 
            SqlDataAdapter adapter = new SqlDataAdapter("sp_ogrenci_ortalama", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Listele10()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("sp_vize_final", Digerbaglanti.con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
