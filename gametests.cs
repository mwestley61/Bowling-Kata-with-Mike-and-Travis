using Xunit;

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
      game.roll(3);
      game.roll(7);
      
      Assert.Equal(32, game.score());
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
  }
}