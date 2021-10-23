using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRezervasyonService
    {
        List<Rezervasyon> GetAll();

          VeriSonucu<List<YerlesimAyrinti>> add(Rezervasyon rezervasyon);

    }
}
