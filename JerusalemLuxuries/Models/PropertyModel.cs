using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuries.Models
{
    public class PropertyModel
    {
        [Key] public int PropertyId { get; set; }
        public bool Visible { get; set; }
        public decimal Price { get; set; }
        [MaxLength(100)] public string Neighborhood { get; set; }
        [MaxLength(100)] public string Street { get; set; }
        [MaxLength(100)] public string ApartmentNumber { get; set; }
        [MaxLength(100)] public string City { get; set; }
        [MaxLength(100)] public string State { get; set; }
        [MaxLength(15)] public string ZipCode { get; set; }      
        public bool Rent { get; set; }
        public int Size { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ContractLength { get; set; }
        //public byte Pictures { get; set; }
        public bool Swap { get; set; }
        [ForeignKey("PosterModel")] public int PosterId { get; set; }
        [ForeignKey("AssetModel")] public int AssetId { get; set; }
        [ForeignKey("DescriptionModel")] public int DescriptionId { get; set; }        
        [ForeignKey("PropertyCategoryModel")] public int PropertyCategoryId { get; set; }
        [ForeignKey("ShortTermCategoryModel")] public int ShortTermCategoryId { get; set; }
        //public List<Feedback> FeedbackId { get; set; }
        //public List<PictureModel> PictureId { get; set; }
        //public List<Accounting> AccountingId { get; set; }
    }
}
