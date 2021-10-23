using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class YerlesimAyrinti:IEntity
    {
        public int Id { get; set; }
        public string VagonAdi { get; set; }
        public int KisiSayisi { get; set; }
    }
}
