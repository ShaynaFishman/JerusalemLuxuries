using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("ShortTermCategory")]
    public class ShortTermCategory
    {
        [Key] public int ShortTermCategoryId {get; set;}
        [MaxLength(100)]public string Description {get; set;}
    }
}
