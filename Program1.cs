
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcceptEmployee // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n,empno,salary;
            string ename, designation;
            Console.WriteLine("enter the number of employee");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=n; i++)
            {
                Console.WriteLine("enter the employee number :");
                empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name :");
                ename=Console.ReadLine();
                Console.WriteLine("enter salary :");
                salary=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the designation");
                designation=Console.ReadLine();

                Console.WriteLine(" employee number :" + empno+" employee name {0}:"+ename+" employee salary"+salary+" employee designation {0} :"+designation);



            }    
        }
    }
}