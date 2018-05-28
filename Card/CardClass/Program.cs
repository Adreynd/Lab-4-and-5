using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingConstructor();
            TestingSuit();
            TestingRedBlack();
            TestingValue();
            TestingAceFace();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestingConstructor()
        {
            Card c1 = new Card('H', 7);
            Card c2 = new Card();

            Console.WriteLine("Testing constructors.");
            Console.WriteLine("Default constructor. Expecting a blank card.");
            Console.WriteLine("Getting " + c2.ToString() + ".");
            Console.WriteLine("Overloaded constructor. Expecting a seven of hearts.");
            Console.WriteLine("Getting " + c1.ToString());
            Console.WriteLine();
        }

        static void TestingSuit()
        {
            Card c1 = new Card();
            c1.Suit = 'H';

            Console.WriteLine("Testing set/get suit.");
            Console.WriteLine("Expecting a card of the heart suit.");
            Console.WriteLine("Getting a " + c1.Suit);
            Console.WriteLine();

            Card c2 = new Card('D', 5);
            Card c3 = new Card('S', 11);
            Card c4 = new Card('C', 1);


            Console.WriteLine("Testing bool methods for each suit.");

            Console.WriteLine("Testing IsHeart, expecting a heart.");
            if (c1.IsHeart())
                Console.WriteLine("Got a heart.");
            else
                Console.WriteLine("Didn't get a heart.");
            Console.WriteLine("Testing IsHeart, expecting not a heart.");
            if (!c3.IsHeart())
                Console.WriteLine("Didn't get a heart.");
            else
                Console.WriteLine("Got a heart.");
            Console.WriteLine();

            Console.WriteLine("Testing IsDiamond, expecting a diamond.");
            if (c2.IsDiamond())
                Console.WriteLine("Got a diamond.");
            else
                Console.WriteLine("Didn't get a diamond.");
            Console.WriteLine("Testing IsDiamond, expecting not a diamond.");
            if (!c1.IsDiamond())
                Console.WriteLine("Didn't get a diamond.");
            else
                Console.WriteLine("Got a diamond.");
            Console.WriteLine();

            Console.WriteLine("Testing IsSpade, expecting a spade.");
            if (c3.IsSpade())
                Console.WriteLine("Got a spade.");
            else
                Console.WriteLine("Didn't get a spade.");
            Console.WriteLine("Testing IsDiamond, expecting not a spade.");
            if (!c1.IsSpade())
                Console.WriteLine("Didn't get a spade.");
            else
                Console.WriteLine("Got a spade.");
            Console.WriteLine();

            Console.WriteLine("Testing IsClub, expecting a club.");
            if (c4.IsClub())
                Console.WriteLine("Got a club.");
            else
                Console.WriteLine("Didn't get a club.");
            Console.WriteLine("Testing IsDiamond, expecting not a club.");
            if (!c3.IsClub())
                Console.WriteLine("Didn't get a club.");
            else
                Console.WriteLine("Got a club.");
            Console.WriteLine();
        }

        static void TestingRedBlack()
        {
            Card c1 = new Card('H', 7);
            Card c2 = new Card('S', 3);


            Console.WriteLine("Testing IsRed.");
            Console.WriteLine("Expecting a card of a red suit.");
            if (c1.IsRed())
                Console.WriteLine("Got a red suit.");
            else
                Console.WriteLine("Didn't get a red suit.");

            Console.WriteLine("Testing IsRed on a black card, expecting not a red card.");
            if (!c2.IsRed())
                Console.WriteLine("Didn't get a red suit.");
            else
                Console.WriteLine("Got a red suit.");
            Console.WriteLine();



            Console.WriteLine("Testing IsBlack.");
            Console.WriteLine("Expecting a card of a black suit.");
            if (c2.IsBlack())
                Console.WriteLine("Got a black suit.");
            else
                Console.WriteLine("Didn't get a black suit.");

            Console.WriteLine("Testing IsBlack on a red card, expecting not a black card.");
            if (!c1.IsBlack())
                Console.WriteLine("Didn't get a black suit.");
            else
                Console.WriteLine("Got a black suit.");
            Console.WriteLine();
        }

        static void TestingValue()
        {
            Card c1 = new Card();
            c1.Value = 5;

            Console.WriteLine("Testing set/get value.");
            Console.WriteLine("Expecting a card with the number 5.");
            Console.WriteLine("Getting a " + c1.Value);
            Console.WriteLine();
        }
        

        static void TestingAceFace()
        {
            Card c1 = new Card('C', 1);
            Card c2 = new Card('C', 11);
            Card c3 = new Card('C', 12);
            Card c4 = new Card('C', 13);
            Card c5 = new Card('C', 7);

            Console.WriteLine("Testing IsAce.");
            Console.WriteLine("Expecting an Ace.");
            if (c1.IsAce())
                Console.WriteLine("Got an ace.");
            else
                Console.WriteLine("Didn't get an ace");

            Console.WriteLine("Testing IsAce on a non ace card.");
            Console.WriteLine("Expecting not an ace.");
            if (!c4.IsAce())
                Console.WriteLine("Not an ace.");
            else
                Console.WriteLine("Got an ace.");
            Console.WriteLine();

            Console.WriteLine("Testing IsFace.");
            Console.WriteLine("Testing a joker, expecting IsFace to return true.");
            if (c2.IsFaceCard())
                Console.WriteLine("Card is face card.");
            else
                Console.WriteLine("Card wasn't face card.");

            Console.WriteLine("Testing a queen, expecting IsFace to return true.");
            if (c3.IsFaceCard())
                Console.WriteLine("Card is face card.");
            else
                Console.WriteLine("Card wasn't face card.");

            Console.WriteLine("Testing a king, expecting IsFace to return true.");
            if (c4.IsFaceCard())
                Console.WriteLine("Card is face card.");
            else
                Console.WriteLine("Card wasn't face card.");

            Console.WriteLine("Testing a 7, expecting IsFace to return false.");
            if (!c5.IsFaceCard())
                Console.WriteLine("Card is not a face card.");
            else
                Console.WriteLine("Card is a face card.");
        }
    }
}
