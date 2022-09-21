using System;

namespace BowlingKata
{
  public class Game
  {
    int _runningScore;
    int _roll = 0;
    int[] _rolls = new int[20];
    
    public void roll(int pins)
    {
      _rolls[_roll++] = pins;
      if (pins == 10)
        _rolls[_roll++] = 0;
    }

    public int score()
    {
      for (int i = 0; i < _rolls.Length; i++) 
      {
        if (rolledAStrike(i))
        {
          _runningScore += _rolls[i];
          _runningScore += _rolls[i+2];
          _runningScore += _rolls[i+3];
        }
        else if (rolledASpare(i)) 
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
        return true;
      else
        return false;
    }
  }
}