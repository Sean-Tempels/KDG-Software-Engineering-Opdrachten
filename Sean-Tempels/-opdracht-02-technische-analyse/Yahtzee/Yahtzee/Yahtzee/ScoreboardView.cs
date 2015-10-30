using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
  public partial class ScoreboardView : UserControl
  {
    public ScoreBoardController controller;

    public ScoreboardView (ScoreBoardController c)
    {
      InitializeComponent();

      controller = c;
    }

    public void UpdateUI()
    {
      int nieuweScore = controller.model.Score;
      int nieuweHighScore = controller.model.HighScore;

      ScoreLabel.Text = nieuweScore.ToString();
      HighScoreLabel.Text = nieuweHighScore.ToString();
    }
  }
}
