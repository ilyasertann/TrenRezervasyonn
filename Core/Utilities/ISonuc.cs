using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
   public  interface ISonuc
    {
        public bool RezervasyonYapilabilir  { get; set; }
        public string Mesaj { get; set; }
    }
}
