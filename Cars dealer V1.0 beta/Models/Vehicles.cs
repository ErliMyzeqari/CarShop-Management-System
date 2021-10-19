using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***VEHICLE MODEL***/
  [Table("vehicles")]
 public partial class Vehicle : IMicron
 {
        [Primary]
        public Int32 VehicleID {get; set;}
        public String KeyNo {get; set;}
        public String Type {get; set;}
        [Foreign(typeof(Model))]
        public Int32 ModelID {get; set;}
        public String Version {get; set;}
        public String Transmission {get; set;}
        public Int32 Year {get; set;}
        public Int32 KM {get; set;}
        public String Fuel {get; set;}
        public Int32 CC {get; set;}
        public String Color {get; set;}
        public Int32 Warranty {get; set;}
        public String Chassis {get; set;}
        [Foreign(typeof(Seller))]
        public Int32 SellerID {get; set;}
        public Boolean Internet {get; set;}
        public Boolean VAT {get; set;}
        public Double Buying_Price {get; set;}
        public Double Export_Price {get; set;}
        public Boolean forEnterprise {get; set;}
        public Double Selling_Price {get; set;}
        public String Features {get; set;}
        [Foreign(typeof(User))]
        public Int32 CreatedBy {get; set;}
 }
}
