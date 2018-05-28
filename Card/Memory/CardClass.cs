using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    class Card
    {
        private char suit;
        private char[] suits = {'H', 'D', 'S', 'C'};
        private int value;
        private int[] values = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        
        public Card() { }

        public Card(char s, int v)
        {
            suit = s;
            value = v;
        }

        public char Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public bool IsBlack()
        {
            return suit == suits[2] || suit == suits[3];
        }

        public bool IsRed()
        {
            return suit == suits[0] || suit == suits[1];
        }

        public bool IsAce()
        {
            return value == values[0];
        }

        public bool IsSpade()
        {
            return suit == suits[2];
        }

        public bool IsClub()
        {
            return suit == suits[3];
        }

        public bool IsHeart()
        {
            return suit == suits[0];
        }

        public bool IsDiamond()
        {
            return suit == suits[1];
        }

        public bool IsFaceCard()
        {
            return value == values[10] || value == values[11] || value == values[12];
        }

        public override string ToString()
        {
            return value.ToString() + suit.ToString();
        }
    }
}
