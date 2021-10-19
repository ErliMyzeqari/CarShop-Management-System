using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TASK MODEL***/
  [Table("tasks")]
 public partial class Task : IMicron
 {
        [Primary]
        public Int32 TaskID {get; set;}
        public Int32 CreatedBy {get; set;}
        public Int32 TargetID {get; set;}
        public String Description {get; set;}
        public Boolean Complete {get; set;}
        public String CreatedAt {get; set;}
        public String CompletedAt {get; set;}
 }
}
