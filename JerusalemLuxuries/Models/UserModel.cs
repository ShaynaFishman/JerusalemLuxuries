using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuries.Models
{
    public class UserModel
    {
        [Key] public int UserId { get; set; }
        [MaxLength(30)] public string FirstName { get; set; }
        [MaxLength(30)] public string LastName { get; set; }
        [MaxLength(320)] public string Email { get; set; }
        [MaxLength(15)] public string ContactNumber { get; set; }
        public bool PaidSubscriber { get; set; }
        public DateTime RenewalDate { get; set; }
        public bool OptOut { get; set; }
        [ForeignKey("PaymentMethodModel")] public List<PaymentMethodModel> PaymentMethod { get; set; }
    }
}