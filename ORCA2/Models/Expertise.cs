using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ORCA2.Models
{
    public class Expertise
    {
        [Key]
        public int ExpertiseID { get; set; }
        public String Department { get; set; }
        public String Field { get; set; }
    }
}