using Business.Abstract;
using Core.Utilities;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;
        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public VeriSonucu<List<YerlesimAyrinti>> add(Rezervasyon rezervasyon)
        {
            RezervasyonSonuc rezervasyonSonuc = new RezervasyonSonuc(rezervasyon);
            rezervasyonSonuc.rezervasyonYap();
            List<YerlesimAyrinti> result = rezervasyonSonuc.YerlesimAyrintilar;



            if (rezervasyonSonuc.RezervasyonYapilabilir == true)
            {

                return new BasariliVeriSonucu<List<YerlesimAyrinti>>(result, "Basarılı");
                _rezervasyonDal.Add(rezervasyon);
            }
            else
            {
                result = new List<YerlesimAyrinti>();
                return new BasarisizVeriSonucu<List<YerlesimAyrinti>>(result, "Basarisiz");
            }


        }

        public List<Rezervasyon> GetAll()
        {
            return _rezervasyonDal.GetAll();
        }
    }

         
    }

