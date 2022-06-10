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
    public class FDers
    {
  public static int Ekleme(EDers veri)
            {
                int islem = 0;
                try
                {
                    SqlCommand komut = new SqlCommand("dersekle", Baglanti.con);//baglanti facade dında bağlantı açık mı kapalı mı durumunu kontrol etmediğimiz için onu if içinde kontrol ediyoruz
                    komut.CommandType = CommandType.StoredProcedure;
                    if (komut.Connection.State != ConnectionState.Open)
                    {
                        komut.Connection.Open();
                    }
                    komut.Parameters.AddWithValue("ders_adi", veri.ders_adi);
                    komut.Parameters.AddWithValue("ogretmen_id", veri.ogretmen_id);
                    islem = komut.ExecuteNonQuery();
                }
                catch
                {
                    islem = -1;
                }
                return islem;
            }
            /*listeleme*/
            public static List<EDers> Listele()
            {
                List<EDers> itemlist = null;
                SqlCommand con = new SqlCommand("derslistele", Baglanti.con);
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
                        itemlist = new List<EDers>();
                        while (rdr.Read())
                        {
                            EDers item = new EDers();
                            item.ders_id = Convert.ToInt32(rdr["ders_id"]);
                            item.ders_adi = rdr["ders_adi"].ToString();
                            item.ogretmen_id = Convert.ToInt32(rdr["ogretmen_id"]);
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
            public static bool Guncelle(EDers islem)
            {
                SqlCommand komut = new SqlCommand("dersguncelle", Digerbaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ders_id", islem.ders_id);
                komut.Parameters.AddWithValue("@ders_adi", islem.ders_adi);
                komut.Parameters.AddWithValue("@ogretmen_id", islem.ogretmen_id);
                return Digerbaglanti.ExecuteNonQuery(komut);
            }
            /*sil*/
            public static bool Sil(EDers islem)
            {
                SqlCommand komut = new SqlCommand("derssil", Digerbaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ders_id", islem.ders_id);
                return Digerbaglanti.ExecuteNonQuery(komut);
            }
        /*ara*/
        public static DataTable Ara(EDers ara1)//entitydeki ad eders
        {
            SqlCommand ara = new SqlCommand("dersara", Digerbaglanti.con);
            ara.CommandType = CommandType.StoredProcedure;
            ara.Parameters.AddWithValue("ders_adi", ara1.ders_adi);
            Digerbaglanti.ExecuteNonQuery(ara);

            SqlDataAdapter adapter = new SqlDataAdapter(ara);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
    }


