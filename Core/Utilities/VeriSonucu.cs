using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class VeriSonucu<T> : Sonuc, IVeriSonucu<T>
    {
        public T Veri { get; }
        public VeriSonucu(T veri,bool rezervasyonYapilabilir,string mesaj):base(rezervasyonYapilabilir,mesaj)
        {
            Veri = veri;
        }
        public VeriSonucu(T veri,bool rezervasyonYapilabilir):base(rezervasyonYapilabilir)
        {
            Veri = veri;
        }
        
    }
}
