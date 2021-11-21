
using System;
using System.Collections.Generic;
using System.Linq;

namespace enumeration // Note: actual namespace depends on the project name.
{
 
    public class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public static void Main(string[] args)
        {
            int weekdayStart = (int)Days.Mon;
            int weekdayEnd = (int)Days.Fri;
            Console.WriteLine(weekdayStart);
            Console.WriteLine(weekdayEnd);
            Console.ReadKey();
        }
    }
}