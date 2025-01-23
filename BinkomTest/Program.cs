using System;

namespace BinkomTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Admin: " + isAdmin);

            IsEven(25);  //prints Odd

            PrintNumbers();

            Array();

            Greet("Alice");
            
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
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Array()
        {
            int[] evenNumbers = new int[5] { 2, 4, 6, 8, 10 };
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}