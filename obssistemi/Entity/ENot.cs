using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ENot
    {

        //entitye hiç bir şeyi dahil reference yapmıyoruz herkes bunu kullandığı için
        private int _not_id; /*tablodaki alanlar*/
        private int _ders_id;
        private int _ogrenci_no;
        private float _vize;
        private float _final;
        private float _ortalama;
        private string _durum;
        public int not_id /* class  */
        {
            get
            {
                return _not_id; /*tablodaki alanlar*/
            }
            set
            {
                _not_id = value;
            }
        }

        public int ders_id
        {
            get
            {
                return _ders_id;
            }
            set
            {
                _ders_id = value;
            }
        }

        public int ogrenci_no
        {
            get
            {
                return _ogrenci_no;
            }
            set
            {
                _ogrenci_no = value;
            }
        }

        public float vize
        {
            get
            {
                return _vize;
            }
            set
            {
                _vize = value;
            }
        }

        public float final
        {
            get
            {
                return _final;
            }
            set
            {
                _final = value;
            }
        }

        public float ortalama
        {
            get
            {
                return _ortalama;
            }
            set
            {
                _ortalama = value;
            }
        }

        public string durum
        {
            get
            {
                return _durum;
            }
            set
            {
                _durum = value;
            }
        }
    }
}
