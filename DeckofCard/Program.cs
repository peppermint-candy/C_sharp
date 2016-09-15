using System;

namespace ConsoleApplication
{
    public class Program
    {

        // ------------ CARD CLASS ---------------

        public class Card 
        {
            public string[] value = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            public string[] suit = {"C", "S", "H", "D"};
            public int[] numerical_value = {1,2,3,4,5,6,7,8,9,10,11,12,13};

        }

        // ------------ END CARD CLASS -----------


        // ------------ DECK CLASS ---------------

        public class Deck 
        {
            public Card cards; 

            public void deal()
            {
                // this method select the top-most card, removes it, and returns it
            }

            public void reset()
            {
                //this method reset the cards property to contain the original 52 cards
            }

            public void shuffle()
            {
                // this method randomly reorders the deck's cards
            }
            
        }

        // ------------ END DECK CLASS -----------

        
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
