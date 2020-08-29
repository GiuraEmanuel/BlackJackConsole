using System.Collections.Generic;
using System;
namespace BlackJackConsole
{
    class Player : Deck
    {
        public Player(string name, int balance)
        {
            Name = name;
            //Hand = new List<Card>();
            Balance = balance; 
        }
        #region Properties
        public List<Card> Hand { get; set; } = new List<Card>(); //a list containing the first 2 dealt cards by the dealer + the drawn cards by the player
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
        public int UpdatePlayerBalance()
        {
            return Balance;
        }

        /// <summary>
        /// the ammount to bet
        /// subtract specified value from Balance as bet
        /// </summary>
        /// <param name="bet"></param>
        /// <returns></returns>
        public int PlaceBet(int bet) //incomplete method
        {
            Balance -= bet;
            return bet;
        }

        /// <summary>
        ///  draw a card from a shuffled card collection
        /// </summary>
        public void Hit()
        {
            Hand.Add(DrawCard());
            Console.WriteLine("Number of cards in the list: " + Hand.Count);
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
