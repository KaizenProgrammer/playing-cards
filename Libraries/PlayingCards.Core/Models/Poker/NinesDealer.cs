using System.Collections.Generic;

namespace PlayingCards.Core
{
    public class NinesDealer : IDealer
    {
        int handCount=0;
        bool stopDealing=false;
        public NinesDealer(int numberOfPlayers){
            handCount=numberOfPlayers;
        }
        Stack<ICard> cards = new Stack<ICard>();
        public int HandCount => handCount;

        public bool CanDeal(IHand hand)
        {
            if(hand.CardCount >= 9){
                //Hands filled;
                stopDealing=true;
            }
            return hand.CardCount < 9 ;
        }

        public bool CanDeal()
        {            
            return cards.Count>0 && !stopDealing;
        }

        public ICard GetCard()
        {
            return cards.Pop();
        }

        public void SetCards(ICard[] cards)
        {
            this.cards=new Stack<ICard>();
            foreach(var card in cards){
                this.cards.Push(card);
            }
        }

        public IHand CreateHand()
        {
            return new PokerHand();
        }
    }
}
