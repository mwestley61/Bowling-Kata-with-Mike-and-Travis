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
      if (pins > 10) {
        throw new Exception();
      }
      
      if(firstRollInFrame() + pins > 10)
      {
        throw new Exception();
      }
      
      _rolls[_roll++] = pins;
    }

    public int score()
    {
      for (int i = 0; i < _max_rolls; i++) 
      { 
        if (rolledAStrike(i))
        {
          scoreAStrike(i);
        }
        else if (rolledASpare(i)) 
        {
          i = scoreASpare(i);
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

    private int scoreASpare(int i) 
    {
      _runningScore += _rolls[i];
      i ++;
      _runningScore += _rolls[i];
      _runningScore += _rolls[i+1];
      return i;
    }

    private void scoreAStrike(int i) 
    {
      _runningScore += _rolls[i];
      _runningScore += _rolls[i+1];
      _runningScore += _rolls[i+2];
      _max_rolls--; 
    }

    private int firstRollInFrame(){
      int firstRoll = 0;

      // Loops through each frame
      for (int i = 0; i < _roll; i++){
        if (rolledAStrike(i))
          firstRoll = 0;
        else{
          if (i+1 == _roll)
            firstRoll = _rolls[_roll-1];
          else
            firstRoll = 0;
          i++; // When not strike, move to next frame
        }        
      }

      return firstRoll;
    }
  }
}