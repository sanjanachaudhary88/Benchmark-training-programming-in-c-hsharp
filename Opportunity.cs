using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Models
{
    public class Opportunity
    {
        public int opp_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public string gender { get; set; }
        public string plan_details { get; set; }
        public string plan_price { get; set; }
        public int lead_id { get; set; }
    }
}