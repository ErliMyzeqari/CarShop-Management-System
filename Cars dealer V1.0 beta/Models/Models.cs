using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***MODEL MODEL***/
  [Table("models")]
 public partial class Model : IMicron
 {
        [Primary]
        public Int32 ModelID {get; set;}
        [Foreign(typeof(Brand))]
        public Int32 BrandID {get; set;}
        public String Name {get; set;}
 }
}
