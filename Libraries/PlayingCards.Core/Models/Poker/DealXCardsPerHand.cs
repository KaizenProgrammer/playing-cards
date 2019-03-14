using System;
using System.Collections.Generic;

namespace PlayingCards.Core
{
    public class DealXCardsPerHand : IDealer
    {
        int handCount=0;
        int maxCardCount=0;
        bool stopDealing=false;
        public DealXCardsPerHand(int numberOfPlayers, int numberOfCardsPerPlayer){
            handCount=numberOfPlayers;
            maxCardCount=numberOfCardsPerPlayer;
        }
        Stack<ICard> cards = new Stack<ICard>();
        public int HandCount => handCount;

        public bool CanDeal(IHand hand)
        {
            if(hand.CardCount >= maxCardCount){
                //Hands filled;
                stopDealing=true;
            }
            return hand.CardCount < maxCardCount ;
        }

        public bool CanDeal()
        {       
            return cards.Count>0 && !stopDealing;
        }

        public ICard GetCard()
        {
            return cards.Pop();
        }

        public ICard[] GetRemainingCards(){
           return cards.ToArray();
        }

        public void SetCards(ICard[] cards)
        {
            if(cards.Length / this.maxCardCount < this.handCount){
                throw new Exception($"Dealer does not have enough cards to deal {handCount} hands. Need {maxCardCount*handCount} cards but only have {cards.Length}");
            }
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
