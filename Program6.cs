using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Q6 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public class IndexOutOfBounds : Exception
        {
            public IndexOutOfBounds(String message)
                : base(message)
            {

            }
        }
        public static void Main(string[] args)
        {

            try
            {
                int[] n = new int[] { 66, 33, 56, 23, 81 };
                Console.WriteLine("enter the element");
                int element=Convert.ToInt32(Console.ReadLine());
                if (element>=n.Length)
                {
                    throw new IndexOutOfBounds("Sorry, Index is invalid !!!!");

                }
                else
                {
                    Console.WriteLine(n[element]);
                }

                Console.ReadKey();
            }
            catch (IndexOutOfBounds e)
            {
                Console.WriteLine(e);
            }

        }
    }
}