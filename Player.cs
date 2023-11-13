namespace Project
{
  public class Player
  {
    public string Name;
    private List<Card> _hand = new List<Card>();
    Deck deck;
    Board board;

    public int Count
    {
      get => _hand.Count;
      private set { }
    }

    public Player(string name, Deck deck, Board board)
    {
      Name = name;
      this.deck = deck;
      this.board = board;
    }

    public void Draw()
    {
      _hand.Add(deck.Give());
    }

    public void ShowCards()
    {
      for (int i = 0; i < _hand.Count; i++)
      {
        Console.WriteLine($"{i + 1}) {_hand[i].color} {_hand[i].symbol}");
      }
    }

    public bool IsValid(int i)
    {
      return board.topCard.color == _hand[i].color || board.topCard.symbol == _hand[i].symbol;
    }

    public void Play(int i) {
      Card card = _hand[i];
      board.Play(card);
      _hand.RemoveAt(i);
    }
  }
}