using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORCA2.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int User1ID { get; set; }
        public int User2ID { get; set; }
        public String Title { get; set; }
        public String InitialMessage { get; set; }
    }
}