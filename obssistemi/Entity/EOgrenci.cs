using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EOgrenci
    {
        //entitye hiç bir şeyi dahil reference yapmıyoruz hepsi bunu kullandığı için
        private int _ogrenci_no; /*tablodaki alanlar*/
        private string _ogrenci_adi;
        private string _ogrenci_soyadi;
        private int _bolum_id;

        public int ogrenci_no /* class  */
        {
            get
            {
                return _ogrenci_no; /*tablodaki alanlar*/
            }
            set
            {
                _ogrenci_no = value;
            }
        }

        public string ogrenci_adi
        {
            get
            {
                return _ogrenci_adi;
            }
            set
            {
                _ogrenci_adi = value;
            }
        }

        public string ogrenci_soyadi
        {
            get
            {
                return _ogrenci_soyadi;
            }
            set
            {
                _ogrenci_soyadi = value;
            }
        }

        public int bolum_id
        {
            get
            {
                return _bolum_id;
            }
            set
            {
                _bolum_id = value;
            }
        }
    }
}
