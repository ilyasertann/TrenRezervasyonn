using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
   public  class BasariliVeriSonucu<T>:VeriSonucu<T>
    {
        public BasariliVeriSonucu(T veri, string mesaj) : base(veri, true, mesaj)
        {

        }

    public BasariliVeriSonucu(T veri) : base(veri, true)
        {

        }
        public BasariliVeriSonucu(string mesaj) : base(default, true, mesaj)
        {

        }
        public BasariliVeriSonucu() : base(default, true)
        {

        }
     
    }
}