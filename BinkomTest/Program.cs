using System;

namespace BinkomTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person();
            Console.WriteLine();

            IsEven(25);  //prints Odd
            Console.WriteLine();

            PrintNumbers();
            Console.WriteLine();

            IntArray();
            Console.WriteLine();

            Greet("Alice");
            Console.WriteLine();

        }

        public static void Person()
        {
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Admin: " + isAdmin);
        }

        public static void IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void PrintNumbers()
        {
            Console.WriteLine("Print numbers 1-10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        
        public static void IntArray()
        {
            int[] numbers = new int[5] { 2, 4, 6, 8, 10 };

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            var sumElements = numbers.Sum();
            Console.WriteLine("Sum of elements = " + sumElements);
        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}