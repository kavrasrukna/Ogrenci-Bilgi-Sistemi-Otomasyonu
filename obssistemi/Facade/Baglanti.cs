using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Facade
{
   public class Baglanti
    {
        //Readonly: tanımlı değişkeni salt okunur moduna getirmektedir.Yani readonly olarak tanımlanan bir değişken sadece okunabilmektedir.
        //Setleme işlemi değişkenin oluşturulduğu anda ya da oluşturulan sınıfın constructor metodu içerisine yapılmaktadır.
        //Çalışma zamanında sadece constructor içerisinde değer ataması yapılabilmektedir. Aksi halde salt okunur bir alana değer atanamaz uyarısı vermektedir.
        public static readonly SqlConnection con = new SqlConnection("Server=.; Database=OBS; Integrated Security=true;");


    }
}
