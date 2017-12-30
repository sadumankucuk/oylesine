using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class Kullanici
    {
        public int kullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string email { get; set; }     
        public string parola { get; set; }
        public string Fotograf { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string telefon { get; set; }
        public int cinsiyetID { get; set; }
        public DateTime kayitTarihi { get; set; }
    }
}