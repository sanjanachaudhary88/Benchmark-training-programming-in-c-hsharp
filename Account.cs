using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Models
{
    public class Account
    {
        public int acc_id { get; set; }
        public int lead_id { get; set; }
        public int opp_id { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string status { get; set; }
    }
}