using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***EXPENS MODEL***/
  [Table("expenses")]
 public partial class Expens : IMicron
 {
        [Primary]
        public Int32 ExpenseID {get; set;}
        [Foreign(typeof(Vehicle))]
        public Int32 VehicleID {get; set;}
        public String Date {get; set;}
        public String Description {get; set;}
        public Double Amount {get; set;}
        public String Notes {get; set;}
        [Foreign(typeof(User))]
        public Int32 CreatedBy {get; set;}
 }
}
