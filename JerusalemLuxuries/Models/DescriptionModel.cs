using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuries.Models
{
    public class DescriptionModel
    {
        [Key] public int DescriptionId { get; set; }
        public decimal Rooms { get; set; }
        public bool Porch { get; set; }
        //public bool Lift { get; set; }
        public int Floors { get; set; }
        public int Bathrooms { get; set; }
        public bool SeparateKitchenDining { get; set; }
    }
}
