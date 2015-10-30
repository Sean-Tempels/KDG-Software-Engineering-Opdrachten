using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class TeerlingController
  {
    private static int seed;

    //member die de view opvangt
    TeerlingView view;
    public TeerlingModel model;

    public TeerlingController()
    {
      //maak nieuwe instantie aan van view
      view = new TeerlingView(this);
      model = new TeerlingModel();
    }

    //methode die de view van teerling returnt
    public TeerlingView GetView()
    {
      return view;
    }

    public void Werp()
    {
      //vraagt model om aantal ogen te updaten
      Console.WriteLine("presenter spreekt controller aan");

      Random random = new Random(seed);

      int aantalOgen = random.Next(1, 7);
      
      //Het model updaten
      model.AantalOgen = aantalOgen;

      seed += aantalOgen;
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }

    public void HideWerpBtn()
    {
      view.HideWerpBtn();
    }

    public void ShowWerpBtn()
    {
      view.ShowWerpBtn();
    }
  }
}
