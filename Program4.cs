using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeProperties // Note: actual namespace depends on the project name.
{
    public class Program
    {
        // public class
        public class C1
        {

            // public data members
            public int empno,salary;
            public string ename,designation;

            // private field
            // private int marks = 35;

        }
        public static void Main(string[] args)
        {
            C1 obj = new C1();

            // setting values to public
            // data members of class C1
            obj.empno = 101;
            obj.ename = "sanjana";
            obj.salary = 10000;
            obj.designation="intern";

            // setting values to private
            // data members of class C1
            // obj.mark = 0;

            // display result
            Console.WriteLine("employee number  {0} \n:employee name {1} \n:employee salary {3} \n:employee deisgnation {4}", obj.empno,obj.ename,obj.salary,obj.designation);
        }
    }
}