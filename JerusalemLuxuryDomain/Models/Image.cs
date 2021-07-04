using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    [Table("Images")]
    class Image
    {
        [Key] public int ImageId { get; set; }
        public byte[] PropertyImage { get; set; }
        [ForeignKey("Property")] public int PropertyId { get; set; }
    }
}
