using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excell_Deneme_1
{
    class Ogrenci_Nesnesi
    {

        private String Ogrenci_isim;
        private String Ogrenci_No;
        private String Ogrenci_Sinif;
        private String Ogrenci_Email;


        public void setOgrenci_isim(String isim)
        {
            this.Ogrenci_isim = isim;
        }

        public String getOgrenci_isim()
        {
            return this.Ogrenci_isim;
        }


        public void setOgrenci_No(String no)
        {
            this.Ogrenci_No = no;
        }

        public String getOgrenci_No()
        {
            return this.Ogrenci_No;
        }


        public void setOgrenci_Sinif(String sinif)
        {
            this.Ogrenci_Sinif = sinif;
        }

        public String getOgrenci_Sinif()
        {
            return this.Ogrenci_Sinif;
        }


        public void setOgrenci_Email(String email)
        {
            this.Ogrenci_Email = email;
        }

        public String getOgrenci_Email()
        {
            return this.Ogrenci_Email;
        }

    }
}
