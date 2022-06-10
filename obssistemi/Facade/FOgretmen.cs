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
    public class FOgretmen
    {
        public static int Ekleme(EOgretmen veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("ogretmenekle", Baglanti.con);//baglanti facade dında bağlantı açık mı kapalı mı durumunu kontrol etmediğimiz için onu if içinde kontrol ediyoruz
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("ogretmen_adi", veri.ogretmen_adi);
                komut.Parameters.AddWithValue("ogretmen_soyadi", veri.ogretmen_soyadi);
                komut.Parameters.AddWithValue("ogretmen_brans", veri.ogretmen_brans);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        /*listeleme*/
        public static List<EOgretmen> Listele()
        {
            List<EOgretmen> itemlist = null;
            SqlCommand con = new SqlCommand("ogretmenlistele", Baglanti.con);
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
                    itemlist = new List<EOgretmen>();
                    while (rdr.Read())
                    {
                        EOgretmen item = new EOgretmen();
                        item.ogretmen_id = Convert.ToInt32(rdr["ogretmen_id"]);
                        item.ogretmen_adi = rdr["ogretmen_adi"].ToString();
                        item.ogretmen_soyadi = rdr["ogretmen_soyadi"].ToString();
                        item.ogretmen_brans = rdr["ogretmen_brans"].ToString();
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
        public static bool Guncelle(EOgretmen islem)
        {
            SqlCommand komut = new SqlCommand("ogretmenguncelle", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ogretmen_id", islem.ogretmen_id);
            komut.Parameters.AddWithValue("@ogretmen_adi", islem.ogretmen_adi);
            komut.Parameters.AddWithValue("@ogretmen_soyadi", islem.ogretmen_soyadi);
            komut.Parameters.AddWithValue("@ogretmen_brans", islem.ogretmen_brans);
            return Digerbaglanti.ExecuteNonQuery(komut);

        }
        /*sil*/
        public static bool Sil(EOgretmen islem)
        {
            SqlCommand komut = new SqlCommand("ogretmensil", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ogretmen_id", islem.ogretmen_id);
            return Digerbaglanti.ExecuteNonQuery(komut);
        }
        /*ara*/
        public static DataTable Ara(EOgretmen ara1)
        {
            SqlCommand ara = new SqlCommand("ogretmenara", Digerbaglanti.con);
            ara.CommandType = CommandType.StoredProcedure;
            ara.Parameters.AddWithValue("@ogretmen_adi", ara1.ogretmen_adi); //"@ogretmen_adi", ara1.ogretmen_adi ya da"ogretmen_adi", ara1.ogretmen_adi bu şeklde de yazılabilir
            ara.Parameters.AddWithValue("@ogretmen_brans", ara1.ogretmen_brans);
            Digerbaglanti.ExecuteNonQuery(ara);

            SqlDataAdapter adapter = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
