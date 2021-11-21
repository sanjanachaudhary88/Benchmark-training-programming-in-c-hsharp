using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Q4 // Note: actual namespace depends on the project name.
{
    public class InvalidNumException : Exception
    {
        public InvalidNumException(String message)
            : base(message)
        {

        }
    }
    class DivNumbers
    {
        double result;

        public void division()
        {
            double num1, num2;

            try
            {
                Console.WriteLine("enter num1");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter num2");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0) 
                {
                    throw new InvalidNumException("Sorry,Numerator  cannot be 0  !!");
                }
                else
                {
                    
                 
                    result = num1 / num2;

                }
                
            }
            catch (InvalidNumException e) 
            { 
                Console.WriteLine(e);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught :{0}", ex);

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