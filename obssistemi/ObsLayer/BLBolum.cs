using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
namespace ObsLayer
{
    public class BLBolum
    {
        public static int Ekleme(EBolum veri)
        {
            if (veri.bolum_adi != null && veri.bolum_adi.Trim().Length > 0)//trim boşluk kontrolü yapar
            {
                return FBolum.Ekleme(veri);
            }
            return -1;
        }
        public static List<EBolum> Listele()
        {
            return FBolum.Listele();
        }
    }
}

