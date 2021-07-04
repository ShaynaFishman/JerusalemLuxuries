using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JerusalemLuxuries.Models
{
    public class PropertyCategoryModel
    {
        [Key]  public int PropertyCategoryId { get; set; }
        [MaxLength(60)] public string PCDescription { get; set; }
    }
}
