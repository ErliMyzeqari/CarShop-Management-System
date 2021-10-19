using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PAYMENT MODEL***/
  [Table("payments")]
 public partial class Payment : IMicron
 {
        [Primary]
        public Int32 PaymentID {get; set;}
        public String PaidBy {get; set;}
        [Foreign(typeof(User))]
        public Int32 ReceivedBy {get; set;}
        [Foreign(typeof(Reservation))]
        public Int32 ReservationID {get; set;}
        public String Date {get; set;}
        public String Description {get; set;}
        public Double Amount {get; set;}
        public String Notes {get; set;}
 }
}
