
using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceExample // Note: actual namespace depends on the project name.
{
    class Employee
    {
        int empno;
        string ename, desig;
        public Employee(int empon,string ename,string desig)
        {
            this.empno= empon;
            this .ename = ename;
            this.desig = desig;

        }
        public void Printdata()
        {
            Console.WriteLine(empno + " " + ename + "" + desig);
        }
    }

    class PermanentEmp : Employee //permanentEmp is child class and employee is parent class
    {
        double basicsal;
        public PermanentEmp(int empno,string ename,string desig,double basicsal):base(empno,ename,desig)
        {
            this.basicsal= basicsal;
        }
        public void Printdata()
        {
            base.Printdata();
            Console.WriteLine(basicsal);
        }
    }

    class WegedEmp : Employee //permanentEmp is child class and employee is parent class
    {
        double noofhour,hourlyamt;
        public WegedEmp(int empno, string ename, string desig, double noofhour,double hourlyamt) : base(empno, ename, desig)
        {
            this.noofhour=noofhour;
            this.hourlyamt=hourlyamt;   
        }
        public void Printdata()
        {
            base.Printdata();
            Console.WriteLine(noofhour);
            Console.WriteLine(hourlyamt);
        }
    }

    //main class
    public class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmp Pemp1 = new PermanentEmp(111, "puru", "manager",100000);
            WegedEmp Wemp2 = new WegedEmp(411, "akash", "CEO", 14, 2000);
            Console.WriteLine("permanent employee");
            Pemp1.Printdata();
            Wemp2.Printdata();


        }
    }
}