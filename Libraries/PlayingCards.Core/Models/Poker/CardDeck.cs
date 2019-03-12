using System;

namespace PlayingCards.Core
{
    public abstract class CardDeck : ICardDeck
    {
        private Random rand;
        public CardDeck()
        {

            rand = new Random(Guid.NewGuid().GetHashCode());
        }
        private ICard[] cards;

        public ICard[] Cards { get { return cards; } set { cards = value; } }

        public IHand[] Deal(IDealer dealer)
        {
            var hands = new IHand[dealer.HandCount];

            dealer.SetCards(cards);

            while (dealer.CanDeal())
            {
                for (var i=0; i< dealer.HandCount; i++)
                {
                    if(hands[i]==null){
                        hands[i]=dealer.CreateHand();
                    }
                    if (dealer.CanDeal(hands[i]))
                    {
                        hands[i].AddCard(dealer.GetCard());
                    }
                }
            }
            return hands;

        }

        public void Shuffle(int numOfTimes)
        {
            for (int i = 0; i < numOfTimes; i++)
            {
                YatesShuffle();
            }
        }

        private void YatesShuffle()
        {
            for (byte i = 0; i <= cards.Length - 2; i++)
            {
                int j = rand.Next(cards.Length - i);
                if (j > 0)
                {
                    ICard curVal = cards[i];
                    cards[i] = cards[i + j];
                    cards[i + j] = curVal;
                }
            }
            for (int i = cards.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                if (j != i)
                {
                    ICard curVal = cards[i];
                    cards[i] = cards[j];
                    cards[j] = curVal;
                }
            }

        }
    }
}
