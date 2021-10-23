using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rezervasyon : IEntity
    {
        public int Id;
        public string TrenAdi { get; set; }
        public List<Vagon> vagonlar;

        public int RezervasyonYapilacakKisiSayisi { get; set; }
        public bool KisilerFarkliVagonlaraYerlestirilebilir { get; set; }

    }
}
