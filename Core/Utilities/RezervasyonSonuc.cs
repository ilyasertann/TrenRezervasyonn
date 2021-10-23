using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class RezervasyonSonuc
    {
        public Rezervasyon _rezervasyon1;
        public RezervasyonSonuc(Rezervasyon rezervasyon)
        {

            _rezervasyon1 = rezervasyon;
        }
        public bool RezervasyonYapilabilir { get; set; }
      public   List<YerlesimAyrinti> YerlesimAyrintilar;

        public int KisiSayisi;
        public bool FarklıVagon;
       public   int BosAlan = 0;
        public void rezervasyonYap()
        {
             FarklıVagon = _rezervasyon1.KisilerFarkliVagonlaraYerlestirilebilir;

             KisiSayisi = _rezervasyon1.RezervasyonYapilacakKisiSayisi;

            int BosAlan = 0;

            foreach (var item in _rezervasyon1.vagonlar)
            {
                BosAlan += (item.Kapasite - item.DoluKoltukAdet);
            }
            if (KisiSayisi > BosAlan)
            {
                RezervasyonYapilabilir = false;
            }
            else
            {
                RezervasyonYapilabilir = true;
            }

            if (FarklıVagon == true)
            {

                foreach (var item in _rezervasyon1.vagonlar)
                {
                    YerlesimAyrinti yerlesimAyrinti = new YerlesimAyrinti();

                    yerlesimAyrinti.VagonAdi = item.VagonAdi;
                    yerlesimAyrinti.KisiSayisi = KisiSayisi / 2;
                    YerlesimAyrintilar.Add(yerlesimAyrinti);

                }

            }
            else if (FarklıVagon == false)
            {

                foreach (var item in _rezervasyon1.vagonlar)
                {





                    YerlesimAyrinti yerlesimAyrinti = new YerlesimAyrinti();

                    yerlesimAyrinti.VagonAdi = item.VagonAdi;
                    yerlesimAyrinti.KisiSayisi = KisiSayisi;
                    YerlesimAyrintilar.Add(yerlesimAyrinti);
                    break;

                }
            }
        }
        

    

       
    }
}
