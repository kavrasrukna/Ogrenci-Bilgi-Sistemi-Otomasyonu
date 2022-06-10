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
    public class FBolum
    {
        public static int Ekleme(EBolum veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("bolumekle", Baglanti.con);//baglanti facade dında bağlantı açık mı kapalı mı durumunu kontrol etmediğimiz için onu if içinde kontrol ediyoruz
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("bolum_adi", veri.bolum_adi);
                komut.Parameters.AddWithValue("ogrencisayisi", veri.ogrencisayisi);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }
        /*listeleme*/
        public static List<EBolum> Listele()
        {
            List<EBolum> itemlist = null;
            SqlCommand con = new SqlCommand("bolumlistele", Baglanti.con);
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
                    itemlist = new List<EBolum>();
                    while (rdr.Read())
                    {
                        EBolum item = new EBolum();
                        item.bolum_id = Convert.ToInt32(rdr["bolum_id"]);
                        item.bolum_adi = rdr["bolum_adi"].ToString();
                        item.ogrencisayisi = Convert.ToInt32(rdr["ogrencisayisi"]);
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
        public static bool Guncelle(EBolum islem)
        {
            SqlCommand komut = new SqlCommand("bolumguncelle", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@bolum_id", islem.bolum_id);
            komut.Parameters.AddWithValue("@bolum_adi", islem.bolum_adi);
            komut.Parameters.AddWithValue("@ogrencisayisi", islem.ogrencisayisi);
            return Digerbaglanti.ExecuteNonQuery(komut);

        }

        /*sil*/
        public static bool Sil(EBolum islem)
        {
            SqlCommand komut = new SqlCommand("bolumsil", Digerbaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@bolum_id", islem.bolum_id);
            return Digerbaglanti.ExecuteNonQuery(komut);

        }
        /*ara*/
        public static DataTable Ara(EBolum ara1)
        {
            SqlCommand ara = new SqlCommand("bolumara", Digerbaglanti.con);
            ara.CommandType = CommandType.StoredProcedure;
            ara.Parameters.AddWithValue("bolum_adi", ara1.bolum_adi);
            Digerbaglanti.ExecuteNonQuery(ara);

            SqlDataAdapter adapter = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}


