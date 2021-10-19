using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER MODEL***/
  [Table("users")]
 public partial class User : IMicron
 {
        [Primary]
        public Int32 UserID {get; set;}
        public String Initials {get; set;}
        public String FullName {get; set;}
        public String email {get; set;}
        public String password {get; set;}
        public Boolean isAdmin {get; set;}
 }
}
