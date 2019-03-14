using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayingCards.Core.Tests
{
    [TestClass]
    public class CardDeckTests
    {

        [TestMethod]
        public void PokerDeckHas52Cards()
        {

            var deck = new PokerDeck();
            Assert.IsTrue(deck.Cards.Length == 52);
        }
        [TestMethod]
        public void DeckHasExactlyOneOfEachCard()
        {

            var deck = new PokerDeck();
            Assert.IsTrue(deck.Cards.Length == 52);
            
            string[] suits = new string[]{"Spades", "Hearts", "Diamonds", "Clubs"};

            foreach (var suit in suits)
            {
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "2 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "3 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "4 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "5 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "6 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "7 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "8 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "9 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "10 of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "Jack of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "Queen of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "King of " + suit)));
                Assert.IsNotNull(deck.Cards.SingleOrDefault(c => c.FindCard<PokerCard>(p => p.ToString() == "Ace of " + suit)));
            }
        }

        

    }
}
