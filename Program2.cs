using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2Q4 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Average(10,20,30,40,20,1,20,11));
            Console.WriteLine(p.Average(10, 22, 33, 44, 55, 6666, 7777, 88, 22));
            Console.WriteLine(p.Average(10,12, 23));
        }

        public double Average(params double[] marks)
        {
            double sum = 0;
            double avg = 0;
            foreach(double m in marks)
            {
                sum = sum + m;

            }
            avg = sum / marks.Length;
            return avg;
        }
    }
}