namespace PlayingCards.Core
{
    public interface IDealer
    {
        int HandCount { get; }

        void SetCards(ICard[] cards);
        bool CanDeal(IHand hand);
        ICard GetCard();
        bool CanDeal();
        IHand CreateHand();
    }
}