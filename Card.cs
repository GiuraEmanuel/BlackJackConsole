using System;
namespace BlackJackConsole
{
    class Card
    {
        public int Value { get;}
        public CardSuit Suit { get;}

        public Card(int value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return  $"Card {Value}";
        }
    }

    enum CardSuit
    {
        Club,
        Diamond,
        Spade,
        Heart
    }
}
