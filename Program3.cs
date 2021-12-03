using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Q3
{
    class swapprog
    {
        public static void swap(ref int no1, ref int no2)
        {
            int t;
            t = no1;
            no1 = no2;
            no2 = t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number before swapping are");
            Console.WriteLine("number 1 is" + number1);
            Console.WriteLine("number 2 is" + number2);
            swap(ref number1, ref number2);
            Console.WriteLine("number after swapping are");
            Console.WriteLine("number 1 is" + number1);
            Console.WriteLine("number 2 is" + number2);
            Console.ReadKey();

        }
    }

}
