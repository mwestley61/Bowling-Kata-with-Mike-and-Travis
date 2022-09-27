using System;

namespace BowlingKata
{
  public class Game
  {
    int _runningScore;
    int _roll = 0;
    int[] _rolls = new int[21];
    
    public void roll(int pins)
    {
      _rolls[_roll++] = pins;
    }

    public int score()
    {
      Console.WriteLine("==================");
      for (int i = 0; i < _rolls.Length-3; i++) 
      {
        if (rolledAStrike(i))
        {
          Console.WriteLine("Strike begin");
          _runningScore += _rolls[i];
          Console.WriteLine(_runningScore);
          _runningScore += _rolls[i+1];
          Console.WriteLine(_runningScore);
          _runningScore += _rolls[i+2];
          Console.WriteLine(_runningScore);
          Console.WriteLine("Strike end");
        }
        else if (rolledASpare(i)) 
        {
          _runningScore += _rolls[i];
          i ++;
          _runningScore += _rolls[i];
          _runningScore += _rolls[i+1];
        } 
        else 
        {
          _runningScore += _rolls[i];  
        }
        Console.WriteLine(_runningScore);
      }
      return _runningScore;
    }

    private bool rolledASpare(int i) 
    {
      if ((i+1 < _rolls.Length) && (_rolls[i] + _rolls[i+1] == 10)) 
      { 
        return true;
      } 
      else 
      { 
        return false;
      } 
    }

    private bool rolledAStrike(int i) 
    {
      if (_rolls[i] == 10)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}