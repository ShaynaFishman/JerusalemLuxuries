using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    public class ShortTermCategory
    {
        [Key]
        public int ShortTermCategoryId {get; set;}
        [MaxLength(100)]public string Name {get; set;}
    }
}
