using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.BL
{
    public enum Chips
    {
        whiteChip = 1,
        redChip = 5,
        greenChip = 25,
        blueChip = 50,
        blackChip = 100,
        purpleChip = 500,
        yellowChip = 1000
    }
    class Player : Deck
    {
        #region Properties
        public List<Card> Hand { get; set; } //a list containing drawn cards by the player
        public Player(string name, int balance)
        {
            Name = name;
            Balance = balance; //figure how to set up the starting balance(the money player starts with)
        }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int CurrentHandScore { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// if the player wins the round then add the bet amount to its current balance
        /// otherwise subtract it from current balance
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int UpdatePlayerBalance(int value)
        {
            return 0;
        }

        /// <summary>
        /// the ammount to bet
        /// subtract specified value from Balance as bet
        /// </summary>
        /// <param name="bet"></param>
        /// <returns></returns>
        public void PlaceBet(int bet) //method incomplete
        {
            Balance -= bet; 
        }

        /// <summary>
        ///  draw a card from a shuffled card collection
        /// </summary>
        public void Hit()
        {
            DrawCard();
            //Hand.Add(); ?? figure out how add the drawn card to the Hand property
        }

        /// <summary>
        /// pass control to the dealer
        /// </summary>
        public void Stand()
        {

        }

        /// <summary>
        /// check if players cards have the same value
        /// if true split the hand in 2 separated hands
        /// played with same rules as a normal hand
        /// </summary>
        public void Split()
        {

        }

        /// <summary>
        /// place another bet equal to your initial bet
        /// draw 1 more only card before passing control to the dealer
        /// </summary>
        public void DoubleDown()
        {
            
        }

        /// <summary>
        /// player gets back half of his bet and the round is forfeited
        /// </summary>
        public void Surrender()
        {
            
        }

        /// <summary>
        /// place another bet worth half of your original stake after the cards have been dealt
        /// only if the dealer's face-up card is ace
        /// if dealer has no blackjack the insurance bet is lost otherwise
        /// if dealer has blackjack he wins the game but you win the insurance
        /// </summary>
        public void PlaceInsurance()
        {
             
        }
        #endregion
    }
}
