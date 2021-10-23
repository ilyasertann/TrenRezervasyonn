using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
   public class Sonuc:ISonuc
    {
        public Sonuc(bool rezervasyonYapilabilir,string mesaj):this(rezervasyonYapilabilir)
        {
            Mesaj = mesaj;

        }
        public Sonuc(bool rezervasyonYapilabilir)
        {
            RezervasyonYapilabilir = rezervasyonYapilabilir;
        }


        public bool RezervasyonYapilabilir { get; set; }
        public string Mesaj { get; set; }
    }
}
