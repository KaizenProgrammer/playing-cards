using System;

namespace PlayingCards.Core
{
    public interface ICardDeck
    {
        void Shuffle(int numOfTimes);
        IHand[] Deal(int numOfHands);
        
    }
    public class PokerDeck : ICardDeck
    {
        private ICard[] cards;

        
        public IHand[] Deal(int numOfHands)
        {
            throw new NotImplementedException();
        }

        public void Shuffle(int numOfTimes)
        {
            throw new NotImplementedException();
        }
    }

    public class PokerCard : ICard {
        public Suit suit { get; set; }  
        public string value {get;set;}

        public bool CanPlay()
        {
            throw new NotImplementedException();
        }
    }

public enum Suit {
    Spades,
    Hearts,
    Diamonds,
    Clubs
}
    public interface IHand {
        void AddCard(ICard card);
    }

    public interface ICard {
        bool CanPlay();
    }
}
