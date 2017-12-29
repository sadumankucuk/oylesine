using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class BegeniIstek
    {
        public int kullaniciID { get; set; }
        public int gonderiID { get; set; }
        public bool begeni { get; set; }
    }
}