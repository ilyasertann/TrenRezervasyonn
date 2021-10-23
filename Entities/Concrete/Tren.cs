using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Tren:IEntity
    {
        public int Id { get; set; }
        public List<Vagon> vagonlar{ get; set; }
    }
}
