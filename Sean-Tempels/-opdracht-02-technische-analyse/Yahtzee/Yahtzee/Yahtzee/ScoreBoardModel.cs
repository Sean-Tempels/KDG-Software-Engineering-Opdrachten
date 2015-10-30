using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreBoardModel
  {
    private int score = 0;
    private int highScore = 0;

    public int Score
    {
      get { return score; }
      set { score = value; }
    }

    public int HighScore
    {
      get { return highScore; }
      set { highScore = value; }
    }
  }
}
