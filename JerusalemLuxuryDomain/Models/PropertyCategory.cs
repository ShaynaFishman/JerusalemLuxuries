using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("PropertyCategory")]

    public class PropertyCategory
    {
        [Key]  public int PropertyCategoryId { get; set; }
        [MaxLength(60)] public string PCDescription { get; set; }
    }
}
