using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Q_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
             class ArrayOperations
        {
            public void UserInput(int[] arr)
            {
                Console.WriteLine("Enter " + arr.Length + " integer values:");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Value " + (i + 1) + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("0");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the size of the array: ");
                int size = int.Parse(Console.ReadLine());

                int[] arr = new int[size];
                ArrayOperations calculator = new ArrayOperations();
                calculator.UserInput(arr);

                Console.WriteLine("The values in the array are: " + string.Join(" ", arr));
                Console.ReadLine();
            }
    }
}
