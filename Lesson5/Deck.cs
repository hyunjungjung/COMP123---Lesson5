using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    /**
     * <summary>
     * This class extends the List<Card> generic type
     * </summary>
     * 
     * @class Deck
     */
    public class Deck : List<Card>
    {

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the default constructure for the Deck class
         * </summary>
         * 
         * @constructor Deck
         */
        public Deck()
        {
            // create my deck of cards
            this._create();

        }
        // PUBLIC STATIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @method _create
         * @returns {void}
         */
        private void _create()
        {

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit));
                }
            }

        }
        /**
         * <summary>
         * This method displays a list of Card objects to the Console
         * </summary>
         * 
         * @method DisplayDeck
         * @returns {void}
         */
        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                                         +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
        /**
         * <summary>
         * This method randomly shuffles a list of Card objects
         * </summary>
         * 
         * @method Shuffle
         * @returns {void}
         */
        public void Shuffle()
        {
            // creates a pseudo-random number sequence and stroes it in random
            Random random = new Random();
            // record the number of cards in the deck list
            int cardCount = this.Count;
            Console.WriteLine("card count :{0}", cardCount);
            // Iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; // copy current card to temp location
                int randomCard = random.Next(0, cardCount); // get a random card index
                this[currentCard] = this[randomCard]; // copy value from randomCard to currentCard
                this[randomCard] = tempCard; // copy currentCard to randomCard
            }
        }

        /**
         * <summary>
         * This method will remove the 0th item from the deck and return it to the caller
         * </summary>
         * 
         * @method Deal
         * @returns {Card}
         */
        public Card Deal()
        {

            Card returnCard = this[0]; // copy the 0th card in the stack to the returnCard

            this.RemoveAt(0); // remove the 0th card from the deck

            return returnCard;
        }
    }
}
