using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Ogrenci
    {
        public string ad;

        private string soyad;

        private int yas;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public int YAS
        {
            get { return yas; }

          set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }


    }
}
