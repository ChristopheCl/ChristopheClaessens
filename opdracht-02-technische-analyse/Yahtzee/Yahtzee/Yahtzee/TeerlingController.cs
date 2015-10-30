using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{

    public class TeerlingController
    {
        static Random random = new Random();

        TeerlingView view;
        public TeerlingModel model;


        public TeerlingController()
        {
            view = new TeerlingView(this);

            model = new TeerlingModel();
        }

        public TeerlingView GetView()
        {
            return view;
        }

        public void Werp()
        {


            
            int aantalOgen = random.Next(1, 7);


            //model updaten
            model.AantalOgen = aantalOgen;
           
        }

        public void UpdateUI()
        {
            view.UpdateUI();
        }
       
        public void ColorIsRed()
        {
            view.ColorIsRed();
        }

        public void CheatButtonVisible()
        {
            view.CheatButtonVisible();
        }



    }
}
