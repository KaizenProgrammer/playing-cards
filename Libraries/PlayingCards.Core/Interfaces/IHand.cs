using System.Collections.Generic;

namespace PlayingCards.Core
{
    public interface IHand {
        int CardCount { get; }

        void AddCard(ICard card);
    }

    public class PokerHand : IHand
    {
        List<PokerCard> cards;
        public PokerHand(){
            cards = new List<PokerCard>();
        }

        public int CardCount => cards.Count;

        public void AddCard(ICard card)
        {
            cards.Add((PokerCard)card);
        }
    }
}
