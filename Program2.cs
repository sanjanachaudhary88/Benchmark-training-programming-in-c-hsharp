using System;
using System.Collections.Generic;
using System.Linq;

namespace sealedClassExm // Note: actual namespace depends on the project name.
{
    class parent
    {
        public virtual void Demo()
        {
            Console.WriteLine("parent demo");
        }
    }
    class child : parent
    {
        public sealed override void Demo()
        {
            Console.WriteLine("child demo");
        }

    }
    //grandchild1 cannot be overidden because child class is sealed so that it cannot be changed by someone else
   /* class Grandchild1 : child
    {
        public override void Demo()
        {
            Console.WriteLine("child demo");
        }

    }*/

    class Grandchild : parent
    {
        public override void Demo()
        {
            Console.WriteLine("grandchild demo");
        }

    }
   
    public class Program
    {
        public static void Main(string[] args)
        {
            parent p=new parent();
            p.Demo();

            child c=new child();
            c.Demo();
            Grandchild g=new Grandchild();
            g.Demo();
        }
    }
}