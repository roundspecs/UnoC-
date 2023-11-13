namespace Project
{
  public class Board
  {
    public Card topCard;
    Deck deck;

    public Board(Deck deck)
    {
      this.deck = deck;
      topCard = deck.Give();
    }

    public void Play(Card card)
    {
      deck.Take(topCard);
      topCard = card;
    }
  }
}