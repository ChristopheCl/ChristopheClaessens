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
    public partial class TeerlingView : UserControl
    {
        private TeerlingController controller;
        private bool redColor = false;

        public TeerlingView( TeerlingController c)
        {
            InitializeComponent();
            controller = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbllalbel1.BackColor = Color.Red;
        }

        private void btnWerp_Click(object sender, EventArgs e)
        {
            controller.Werp();

            int NieuwAantalOgen = controller.model.AantalOgen;

            lbllalbel1.Text = NieuwAantalOgen.ToString();

        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
            btnWerp.Visible = false;
            
        }

        public void UpdateUI()
        {
            lbllalbel1.Text = controller.model.AantalOgen.ToString();
        }

        public void ColorIsRed()
        {
            //if (lbllalbel1.BackColor == Color.Red)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public void CheatButtonVisible()
        {
            btnWerp.Visible = true;
        }

    }
}
