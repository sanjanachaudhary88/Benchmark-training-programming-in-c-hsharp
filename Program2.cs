using System;
using System.Collections.Generic;


namespace Assignment4Q2
{
    public class employee
    {
        public int empid;
        public string empname, designation;
    }
    class main
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                employee e = new employee();
                var emp = new List<employee>();
                Console.WriteLine("enter employee id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee name");
                string ename = Console.ReadLine();
                Console.WriteLine("enter employee designation");
                string de = Console.ReadLine();
                e.empname = ename;
                e.designation = de;
                e.empid = id;
                emp.Add(e);
                Console.WriteLine(e.empid);
                Console.Write(e.empname);
                Console.WriteLine(e.designation);

            }
            Console.ReadKey();



        }

    }
}
