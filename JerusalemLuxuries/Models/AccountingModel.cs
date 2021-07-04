using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuries.Models
{
    public class Accounting
    {
        [Key] public int AccountingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("UserModel")] public int UserId { get; set; }
        [ForeignKey("PosterModel")] public int PosterId { get; set; }
        [ForeignKey("PaymentModel")] public int PaymentId { get; set; }
        [ForeignKey("PropertyModel")] public int PropertyId { get; set; }
    }
}