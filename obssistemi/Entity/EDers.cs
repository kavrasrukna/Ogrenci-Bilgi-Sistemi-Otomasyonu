using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class EDers
    {
        //entitye hiç bir şeyi dahil reference yapmıyoruz hepsi bunu kullandığı için
        private int _ders_id; /*tablodaki alanlar*/
        private string _ders_adi;
        private int _ogretmen_id;

        public int ders_id /* class  */
        {
            get
            {
                return _ders_id; /*tablodaki alanlar*/
            }
            set
            {
                _ders_id = value;
            }
        }

        public string ders_adi
        {
            get
            {
                return _ders_adi;
            }
            set
            {
                _ders_adi = value;
            }
        }

        public int ogretmen_id
        {
            get
            {
                return _ogretmen_id;
            }
            set
            {
                _ogretmen_id = value;
            }
        }
    }
}
