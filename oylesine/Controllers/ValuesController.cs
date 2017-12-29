using oylesine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace oylesine.Controllers
{
    
    public class ValuesController : ApiController
    {
        oylesineEntities db = new oylesineEntities();
        Kullanicilar kullanici = new Kullanicilar();


        


        [HttpPost]
        public Kontrol KullaniciEkle([FromBody]KullaniciIstek k)
        {
            Kontrol control = new Kontrol();
            try
            {
                using (db = new oylesineEntities())
                {
                    db.Kullanicilars.Add(new Kullanicilar()
                    {
                        Ad = k.ad,
                        Soyad = k.soyad,
                        KullaniciAdi = k.kullaniciAdi,
                        Email = k.email,
                        Parola = k.parola,
                        Fotograf = k.fotograf,
                        DogumTarihi = Convert.ToDateTime(k.dogumTarihi),
                        Telefon = k.telefon,
                        CinsiyetID = k.cinsiyetID,
                        KayitTarihi = DateTime.Now
                    });
                    db.SaveChanges();
                    control.basari = true;

                }
            }
            catch
            {
                control.basari = false;
            }
            return control;
        }

        [HttpPost]
        public Kontrol GonderiEkle([FromBody]GonderiIstek g)
        {
            Kontrol k = new Kontrol();
            try
            {
                using (db=new oylesineEntities())
                {
                    db.Gonderilers.Add(new Gonderiler()
                    {
                        KullaniciID =g.kullaniciID,
                        Icerik = g.icerik,
                        MedyaID = g.medyaID,
                        GonderiTarihi=DateTime.Now

                    });
                    db.SaveChanges();
                    k.basari = true;
                }
            }
            catch
            {
                k.basari = false;
            }
            return k;
        }

        [HttpPost]
        public Kontrol YorumEkle([FromBody]YorumIstek y)
        {
            Kontrol Control = new Kontrol();
            try
            {
                using (db = new oylesineEntities())
                {
                    db.Yorumlars.Add(new Yorumlar()
                    {
                        GonderiID = y.gonderiID,
                        KullaniciID = y.kullaniciID,
                        Yorum = y.yorum
                    });
                    db.SaveChanges();
                    Control.basari = true;
                }
                    
            }
            catch (Exception)
            {
                Control.basari = false;
            }
            return Control;
        }
        [HttpPost]
        public Kontrol Begen([FromBody]BegeniIstek b)
        {
            Kontrol k = new Kontrol();
            try
            {
                using (db=new oylesineEntities())
                {
                    db.Begenilers.Add(new Begeniler()
                    {
                        KullaniciID=b.kullaniciID,
                        GonderiID=b.gonderiID,
                        Begeni=b.begeni
                    });
                    db.SaveChanges();
                    k.basari = true;
                }
            }
            catch 
            {
                k.basari = false;
            }
            return k;
        }
        //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };             
        }



       
    }
}
