using Xunit;
using System.Collections.Generic;

namespace BowlingKata
{
  public class GameTests
  {
    [Fact]
    void can_get_scoreAfterOneRoll(){
      var game = new Game();

      game.roll(5);
      
      Assert.Equal(5, game.score());
    }

    [Fact]
    void can_get_scoreAfterTwoRolls(){
      var game = new Game();

      game.roll(5);
      game.roll(3);
      
      Assert.Equal(8, game.score());
    }

    [Fact]
    void can_score_spare()
    {
      var game = new Game();

      game.roll(5);
      game.roll(5);
      game.roll(8);
      game.roll(2);
      game.roll(7);
      
      Assert.Equal(42, game.score());
    }
        
    [Fact]
    void can_score_strike()
    {
      var game = new Game();

      game.roll(10);
      game.roll(5);
      game.roll(3);
      
      Assert.Equal(26, game.score());
    }
    
    [Fact]
    void scores_game_correctly()
    {
      var game = new Game();
      List<int> rolls = new List<int> {6, 3, 10, 4, 3, 10, 7, 3, 8, 2, 4, 4, 3, 3, 5, 3, 5, 3};

      foreach(int pins in rolls)
      {
        game.roll(pins);
      }
      var score = game.score();

      Assert.Equal(115, score);
    }
    
    [Fact]
    void scores_3_strikes_at_end_correctly()
    {
      var game = new Game();
      List<int> rolls = new List<int> {6, 3, 10, 4, 3, 10, 7, 3, 8, 2, 4, 4, 3, 3, 5, 3, 10, 10, 10};

      foreach(int pins in rolls)
      {
        game.roll(pins);
      }
      var score = game.score();

      Assert.Equal(137, score);
    }
  
    [Fact]
    void scores_3_strikes_at_begin_correctly()
    {
      var game = new Game();
      List<int> rolls = new List<int> {10, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

      foreach(int pins in rolls)
      {
        game.roll(pins);
      }
      var score = game.score();

      Assert.Equal(60, score);
    }
  }
}