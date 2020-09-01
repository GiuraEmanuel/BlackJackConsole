﻿using System;
namespace BlackJackConsole
{
    class Card
    {
        public int value;
        public string suit;

        public Card(int val, string sui)
        {
            value = val;
            suit = sui;
        }

        public override string ToString()
        {
            return $"{value} of {suit}";
        }
    }
}
