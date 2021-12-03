using System;
using System.IO;

namespace Assignment4Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\user\\source\\repos\\Animalbstract");

            if (di.Exists)
            {
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.Parent);
                Console.WriteLine(di.LastWriteTime);
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    Console.WriteLine(di.FullName);
                    Console.WriteLine(di.Extension);
                    Console.WriteLine(di.CreationTime);


                }
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created");
            }
            Console.ReadKey();
        }
    }
}
