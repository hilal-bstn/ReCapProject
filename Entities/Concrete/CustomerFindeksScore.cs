using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class CustomerFindeksScore:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FindeksScore { get; set; }
    }
}
