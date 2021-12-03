using System;
using System.Collections.Generic;

namespace Assingment4Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "sanjana");
            dict.Add(2, "purvesh");
            dict.Add(3, "vaish");
            dict.Add(4, "priyanka");



            foreach (KeyValuePair<int, string> de in dict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }


            Console.ReadKey();
        }
    }
}