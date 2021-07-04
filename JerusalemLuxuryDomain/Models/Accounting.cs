using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{

    [Table("Accounting")]
    public class Accounting
    {
        [Key] public int AccountingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("User")] public int UserId { get; set; }
        [ForeignKey("Poster")] public int PosterId { get; set; }
        [ForeignKey("Payment")] public int PaymentId { get; set; }
        [ForeignKey("Property")] public int PropertyId { get; set; }
    }
}