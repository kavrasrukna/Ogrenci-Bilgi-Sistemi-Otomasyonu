using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
namespace ObsLayer
{
    public class BLNot
    {
        public static int Ekleme(ENot veri)
        {
            if (veri.durum != null && veri.durum.Trim().Length > 0)//trim boşluk kontrolü yapar
            {
                return FNot.Ekleme(veri);
            }
            return -1;
        }
        public static List<ENot> Listele()
        {
            return FNot.Listele();
        }
    }
}