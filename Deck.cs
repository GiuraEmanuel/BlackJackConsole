using System;
using System.Collections.Generic;

namespace BlackJackConsole
{
    class Deck
    {
        private List<Card> deck = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int k = 2; k <= 14; k++)
                {
                    string suit = "";
                    switch (i)
                    {
                        case 0: suit = "Club"; break;
                        case 1: suit = "Diamond"; break;
                        case 2: suit = "Spade"; break;
                        case 3: suit = "Heart"; break;
                    }
                    Card c = new Card(k, suit);
                    deck.Add(c);
                }
            }
        }
        public void PrintDeck()
        {
            var numberOfCards = deck.Count;
            Console.WriteLine("List size: {0}", numberOfCards);
            Console.WriteLine();
            foreach (var card in deck)
            {
                Console.WriteLine(/*"Card " + */card.value + /* + " Suit " + */" " + card.suit);
            }
        }
        /// <summary>
        /// shuffle the list of cards
        /// </summary>
        public void ShuffleDeck()
        {
            var r = new Random();
            for (int i = 0; i < deck.Count - 1; i++)
            {
                int k = r.Next(i + 1);
                var temp = deck[i];
                deck[i] = deck[k];
                deck[k] = temp;
            }
        }
        /// <summary>
        /// draws a card from the list(top of the list)
        /// and returns the drawn card
        /// </summary>
        /// <returns></returns>
        public Card DrawCard()
        {
            Card topCard = deck[0];
            deck.RemoveAt(0);
            //var count = 0;
            //foreach (var card in deck)
            //{
            //    count++;
            //}
            //Console.WriteLine("List size after drawing the top card: {0}", count);
            return topCard; // figure out how to return the top card in the specified format (value - suit)
        }
    }
}
