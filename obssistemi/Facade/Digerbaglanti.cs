using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facade
{
    public class Digerbaglanti
    {
        public static readonly SqlConnection con = new SqlConnection("Server=.; Database=OBS; Integrated Security=true;");

        public static bool ExecuteNonQuery(SqlCommand komut) //static olduğunda nesne üretmeden her yerden ulaşabiliyoruz.
        {
            try
            {
                if (komut.Connection.State != ConnectionState.Open)  //bağlantı açık mı kapalı mı kontrol et
                    komut.Connection.Open();//değilse aç
                return komut.ExecuteNonQuery() > 0;//satır dönüyor mu bak
            }
            catch (Exception)
            {
                return false; //veritabanını açamaz catche düşürür
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)//işlem bittiğinde veritabanı kapalı mı bak 
                    komut.Connection.Close(); //değilse kapat
            }
        }
    }
}
