using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Q_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class Animal
        {
            public void AnimalMethod()
            {
                Console.WriteLine("I am an Animal");
            }
        }

        class Dog : Animal
        {
            public void DogMethod()
            {
                Console.WriteLine("I have four legs");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Dog myDog = new Dog();
                myDog.AnimalMethod();
                myDog.DogMethod();

                Console.ReadLine();
            }
    }
}
