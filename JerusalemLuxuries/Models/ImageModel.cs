using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuries.Models
{
    public class ImageModel
    {
        [Key] public int ImageId { get; set; }
        public byte[] PropertyImage { get; set; }
        [ForeignKey("PropertyModel")] public int PropertyId { get; set; }
    }
}