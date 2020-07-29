using System;
using System.Linq;
using System.Windows.Forms;

namespace PlayersSelectionMission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goToMission_Click(object sender, EventArgs e)
        {
            if(mission1.Checked == true)
            {
                ValidateMission(4);
            }
            else if(mission2.Checked == true)
            {
                ValidateMission(1);
            }
            else
            {
                ValidateMission();
            }
        }

        private void ValidateMission()
        {
            if(mage.Checked == true)
            {
                MessageBox.Show("Partiu missão!!!!!!");
            }
            else
            {
                MessageBox.Show("É preciso cumprir os requisitos da missão");
            }
        }

        private void ValidateMission(int charsRequired)
        {
            int number = 0;

            if(warrior.Checked == true)
            {
                number++;
            }

            if (mage.Checked == true)
            {
                number++;
            }

            if (archer.Checked == true)
            {
                number++;
            }

            if (cleric.Checked == true)
            {
                number++;
            }

            if (assassin.Checked == true)
            {
                number++;
            }

            if(number >= charsRequired)
            {
                MessageBox.Show("Partiu missão!!!!!!");
            }
            else
            {
                MessageBox.Show("É preciso cumprir os requisitos da missão");
            }
            
        }
    }
}
