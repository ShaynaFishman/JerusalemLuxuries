using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    public class Accounting
    {
        [Key]
        public int AccountingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("PosterId")]
        public int PosterId { get; set; }

        [ForeignKey("PaymentId")]
        public int PaymentId { get; set; }

        [ForeignKey("PropertyId")]
        public int PropertyId { get; set; }
    }
}