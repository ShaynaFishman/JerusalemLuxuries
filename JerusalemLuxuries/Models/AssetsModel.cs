﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JerusalemLuxuries.Models
{
    public class AssetsModel
    {
        [Key]
        public int AssetsId { get; set; }

        public bool Renovated { get; set; }
        public bool New { get; set; }
        public bool AirConditioning { get; set; }
        public bool Fan { get; set; }
        public bool Heating { get; set; }
        public bool Wifi { get; set; }
        public bool Furnished { get; set; }
        public bool Unfurnished { get; set; }
        public bool Elevator { get; set; }
        public bool GroundFloor { get; set; }
        public bool ScenicView { get; set; }
        public bool StorageRoom { get; set; }
        public bool Landline { get; set; }
        public bool WashingMachine { get; set; }
        public bool Dryer { get; set; }
        public bool Iron { get; set; }
        public bool IroningBoard { get; set; }
        public bool HotPlate { get; set; }
        public bool Kettle { get; set; }
        public bool ShabbosKettle { get; set; }
        public bool Fridge { get; set; }
        public bool Freezer { get; set; }
        public bool Stove { get; set; }
        public bool Dishwasher { get; set; }
        public bool CookingUtensils { get; set; }
        public bool Oven { get; set; }
        public bool ToasterOven { get; set; }
        public bool Microwave { get; set; }
        public bool Linen { get; set; }
        public bool Towels { get; set; }
        public bool HighChair { get; set; }
        public bool Crib { get; set; }
        public bool Couch { get; set; }
        public bool PesachItems { get; set; }
        public bool SukkosItems { get; set; }
        public bool Sukkoh { get; set; }
    }
}