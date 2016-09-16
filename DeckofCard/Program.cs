using System;

namespace ConsoleApplication
{
    public class Program
    {

        // ------------ CARD CLASS ---------------

        public class Card 
        {
            // public string[] Value = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            // public string[] suit = {"C", "S", "H", "D"};
            // public int[] numerical_value = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            // public string s_suit;
            // public string s_value;

            public string Value;
            public string Suit;
            public int numerical_value;
            public Card(string card_suit, string card_value)
            {
                Suit = card_suit;
                Value = card_value;
                // numerical_value = num_card;
            }


        }

        // ------------ END CARD CLASS -----------


        // ------------ DECK CLASS ---------------

        public class Deck 
        {
            public Card[] cards;
            
            public Deck()
            {
                cards = new Card[52];
                var index = 0;

                foreach (string suit in new [] { "Spades", "Hearts", "Clubs", "Diamonds"})
                {
                    foreach (string Value in new [] {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" })
                    {
                        cards[index] = new Card(suit, Value);
                        index ++;
                        
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
            // Card test = new Card();
            Deck newDeck = new Deck();

            Console.WriteLine(newDeck.cards);

        }
    }
}
