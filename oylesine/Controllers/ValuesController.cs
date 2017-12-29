using oylesine.Models;
using oylesine.Models.Request;
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
                        KullaniciID = g.kullaniciID,
                        Icerik = g.icerik,
                        MedyaID = g.medyaID,
                        GonderiTarihi = DateTime.Now
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

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
