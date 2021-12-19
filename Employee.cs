using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAPI.Models
{
    public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }

    }
}