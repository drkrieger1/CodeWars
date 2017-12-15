using System;

namespace CodeWarsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code wars Kata");

            //FindPrime();

            LikeCount();
            Console.Read();
        }
       
        //find if a number is prime 
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

        //This is to run the like counter method
        static void LikeCount()
        {
            string[] names1 = { "Erik", "Lindsey", "Kirill", "Albert" };
            string[] names2 = { "Erik", "Lindsey", "Kirill"};
            string[] names3 = { "Erik", "Lindsey"};
            string[] names4 = { "Erik"};

            Console.WriteLine(WhoLikesThis.Likes(names1));
            Console.WriteLine(WhoLikesThis.Likes(names2));
            Console.WriteLine(WhoLikesThis.Likes(names3));
            Console.WriteLine(WhoLikesThis.Likes(names4));
        }

    }
}
