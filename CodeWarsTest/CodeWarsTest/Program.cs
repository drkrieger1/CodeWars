using System;

namespace CodeWarsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code wars Kata");

            FindPrime();
            Console.Read();
        }
        static void FindPrime()
        {
            Console.WriteLine("Enter a number");

            int input = int.Parse(Console.ReadLine());

            if (Prime.IsPrime(input))
            {
                Console.WriteLine($"{input} is a Prime number!!");
            }
            else
            {
                Console.WriteLine($"Sorry {input} is not a Prime Number");
            }
        }
    }
}
