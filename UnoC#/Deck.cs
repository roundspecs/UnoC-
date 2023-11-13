namespace Project
{
  public class Deck
  {
    private List<Card> _cards = new List<Card>();

    public int Count
    {
      get => _cards.Count;
      private set { }
    }

    public Deck()
    {
      foreach (Color color in Constants.colors)
      {
        foreach (string symbol in Constants.symbols)
        {
          if (symbol != "0")
          {
            _cards.Add(new Card(color, symbol));
          }
          _cards.Add(new Card(color, symbol));
        }
      }
      for (int i = 0; i < 4; i++)
      {
        _cards.Add(new Card(Color.Black, ""));
        _cards.Add(new Card(Color.Black, "+4"));
      }
      Shuffle();
    }

    public void Print()
    {
      foreach (Card card in _cards)
      {
        Console.WriteLine($"{card.color} {card.symbol}");
      }
    }

    public void Shuffle()
    {
      Random random = new Random();
      for (int i = 0; i < Count; i++)
      {
        int a = random.Next(0, Count);
        int b = random.Next(0, Count);
        Card temp = _cards[a];
        _cards[a] = _cards[b];
        _cards[b] = temp;
      }
    }

    public Card Give()
    {
      Card card = _cards.Last();
      _cards.RemoveAt(Count - 1);
      return card;
    }

    public void Take(Card card)
    {
      _cards.Add(card);
      Shuffle();
    }
  }
}