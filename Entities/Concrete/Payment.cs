using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Payment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PaymentType { get; set; }//ödeme tipi /kredi kartı/nakit
        public int Amount { get; set; }//ödenilen tutar/ödenilecek tutar
        public bool Status { get; set; }//ödendiyse true ödenmediyse false
        //carId de ekle
    }
}
