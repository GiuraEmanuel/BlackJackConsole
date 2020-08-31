using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole
{
    class Dealer : Deck
    {
        #region Properties
        public List<Card> Hand { get; set; } = new List<Card>();
        public int DealerHandScore { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// draws card from the collection of cards
        /// </summary>
        public void Hit()
        {
            if (DealerHandScore <= 17)
            {
                Hand.Add(DrawCard());
            }
        }

        /// <summary>
        /// dealer deals cards to both player and himself
        /// one card for each
        /// </summary>
        public void DealCards()
        {
           
        }

        /// <summary>
        /// Shuffles the cards after half of them have been played
        /// adding them back into the collection
        /// only at the end of a round
        /// </summary>
        public void ShuffleCards()
        {
            ShuffleDeck();
        }
        #endregion
    }
}
