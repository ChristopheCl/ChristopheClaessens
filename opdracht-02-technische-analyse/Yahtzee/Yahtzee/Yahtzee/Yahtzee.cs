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
        protected int aantalTeerlingen =5;
        List<TeerlingController> teerlingen = new List<TeerlingController>();
       

        private TeerlingController controller;

        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                TeerlingController tijdelijkeTeerling = new TeerlingController();

                teerlingen.Add(tijdelijkeTeerling);

            }

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                TeerlingView teerlingView = teerlingen[teerlingNummer].GetView();

                int horizontalPosition = teerlingNummer * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);
            }
        }

        private void btnWerp_Click(object sender, EventArgs e)
        {
           

        }

        private void btnRollAll_Click(object sender, EventArgs e)
        {
            int aantalWorpen = 0;

            if (aantalWorpen <= 3)
            {              

            for (int i = 0; i < teerlingen.Count; i++)
            {
                
                teerlingen[i].Werp();
                teerlingen[i].UpdateUI();
                
            }
            aantalWorpen++;

            }
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < teerlingen.Count; i++)
            {
                teerlingen[i].CheatButtonVisible();
            }
        }
    }
}
