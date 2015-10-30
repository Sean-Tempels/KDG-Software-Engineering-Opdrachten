using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
  public partial class Yahtzee : Form
  {
    int aantalTeerlingen = 3;
    int aantalWorpen = 0;
    ScoreBoardController scoreBoardController = new ScoreBoardController();

    List<TeerlingController> teerlingen = new List<TeerlingController>();

    public Yahtzee()
    {
      InitializeComponent();
    }

    private void Yahtzee_Load(object sender, EventArgs e)
    {

      for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
      {
        //Maak instantie aan van TeerlingController
        TeerlingController tijdelijkeTeerling = new TeerlingController();
        teerlingen.Add(tijdelijkeTeerling);

        TeerlingView tView = teerlingen[teerlingNummer].GetView();

        int horizontalPosition = teerlingNummer * tView.Width;
        tView.Location = new System.Drawing.Point(horizontalPosition, 0);
        Controls.Add(tView);
      }

      ScoreboardView sView = scoreBoardController.GetView();
      int scoreBoardHorizontalPosition = sView.Width * 3;
      sView.Location = new Point(scoreBoardHorizontalPosition, 0);
      Controls.Add(sView);
    }

    private void AlgemeneWerpKnop_Click(object sender, EventArgs e)
    {
      if (aantalWorpen < 3)
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].Werp();
          teerlingen[i].UpdateUI();
        }
        aantalWorpen++;

        UpdateScore();
      }
    }

    private void cheatBox_CheckedChanged(object sender, EventArgs e)
    {
      if (cheatBox.Checked)
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].ShowWerpBtn();
        }
      }

      else
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].HideWerpBtn();
        }
      }
    }

    public void UpdateScore()
    {
      for (int i = 0; i < aantalTeerlingen; i++)
      {
        scoreBoardController.model.Score += teerlingen[i].model.AantalOgen;
      }

      if (scoreBoardController.model.Score > scoreBoardController.model.HighScore)
      {
        scoreBoardController.model.HighScore = scoreBoardController.model.Score;
      }

      scoreBoardController.UpdateUI();

      scoreBoardController.model.Score = 0;
    }
  }
}
