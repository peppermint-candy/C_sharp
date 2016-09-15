using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < 100; j++)
            {
                if (j % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }

                if (j % 5 == 0 )
                {
                    Console.WriteLine("Buzz");
                }

                if ( j % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");                 
                }
            }
        }
    }
}
