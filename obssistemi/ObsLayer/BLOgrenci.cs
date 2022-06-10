using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
namespace ObsLayer
{
    public class BLOgrenci
    {
        public static int Ekleme(EOgrenci veri)
        {
            if (veri.ogrenci_adi != null && veri.ogrenci_adi.Trim().Length > 0)//trim boşluk kontrolü yapar
            {
                return FOgrenci.Ekleme(veri);
            }
            return -1;
        }
        public static List<EOgrenci> Listele()
        {
            return FOgrenci.Listele();
        }
    }
}