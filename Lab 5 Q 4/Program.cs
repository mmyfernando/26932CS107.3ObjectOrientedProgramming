using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Q_4
{
    internal class Program
    {
        static void Main(string[] args);
        }
             class SeparateClass
        {
            public void sayHello()
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }

    // Program.cs file


    namespace ConsoleApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                SeparateClass obj = new SeparateClass();
                obj.sayHello(); // This will work now
                Console.ReadLine();


            }
    }
}
