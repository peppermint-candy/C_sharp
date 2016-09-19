// Optional OOP Adv

// Interfaces - make a clsas seem like it inherits from a different class so that it might be able to be passed in a similar manner
// interface is constructed like a class but becomes the requirements of a classes construction rather than something you create objects from
// In an interface you define some methods and variable frields. 
// From there any class that implements an interface must have these methods and fields

using System;

namespace ConsoleApplication
{

    interface CanRun

    {
        int Run();
    }

    class Goat : CanRun
    {
        public int Run()
        {
            Console.WriteLine("I'm a goat running~");
            return 1;
        }
    }

    class Bird
    {
        // well most birkds don't run
    }

    class Ostrich : Bird, CanRun
    {
        public int Run()
        {
            Console.WriteLine("I'm a running bird ..... .crazy");
            return 1;
        }
    }

    public class ShoppingCart
    {
        public List<Product> Products { get; set;}
    }

    //This is the wrapper for our extension (Note the static keyword)
    public static class MyExtensionMethods
    {
        // note how the parameters for the new function is previous class
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                {
                    total += prod.Price;
                }
                return total;
            }
        }

        public static double MarathonDistance(this CanRun creature)
        {
            creature.Run();
            Console.WriteLine("I'm running a marathon now!");
            return 26.2;
        }
    }
}

