namespace BowlingKata
{
  public class Game
  {
    int _runningScore;
    public void roll(int pins)
    {
      _runningScore += pins;
    }

    public int score()
    {
      return _runningScore;
    }
  }
}