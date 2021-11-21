// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Q1
{
    public abstract class Account 
    {
        public abstract double calculateInterest();
    }

    class savings : Account
    {
        public override double calculateInterest()
        {
            double interest, dailyBalance, RateOfInterest, NoOfDays;
            Console.WriteLine("enter the daily balance");
            dailyBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            RateOfInterest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the number of days");
            NoOfDays = Convert.ToDouble(Console.ReadLine());
            interest = dailyBalance * RateOfInterest * (NoOfDays / 365);
            
            Console.WriteLine("the interset of savings account is "+interest);    
            return interest;
        }
    } 
    class current: Account
    {
        public override double calculateInterest()
        {
            double Interest, Principal, RateOfInterest,T;
            Console.WriteLine("enter the Principal");
            Principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            RateOfInterest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the T");
            T = Convert.ToDouble(Console.ReadLine());

            Interest = Principal * RateOfInterest * T;
            Console.WriteLine("the interset of Current account is "+ Interest);
            return Interest;
        }

    }

    class FD :Account
    {
        public override double calculateInterest()
        {
            double Interest, Principal, RateOfInterest;
            Console.WriteLine("enter the Principal");
            Principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            RateOfInterest = Convert.ToDouble(Console.ReadLine());
            Interest = Principal * RateOfInterest;
            Console.WriteLine("the interset of FD account is "+ Interest);

            return Interest;

        }
    }
    
    public class program
    {
        public static void Main(string []args)
        {
            savings  s= new savings();
            s.calculateInterest();
            current c = new current();
            c.calculateInterest();
            FD fd = new FD();
            fd.calculateInterest();

        }
    }
}