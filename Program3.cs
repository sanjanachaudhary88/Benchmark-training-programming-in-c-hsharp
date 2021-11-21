
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Q3 // Note: actual namespace depends on the project name.
{
    public interface printInterface
    {
        void IPrintable();
        void print();

    }

    class Account:printInterface
    {
        public void IPrintable()
        {
            Console.WriteLine("IPrintable method from account class ");
        }
        public void print()
        {
            Console.WriteLine("Print method from account class ");
        }
       

    }

    class Employee : printInterface
    {
        public void IPrintable()
        {
            Console.WriteLine("IPrintable method from Employee class ");
        }
        public void print()
        {
            Console.WriteLine("Print method from Employee class ");
        }

    }

   
    public class Program
    {
        public void Call_printinterface(printInterface p)
        {
            p.IPrintable();
            p.print();
            
        }
        public static void Main(string[] args)
        {
            Account a = new Account();
            Employee e = new Employee();
            Program p = new Program();
            Console.WriteLine("Account class");
            p.Call_printinterface(a);
            Console.WriteLine("*************************");
            Console.WriteLine("Employee class");
            p.Call_printinterface(e);
            

            Console.ReadKey();
        }
    }
}