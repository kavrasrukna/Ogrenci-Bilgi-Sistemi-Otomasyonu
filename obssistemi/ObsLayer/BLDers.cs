using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
namespace ObsLayer
{
    public class BLDers
    {
        public static int Ekleme(EDers veri)
        {
            if (veri.ders_adi != null && veri.ders_adi.Trim().Length > 0)//trim boşluk kontrolü yapar
            {
                return FDers.Ekleme(veri);
            }
            return -1;
        }
        public static List<EDers> Listele()
        {
            return FDers.Listele();
        }
    }
}