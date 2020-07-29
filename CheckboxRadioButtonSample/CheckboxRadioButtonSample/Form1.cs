using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxRadioButtonSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.BackgroundImage = Properties.Resources.bulbasaur;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                ChangeImage(Properties.Resources.bulbasaur, 
                            Properties.Resources.ivysaur, 
                            Properties.Resources.venusaur);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                ChangeImage(Properties.Resources.charmander, 
                            Properties.Resources.charmeleon, 
                            Properties.Resources.charizard);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                ChangeImage(Properties.Resources.squirtle, 
                            Properties.Resources.wartortle, 
                            Properties.Resources.blastoise);
            
        }

        private void ChangeImage(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                ChangeImage(Properties.Resources.bulbasaur, 
                            Properties.Resources.ivysaur, 
                            Properties.Resources.venusaur);
            else if (radioButton2.Checked)
                ChangeImage(Properties.Resources.charmander, 
                            Properties.Resources.charmeleon, 
                            Properties.Resources.charizard);
            else if (radioButton3.Checked)
                ChangeImage(Properties.Resources.squirtle, 
                            Properties.Resources.wartortle, 
                            Properties.Resources.blastoise);
        }

        private void ChangeImage(Bitmap ev1, Bitmap ev2, Bitmap ev3)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
                pictureBox1.BackgroundImage = ev2;
            else if (checkBox1.Checked && checkBox2.Checked)
                pictureBox1.BackgroundImage = ev3;
            else
            {
                pictureBox1.BackgroundImage = ev1;
                checkBox2.Checked = false;
            }
        }
    }
}
