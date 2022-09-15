namespace BowlingKata
{
  public class Game
  {
    int _runningScore;
    int i;
    int[] _rolls = new int[20];
    public void roll(int pins)
    {
      _rolls[++i] = pins;
    }

    public int score()
    {
      for (int i = 0; i < _rolls.Length; i++) 
      {
        if ((i+1 < _rolls.Length) && (_rolls[i] + _rolls[i+1] == 10)) 
        {
          _runningScore += 10;
          _runningScore += _rolls[i+2];
          i ++;
        } 
        else 
          {
            _runningScore += _rolls[i];  
          }
      }
      return _runningScore;
    }
  }
}