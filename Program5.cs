
using System;
using System.Collections.Generic;
using System.Linq;

namespace operatorOverloading // Note: actual namespace depends on the project name.
{

    public class Student
    {
        int marks;
        public Student(int m)
        {
            marks = m;  
        }
        public static Student operator +(Student a,Student b)
        {
            Student res=new Student(0);
            res.marks = a.marks + b.marks;
            return res;
        }
        public static Student operator -(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks - b.marks;
            return res;
        }

        public static Student operator *(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks * b.marks;
            return res;
        }

        public static Student operator /(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks / b.marks;
            return res;
        }
        public static bool operator !=(Student a, Student b)
        {

            return a.marks != b.marks;

        }
        public static  bool operator ==(Student a, Student b)
        {

            return a.marks == b.marks;
            
        }
        public void printmarks()
        {
            Console.WriteLine(marks);
        }



    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student obj1 = new Student(70);
            Student obj2 = new Student(60);

            Student addresult = obj1 + obj2;
            Console.WriteLine("addresult");
            addresult.printmarks();

            Student subresult = obj1 - obj2;
            Console.WriteLine("subresult");
            subresult.printmarks();

            Student multresult = obj1 * obj2;
            Console.WriteLine("multresult");
            multresult.printmarks();

            Student divresult = obj1 / obj2;
            Console.WriteLine("divresult");
            divresult.printmarks();

            Console.WriteLine("student marks are equal : : " +(obj1 == obj2).ToString());
            Console.WriteLine("student marks are not equal  : : " +(obj1 != obj2).ToString());

            Console.ReadKey();
        }
    }
}