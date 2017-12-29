using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class KullaniciIstek
    {
        //string ad, string soyad, string kullaniciAdi, string , string parola, string fotograf, string dogumTarihi, string telefon, int cinsiyetID
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string email { get; set; }
        public string parola { get; set; }
        public string fotograf { get; set; }
        public string dogumTarihi { get; set; }
        public string telefon { get; set; }   
        public int cinsiyetID { get; set; }

    }
}