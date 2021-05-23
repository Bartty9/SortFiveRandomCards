using System;
using System.Collections.Generic;
using System.Text;

namespace SortowanieKart
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
