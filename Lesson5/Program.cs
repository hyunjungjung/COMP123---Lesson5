using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {

        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // List that represents deck of card

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
            DisplayDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spade";
                        break;
                }
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                } // end for - face
            }
            
        }public static void DisplayDeck(List<Card> deck)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                                         +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in deck)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
