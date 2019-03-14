using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayingCards.Core.Tests
{
    [TestClass]
    public class DealerTests
    {
[TestMethod]
        public void Deal9CardsToEachHand()
        {
            var deck = new PokerDeck();
            deck.Shuffle(5);


            var dealer=new DealXCardsPerHand(4, 9);
            var hands=deck.Deal(dealer);
            Assert.IsTrue(hands.Length==4);

            foreach(var hand in hands){
                Assert.IsTrue(hand.CardCount==9);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"Exception expected but not thrown when dealer doesn't have enough cards.")]
        public void ErrorsWhenTryingToDealToTooManyHands()
        {
            var deck = new PokerDeck();
            deck.Shuffle(5);


            var dealer=new DealXCardsPerHand(6, 9);
            var hands=deck.Deal(dealer);
        }
    }
}
