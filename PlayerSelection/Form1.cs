using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerSelection
{
    public partial class Form1 : Form
    {
        private Bitmap[] players = { Properties.Resources.Akuma,
                                        Properties.Resources.Scorpion,
                                        Properties.Resources.Fulgore,
                                        Properties.Resources.Morrigan};
        private int currPlayer = 0;
        
        public Form1()
        {
            InitializeComponent();    
        }

        private void selector2_Click(object sender, EventArgs e)
        {
            currPlayer++;

            if(currPlayer == 4)
            {
                currPlayer = 0;
            }

            player.BackgroundImage = players[currPlayer];
        }

        private void selector1_Click(object sender, EventArgs e)
        {
            currPlayer--;

            if (currPlayer == -1)
            {
                currPlayer = 3;
            }

            player.BackgroundImage = players[currPlayer];
        }
    }
}
