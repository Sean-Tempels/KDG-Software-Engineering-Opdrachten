using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreBoardController
  {
    //member die de view opvangt
    ScoreboardView view;
    public ScoreBoardModel model;

    public ScoreBoardController()
    {
      //maak nieuwe instantie aan van view
      view = new ScoreboardView(this);
      model = new ScoreBoardModel();
    }

    //methode die de view van teerling returnt
    public ScoreboardView GetView()
    {
      return view;
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }
  }
}
