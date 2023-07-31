using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public void kilometerTOmeter()
            {
                double km, m;
                Console.Write("Enter a distance in kilometers: ");
                km = double.Parse(Console.ReadLine());
                m = km * 1000;
                Console.WriteLine(km + " kilometers is equal to " + m + " meters.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConvertValues converter = new ConvertValues();
            converter.kilometerTOmeter();
            Console.ReadLine();
        }
    }
}
