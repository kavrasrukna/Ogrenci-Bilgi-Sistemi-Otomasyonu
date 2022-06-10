using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EOgretmen
    {  //entitye hiç bir şeyi dahil reference yapmıyoruz hepsi bunu kullandığı için
        private int _ogretmen_id; /*tablodaki alanlar*/
        private string _ogretmen_adi;
        private string _ogretmen_soyadi;
        private string _ogretmen_brans;

        public int ogretmen_id /* class  */
        {
            get
            {
                return _ogretmen_id; /*tablodaki alanlar*/
            }
            set
            {
                _ogretmen_id = value;
            }
        }

        public string ogretmen_adi
        {
            get
            {
                return _ogretmen_adi;
            }
            set
            {
                _ogretmen_adi = value;
            }
        }

        public string ogretmen_soyadi
        {
            get
            {
                return _ogretmen_soyadi;
            }
            set
            {
                _ogretmen_soyadi = value;
            }
        }

        public string ogretmen_brans
        {
            get
            {
                return _ogretmen_brans;
            }
            set
            {
                _ogretmen_brans = value;
            }
        }
    }
}
