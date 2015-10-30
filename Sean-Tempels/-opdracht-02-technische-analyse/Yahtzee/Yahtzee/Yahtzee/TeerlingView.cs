﻿using System;
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
  public partial class TeerlingView : UserControl
  {
    private TeerlingController controller;

    public TeerlingView(TeerlingController c)
    {
      InitializeComponent();

      controller = c;
    }

    private void TeerlingView_Load(object sender, EventArgs e)
    {
      TeerlingWerpBtn.Hide();
    }

    private void werp_Click(object sender, EventArgs e)
    {
      controller.Werp();

      int nieuwAantalOgen = controller.model.AantalOgen;

      TeerlingLabel.Text = nieuwAantalOgen.ToString();
    }

    public void UpdateUI()
    {
      int nieuwAantalOgen = controller.model.AantalOgen;

      TeerlingLabel.Text = nieuwAantalOgen.ToString();
    }

    public void HideWerpBtn()
    {
      TeerlingWerpBtn.Hide();
    }

    public void ShowWerpBtn()
    {
      TeerlingWerpBtn.Show();
    }
  }
}
