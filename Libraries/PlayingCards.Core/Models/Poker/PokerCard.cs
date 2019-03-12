using System;

namespace PlayingCards.Core
{
    public class PokerCard : ICard {
        public PokerCard(Suit suit, int value)
        {
            this.suit = suit;
            this.value = new PokerCardValue(value);
        }

        public Suit suit { get; set; }  
        public PokerCardValue value {get;set;}

        public bool CanPlay()
        {
            throw new NotImplementedException();
        }

        public bool FindCard<T>(Func<T, bool> predicate)
        {
            return predicate.Invoke((T) Convert.ChangeType(this, typeof(T)));
        }
        

        public override string ToString(){
            return value.ToString() + " of "+ suit.ToString();
        }

    }

    public class PokerCardValue
    {
        private int value;

        public PokerCardValue(int value)
        {
            this.value = value;
        }
        
        public override string ToString(){
            switch(value){
                case 1: return "2";
                case 2: return "3";
                case 3: return "4";
                case 4: return "5";
                case 5: return "6";
                case 6: return "7";
                case 7: return "8";
                case 8: return "9";
                case 9: return "10";
                case 10: return "Jack";
                case 11: return "Queen";
                case 12: return "King";
                case 13: return "Ace";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
