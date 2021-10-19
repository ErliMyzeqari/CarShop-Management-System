using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***BRAND MODEL***/
  [Table("brands")]
 public partial class Brand : IMicron
 {
        [Primary]
        public Int32 BrandID {get; set;}
        public String Name {get; set;}
        public String Country {get; set;}
 }
}
