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
            public Card[] deck;
            
            public Deck()
            {
                deck = new Card[52];
                Card cardSet = new Card();
                int value_counter = cardSet.value.Length;

                for (int i = 0; i < deck.Length; i++)
                {
                    for (int j = 0; j < cardSet.suit.Length; j++)
                    {
                        deck[i] = cardSet.suit[j];   
                    }
                }

                
                

            }
                // this property should have 52 unique cards 


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
            Card test = new Card();
            Deck newDeck = new Deck();

            Console.WriteLine(test.suit);
        }
    }
}
