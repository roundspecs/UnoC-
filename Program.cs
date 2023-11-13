using System;

namespace Project
{
  class Program
  {
    public static void Main()
    {
      Deck deck = new Deck();
      Board board = new Board(deck);

      Console.Write("Number of players: ");
      int NumberOfPlayers = int.Parse(Console.ReadLine());
      Player[] players = new Player[NumberOfPlayers];

      for (int i = 0; i < NumberOfPlayers; i++)
      {
        players[i] = new Player($"Player - {i}", deck, board);
        for (int j = 0; j < 7; j++)
          players[i].Draw();
      }


      for (int i = 0; true; i = (i + 1) % NumberOfPlayers)
      {
        Console.WriteLine($"Board card: {board.topCard.color} {board.topCard.symbol}");
        Console.WriteLine($"Hand of Player-{i + 1}");
        players[i].ShowCards();
        Console.WriteLine("d) Draw from deck");
        bool ok = false;
        do
        {
          string input = Console.ReadLine();
          if (input == "d") {
            players[i].Draw();
            ok = true;
          }
          else
          {
            try
            {
              int index = int.Parse(input) - 1;
              if (index < 0 || index >= players[i].Count)
                throw new Exception("Invalid index.");
              else if (!players[i].IsValid(index))
                throw new Exception("Invalid card.");
              players[i].Play(index);
              ok = true;
            }
            catch (Exception e)
            {
              Console.WriteLine($"{e.Message} Try again.");
            }
          }
        } while (!ok);
        if(players[i].Count==0) {
          Console.WriteLine($"Congratulations!!! Player{i+1} is the winner!!!");
          break;
        }
      }
    }
  }
}