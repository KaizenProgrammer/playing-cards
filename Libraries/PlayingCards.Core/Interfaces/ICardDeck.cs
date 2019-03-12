namespace PlayingCards.Core
{
    public interface ICardDeck
    {
        void Shuffle(int numOfTimes);
        IHand[] Deal(IDealer dealer);
        ICard[] Cards { get; set; }
    }
}
