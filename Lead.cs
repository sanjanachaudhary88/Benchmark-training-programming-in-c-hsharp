using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Models
{
    public class Lead
    {
        public int lead_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public int phone { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public int empid { get; set; }
    }
}