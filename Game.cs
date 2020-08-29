namespace BlackJackConsole
{
    class Game
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.ShuffleDeck();
            Player p = new Player("Emanuel", 1000);
            p.PlaceBet(250);
            p.Hit();
        }

        #region Methods
        /// <summary>
        /// checks whether the player or dealer has won
        /// </summary>
        public void Win()
        {

        }

        /// <summary>
        /// determine if both player and dealer have the same number of points
        /// if so the round ends in a draw
        /// </summary>
        public void Draw()
        {

        }

        /// <summary>
        /// pass control from player to dealer and viceversa
        /// </summary>
        public void PassControl()
        {

        }
        #endregion
    }
}
