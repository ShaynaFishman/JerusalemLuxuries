using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JerusalemLuxuryDomain.Models
{
    public class PropertyCategory
    {
        [Key]
        public int PropertyCatId { get; set; }
        
        [MaxLength(60)]
        public string Name { get; set; }

    }
}
