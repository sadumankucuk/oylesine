﻿using oylesine.Models;
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
                        Yorum = y.yorum,
                        YorumTarihi=DateTime.Now
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
        [HttpPost]
        public Kontrol GonderiSil([FromBody]GonderiSilIstek gs)
        {
            Kontrol k = new Kontrol();
            try
            {
                using (db=new oylesineEntities())
                {
                    Gonderiler gonderi= db.Gonderilers.Find(gs.gonderiID);
                    YorumSilIstek yorum = new YorumSilIstek();
                    db.Gonderilers.Remove(gonderi);
                    YorumSil(yorum);
                    //todo begeni sil
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
        public Kontrol YorumSil([FromBody]YorumSilIstek y)
        {
            Kontrol k = new Kontrol();
            try
            {
                using (db=new oylesineEntities())
                {
                    Yorumlar yorum = db.Yorumlars.Find(y.yorumID);
                    db.Yorumlars.Remove(yorum);
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

        [HttpPost]
        public Kontrol KullaniciSil([FromBody]KullaniciSilIstek sil)
        {
            
            Kontrol Control = new Kontrol();
            try
            {
                using (db = new oylesineEntities())
                {
                    Kullanicilar kullanici = new Kullanicilar();
                    kullanici = db.Kullanicilars.Find(sil.kullaniciID);

                    db.Kullanicilars.Remove(kullanici);
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
        public Kontrol BegeniGeriAl([FromBody]BegeniGeriAlIstek b)
        {
            Kontrol Control = new Kontrol();
            try
            {
                using (db = new oylesineEntities())
                {

                    Begeniler begeni = new Begeniler();
                    begeni = db.Begenilers.Find(b.begeniID);
                    db.Begenilers.Remove(begeni);
                    db.SaveChanges();
                    Control.basari = true;
                }
            }
            catch
            {
                Control.basari = false;
            }
            return Control;
        }



    }
}
