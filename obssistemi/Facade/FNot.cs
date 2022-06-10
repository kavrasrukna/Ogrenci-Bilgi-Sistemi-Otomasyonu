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
    public class FNot
    {
        public static int Ekleme(ENot veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("notekle", Baglanti.con);//baglanti facade dında bağlantı açık mı kapalı mı durumunu kontrol etmediğimiz için onu if içinde kontrol ediyoruz
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("ders_id", veri.ders_id);
                komut.Parameters.AddWithValue("ogrenci_no", veri.ogrenci_no);
                komut.Parameters.AddWithValue("vize", veri.vize);
                komut.Parameters.AddWithValue("final", veri.final);
                komut.Parameters.AddWithValue("ortalama", veri.ortalama);
                komut.Parameters.AddWithValue("durum", veri.durum);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        /*listeleme*/
        public static List<ENot> Listele()
        {
            List<ENot> itemlist = null;
            SqlCommand con = new SqlCommand("notlistele", Baglanti.con);
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
                //
                if (rdr.HasRows)
                {
                    itemlist = new List<ENot>();
                    while (rdr.Read())
                    {
                        ENot item = new ENot();
                        item.not_id = Convert.ToInt32(rdr["not_id"]);
                        item.ders_id = Convert.ToInt32(rdr["ders_id"]);
                        item.ogrenci_no = Convert.ToInt32(rdr["ogrenci_no"]);
                        item.vize = Convert.ToInt32(rdr["vize"]);
                        item.final = Convert.ToInt32(rdr["final"]);
                        item.ortalama = Convert.ToInt32(rdr["ortalama"]);
                        item.durum = rdr["durum"].ToString();
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
        public static bool Guncelle(ENot islem)
        {
            SqlCommand komut = new SqlCommand("notguncelle", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@not_id", islem.not_id);
            komut.Parameters.AddWithValue("@ders_id", islem.ders_id);
            komut.Parameters.AddWithValue("@ogrenci_no", islem.ogrenci_no);
            komut.Parameters.AddWithValue("@vize", islem.vize);
            komut.Parameters.AddWithValue("@final", islem.final);
            komut.Parameters.AddWithValue("@ortalama", islem.ortalama);
            komut.Parameters.AddWithValue("@durum", islem.durum);
            return Digerbaglanti.ExecuteNonQuery(komut);
        }

        /*sil*/
        public static bool Sil(ENot islem)
        {
            SqlCommand komut = new SqlCommand("notsil", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@not_id", islem.not_id);
            return Digerbaglanti.ExecuteNonQuery(komut);
        }
        /*ara*/
        public static DataTable Ara(ENot ara1)
        {
            SqlCommand ara = new SqlCommand("notara", Digerbaglanti.con);
            ara.CommandType = CommandType.StoredProcedure;
            ara.Parameters.AddWithValue("ders_id", ara1.ders_id); //"@ogretmen_adi", ara1.ogretmen_adi ya da"ogretmen_adi", ara1.ogretmen_adi bu şeklde de yazılabilir
            ara.Parameters.AddWithValue("ogrenci_no", ara1.ogrenci_no);
            ara.Parameters.AddWithValue("durum", ara1.durum);
            Digerbaglanti.ExecuteNonQuery(ara);

            SqlDataAdapter adapter = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}