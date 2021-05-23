using System;
using System.Collections.Generic;

namespace SortowanieKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Pięć losowych kart:\n");

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)rand.Next(4), (Values)rand.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }
            
            Console.WriteLine("\nKarty posortowane:\n");
            //CardComparer_byValue comparer_ByValue = new CardComparer_byValue();
            cards.Sort(new CardComparer_byValue());
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }
    }
}
