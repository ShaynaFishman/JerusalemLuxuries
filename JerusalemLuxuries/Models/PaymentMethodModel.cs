using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JerusalemLuxuries.Models
{
    public class PaymentMethodModel
    {
        [Key]
        public int PaymentMethodId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
    }
}