using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***CLIENT MODEL***/
  [Table("clients")]
 public partial class Client : IMicron
 {
        [Primary]
        public Int32 ClientID {get; set;}
        public String FirstName {get; set;}
        public String LastName {get; set;}
        public String Address {get; set;}
        public String Phone {get; set;}
        public String Email {get; set;}
        public Boolean ContactByPhone {get; set;}
        public Boolean ContactByEmail {get; set;}
        public String Enterprise {get; set;}
        public Double VAT {get; set;}
        public String FAX {get; set;}
        public String Notes {get; set;}
 }
}
