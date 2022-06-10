using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EBolum
    {
        //entitye hiç bir şeyi dahil reference yapmıyoruz herkes bunu kullandığı için
        private int _bolum_id; /*tablodaki alanlar*/
        private string _bolum_adi;
        private int _ogrencisayisi;

        public int bolum_id /* class  */
        {
            get
            {
                return _bolum_id; /*tablodaki alanlar*/
            }
            set
            {
                _bolum_id = value;
            }
        }

        public string bolum_adi
        {
            get
            {
                return _bolum_adi;
            }
            set
            {
                _bolum_adi = value;
            }
        }

        public int ogrencisayisi
        {
            get
            {
                return _ogrencisayisi;
            }
            set
            {
                _ogrencisayisi = value;
            }
        }
    }
}
