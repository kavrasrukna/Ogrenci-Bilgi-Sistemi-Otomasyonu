using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
namespace ObsLayer
{
    public class BLOgretmen
    {
        public static int Ekleme(EOgretmen veri)
        {
            if (veri.ogretmen_brans != null && veri.ogretmen_brans.Trim().Length > 0)//trim boşluk kontrolü yapar
            {
                return FOgretmen.Ekleme(veri);
            }
            return -1;
        }
        public static List<EOgretmen> Listele()
        {
            return FOgretmen.Listele();
        }
    }
}
