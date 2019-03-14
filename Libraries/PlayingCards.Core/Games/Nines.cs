using PlayingCards.Core;

public class Nines
{

    private int playerCount;
    private PokerDeck deck;

    private Player[] players;
    private IDealer dealer;

    private ICard[] DrawPile;

    private ICard[] DiscardPile;
    public Nines(int numberOfPlayers)
    {
        playerCount = numberOfPlayers;
        deck = new PokerDeck();
        dealer = new DealXCardsPerHand(playerCount, 9);
    }

    int currentTurn=0;
    public void BeginRound()
    {
        currentTurn =0;
        //Shuffle the deck
        deck.Shuffle(5);

        //Deal out hands
        var hands = deck.Deal(dealer);
        
        players=new Player[playerCount];

        //Assign Hands to player
        for(int i=0; i<playerCount; i++){
            players[i]= new Player(i,hands[i]);
        }

        
    }


}

public class Player {

    public Player(int id, IHand hand)
    {
        PlayerID=id;
        PlayerName=$"Player {id}";
        Hand = hand;
    }
    public int PlayerID { get; set; }
    public string PlayerName { get; set; }
    public IHand Hand {get;set;}

    public bool IsWinner(){
        return Hand.CardCount==0;
    }
}