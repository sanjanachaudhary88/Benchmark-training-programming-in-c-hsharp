using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee // Note: actual namespace depends on the project name.
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            employeeData e = new employeeData();
            e.getdata();
            e.print();
            Console.ReadLine();
            
        }
        public class employeeData
        {
            int empno, salary;
            String ename, designation;
            public void setdata(int empno, int salary, string ename, string designation)
            {

                this.empno = empno;
                this.salary = salary;
                this.designation = designation;
                this.ename = ename;

            }
            public void getdata()
            {
                Console.WriteLine("enter employee number");
                this.empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name");
                this.ename = Console.ReadLine();
                Console.WriteLine("enter employee salary");
                this.salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee designation");
                this.designation =Console.ReadLine();
           

            }
            public void print()
            {
                Console.WriteLine("\n");
                Console.WriteLine("the employee details are \n");
                Console.WriteLine("enmployee number is     :"+this.empno);
                Console.WriteLine("employee name is        :"+this.ename);
                Console.WriteLine("employee salary is      :"+this.salary);
                Console.WriteLine("employee designation is :"+this.designation);
            }
        }

    }
}