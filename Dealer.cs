using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole
{
    class Dealer : Deck
    {
        #region Properties
        public List<Card> Hand { get; set; }
        public int CurrentHandScore { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// draws card from the collection of cards
        /// </summary>
        public void Hit()
        {
            if (CurrentHandScore <= 17)
            {
                DrawCard();
                //figure out how to add cards to the Hand property
            }
        }

        /// <summary>
        /// dealer deals cards to both player and himself
        /// one card for each
        /// </summary>
        public void DealCards()
        {
            DrawCard();
        }

        /// <summary>
        /// Shuffles the cards after half of them have been played
        /// adding them back into the collection    
        /// </summary>
        public void ShuffleCards()
        {

        }
        #endregion
    }
}
