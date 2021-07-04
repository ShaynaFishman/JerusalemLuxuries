﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JerusalemLuxuryDomain.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public bool Visible { get; set; }
        public decimal Price { get; set; }
        
        [MaxLength(100)]
        public string Neighborhood { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }
        
        [MaxLength(100)]
        public string City { get; set; }
        
        [MaxLength(15)]
        public string ZipCode { get; set; }
        
        public bool Rent { get; set; }
        public int Size { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ContractLength { get; set; }
        //public byte Pictures { get; set; }
        public bool Swap { get; set; }

        [ForeignKey("PosterId")]
        public int PosterId { get; set; }

        [ForeignKey("AssetId")]
        public int AssetId { get; set; }

        [ForeignKey("DescriptionId")]
        public int DescriptionId { get; set; }

        [ForeignKey("PropertyCatId")]
        public int PropertyCatId { get; set; }

        [ForeignKey("ShortCatId")]
        public int ShortCatId { get; set; }

        public List<Feedback> FeedbackId { get; set; }
        //public List<Picture> PictureId { get; set; }

        public List<Accounting> AccountingId { get; set; }
    }
}