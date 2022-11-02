using Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carts
{
    internal class Deka
    {
        Card.Card card = new Card.Card();
        private Card.Card[] a = new Card.Card[36];
        private List<Card.Card> cards = new List<Card.Card>(36);
        public void CreateDeck()
        {
            cards = new List<Card.Card>(36);
            for (int i = 0; i <= 36;)
            {
                card.CreateCard();
                var c = card;
                if (false == cards.Contains(c))
                {

                    cards.Add(card);
                    i++;
                }
            }
        }
        public void GetDeck()
        {
            foreach (Card.Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}