using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("Poster")]

    public class Poster
    {
        [Key] public int PosterId { get; set; }
        [MaxLength(30)] public string FirstName { get; set; }
        [MaxLength(30)] public string LastName { get; set; }
        [MaxLength(320)] public string Email { get; set; }
        [MaxLength(30)] public string ContractName { get; set; }
        public bool Agent { get; set; }
        public byte[] ProfileImage { get; set; }
        [MaxLength(15)] public string ContactNumber { get; set; }
        public DateTime RenewalDate { get; set; }
        [ForeignKey("PaymentMethod")] public List<PaymentMethod> PaymentMethodId { get; set; }
    }
}