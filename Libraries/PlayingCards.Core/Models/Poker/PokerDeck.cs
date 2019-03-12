namespace PlayingCards.Core
{
    public class PokerDeck : CardDeck
    {
        public PokerDeck()
        {
            Cards = new PokerCard[52];
            int index = 0;
            for (int i = 1; i < 14; i++)
            {
                Cards[index] = new PokerCard(Suit.Spades, i);
                Cards[++index] = new PokerCard(Suit.Hearts, i);
                Cards[++index] = new PokerCard(Suit.Diamonds, i);
                Cards[++index] = new PokerCard(Suit.Clubs, i);
                index++;
            }
        }


    }
}
