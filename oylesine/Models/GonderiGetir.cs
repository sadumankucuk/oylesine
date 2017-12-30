using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class GonderiGetir
    {
        public string kullaniciAdi { get; set; }
        public int gonderiID { get; set; }
        public int kullaniciID { get; set; }
        public string icerik { get; set; }
        public string fotograf { get; set; }
        public int begenisayisi { get; set; }
        public int yorumsayisi { get; set; }
        public DateTime gonderiTarihi { get; set; }

    }
}