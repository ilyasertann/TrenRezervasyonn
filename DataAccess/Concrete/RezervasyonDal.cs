using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
   
    public class RezervasyonDal : IRezervasyonDal
    {
        List<Rezervasyon> _rezervasyons;
        public RezervasyonDal()
        {
             List<Vagon> _vagonlar = new List<Vagon>{ 
               

            };
            _rezervasyons = new List<Rezervasyon>  ();

        
           




           
 
            
            
        }
        public void Add(Rezervasyon rezervasyon)
        {
            _rezervasyons.Add(rezervasyon);
        }

        public void Delete(Rezervasyon rezervasyon)
        {
            Rezervasyon rezervasyonSil=null;
            
            rezervasyonSil = _rezervasyons.SingleOrDefault(p => p.Id == rezervasyon.Id);

            _rezervasyons.Remove(rezervasyonSil);
        }

        public List<Rezervasyon> GetAll()
        {
            return _rezervasyons;
        }

        public void Update(Rezervasyon rezervasyon)
        {
            Rezervasyon rezervasyonGüncelle = null;

            rezervasyonGüncelle = _rezervasyons.SingleOrDefault(p => p.Id == rezervasyon.Id);

            rezervasyonGüncelle.TrenAdi = rezervasyon.TrenAdi;
            rezervasyonGüncelle.vagonlar = rezervasyon.vagonlar;
             
        }
    }
}
