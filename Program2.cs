
using System;
using System.Collections.Generic;
using System.Linq;

namespace DaysInMonth // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int ch;
            
            do
            {
                Console.WriteLine("enter the month");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("31 days");
                        Console.WriteLine("January");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 2:
                        Console.WriteLine("28 days");
                        Console.WriteLine("february");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 3:
                        Console.WriteLine("31 days");
                        Console.WriteLine("march");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 4:
                        Console.WriteLine("30 days");
                        Console.WriteLine("april");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 5:
                        Console.WriteLine("31 days");
                        Console.WriteLine("may");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;

                    case 6:
                        Console.WriteLine("30 days");
                        Console.WriteLine("june");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;

                    case 7:
                        Console.WriteLine("31 days");
                        Console.WriteLine("July");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;

                    case 8:
                        Console.WriteLine("31 days");
                        Console.WriteLine("august");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;

                    case 9:
                        Console.WriteLine("30 days");
                        Console.WriteLine("september");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;

                    case 10:
                        Console.WriteLine("31 days");
                        Console.WriteLine("october");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 11:
                        Console.WriteLine("30 days");
                        Console.WriteLine("november");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    case 12:
                        Console.WriteLine("31 days");
                        Console.WriteLine("december");
                        Console.WriteLine("*---*-------*-------*----*--------*----");
                        break;
                    default: Console.WriteLine("invalid");
                        break;
                }
            }
            while (ch != 0);
        }
    }
}