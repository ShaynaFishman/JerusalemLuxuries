using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("Feedback")]

    public class Feedback
    {
        [Key] public int FeedbackId { get; set; }
        [MaxLength(300)] public string FeedbackDescription { get; set; }
        public int Rating { get; set; }
        public bool Approved { get; set; }
        public bool WebsiteFeedback { get; set; }
        [ForeignKey("UserId")] public int UserId { get; set; }
        [ForeignKey("PosterId")] public int PosterId { get; set; }
        [ForeignKey("Property")] public int PropertyId { get; set; }
    }
}