using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class BasarisizVeriSonucu<T>:VeriSonucu<T>
    {
        public BasarisizVeriSonucu(T veri, string mesaj) : base(veri, false, mesaj)
        {

        }

        public BasarisizVeriSonucu(T veri) : base(veri, false)
        {

        }
        public BasarisizVeriSonucu(string mesaj) : base(default, false, mesaj)
        {

        }
        public BasarisizVeriSonucu() : base(default, false)
        {

        }

    }
}
