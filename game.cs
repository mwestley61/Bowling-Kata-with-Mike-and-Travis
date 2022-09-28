using System;

namespace BowlingKata
{
  public class Game
  {
    int _runningScore;
    int _roll = 0;
    int _max_rolls = 20;
    int[] _rolls = new int[21];
    
    public void roll(int pins)
    {
      _rolls[_roll++] = pins;
    }

    public int score()
    {
      for (int i = 0; i < _max_rolls; i++) 
      { 
        if (rolledAStrike(i))
        {
          _runningScore += _rolls[i];
          _runningScore += _rolls[i+1];
          _runningScore += _rolls[i+2];
          _max_rolls = _max_rolls - 1; 
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