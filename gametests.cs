using Xunit;

namespace BowlingKata
{
  public class GameTests
  {
    [Fact]
    void can_roll()
    {
      var game = new Game();
      
      game.roll(0);
    }

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
      game.roll(3);
      game.roll(3);
      
      Assert.Equal(19, game.score());
    }
  }
}