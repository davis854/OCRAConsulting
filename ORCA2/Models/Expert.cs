using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORCA2.Models
{
    public class Expert
    {
        public int ExpertID { get; set; }
        public int ExpertiseID { get; set; }
        public Boolean Validated { get; set; }
    }
}