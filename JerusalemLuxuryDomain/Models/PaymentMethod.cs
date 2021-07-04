using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("PaymentMethod")]

    public class PaymentMethod
    {
        [Key] public int PaymentMethodId { get; set; }
        [MaxLength(30)] public string Description { get; set; }
        //Examples of payments types: Credit Card, Debit Card
    }
}