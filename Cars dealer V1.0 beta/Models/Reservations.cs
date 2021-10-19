using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***RESERVATION MODEL***/
  [Table("reservations")]
 public partial class Reservation : IMicron
 {
        [Primary]
        public Int32 ReservatonID {get; set;}
        [Foreign(typeof(Vehicle))]
        public Int32 VehicleID {get; set;}
        [Foreign(typeof(Client))]
        public Int32 ClientID {get; set;}
        public String DateReserved {get; set;}
        public String DueDate {get; set;}
        public Double SellingPrice {get; set;}
        public Boolean Sold {get; set;}
        public String DateSold {get; set;}
        public String Notes {get; set;}
        [Foreign(typeof(User))]
        public Int32 ReservedBy {get; set;}
 }
}
