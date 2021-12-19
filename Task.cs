using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Models
{
    public class Task
    {
        public int taskid { get; set; }
        public string taskdescription { get; set; }
        public string status { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int empid { get; set; }
    }
}