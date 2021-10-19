using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***SELLER MODEL***/
  [Table("sellers")]
 public partial class Seller : IMicron
 {
        [Primary]
        public Int32 SellerID {get; set;}
        public String FullName {get; set;}
        public String Address {get; set;}
        public String Phone {get; set;}
        public String Email {get; set;}
        public Boolean ContactByEmail {get; set;}
        public Boolean ContactByPhone {get; set;}
        public Boolean isEnterprise {get; set;}
        public Double VAT {get; set;}
        public String FAX {get; set;}
        public String Notes {get; set;}
 }
}
