using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JerusalemLuxuries.Models
{
    public class CardInfoModel
    {
        [Key] public int CardInfoId { get; set; }
        [MaxLength(30)] public string FirstName { get; set; }
        [MaxLength(30)] public string LastName { get; set; }
        public int CardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int Security { get; set; }
        [MaxLength(40)] public string Address { get; set; }
        [MaxLength(40)] public string City { get; set; }
        [MaxLength(40)] public string State { get; set; }
        [MaxLength(40)] public string ZipCode { get; set; }
        [ForeignKey("Poster")] public int PosterId { get; set; }
        [ForeignKey("User")] public int UserId { get; set; }
    }
}