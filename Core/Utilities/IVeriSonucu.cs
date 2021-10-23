using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
  public   interface IVeriSonucu<T>:ISonuc
    {
          T Veri { get; }
    }
}
