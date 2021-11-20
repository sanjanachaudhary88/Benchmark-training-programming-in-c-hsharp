using System;
using System.Collections.Generic;
using System.Linq;

namespace fabonnaci // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n,a , b , c = 0;
            Console.WriteLine("enter a and b for fabonacci series");
            a =Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("enter the number you want for fabonacci series");
            n=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("fabonnaci series is :" + a);
            Console.WriteLine("fabonnaci series is :" + b);
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine("fabonnaci series is :" + c);
            }

            
        }
    }
}