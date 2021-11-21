using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Q4 // Note: actual namespace depends on the project name.
{
    class DivNumbers
    {
        int result;

        public void division()
        {
            
            try
            {
                int num1, num2;
                Console.WriteLine("enter num1");
                num1 =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter num2");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception caught :{0}",ex);

            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division();
            Console.ReadKey();
        }
    }
}