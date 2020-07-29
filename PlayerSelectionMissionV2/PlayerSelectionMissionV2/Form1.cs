using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerSelectionMissionV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbMission1.Checked == true)
            {
                ValidateMission1();
            }
            else if (rbMission2.Checked == true)
            {
                ValidateMission2();
            }
            else if (rbMission3.Checked == true)
            {
                ValidateMission3();
            }
            else
            {
                ValidateMission4();
            }
        }

        private void ValidateMission1()
        {
            if (cbHuman.Checked == true && cbDwarf.Checked == true &&
                cbElf.Checked == true && cbSorcerer.Checked == true)
            {
                MessageBox.Show("Partiu missão!!!!!!");
            }
            else
            {
                MessageBox.Show("É preciso cumprir os requisitos da missão");
            }
        }

        private void ValidateMission2()
        {
            int number = 0;

            if (cbHuman.Checked == true)
            {
                number++;
            }

            if (cbDwarf.Checked == true)
            {
                number++;
            }

            if (cbElf.Checked == true)
            {
                number++;
            }

            if (cbSorcerer.Checked == true)
            {
                number++;
            }

            if (number >= 2)
            {
                MessageBox.Show("Partiu missão!!!!!!");
            }
            else
            {
                MessageBox.Show("É preciso cumprir os requisitos da missão");
            }
        }

        private void ValidateMission3()
        {
            if (cbHuman.Checked == true && cbDwarf.Checked == true)
            {
                MessageBox.Show("Partiu missão!!!!!!");
            }
            else
            {
                MessageBox.Show("É preciso cumprir os requisitos da missão");
            }
        }

        private void ValidateMission4()
        {
            if(cbHuman.Checked == false && cbDwarf.Checked == false &&
                cbElf.Checked == true && cbSorcerer.Checked == false)
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
