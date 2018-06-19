using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        private float potionsValue;
        private int potionsNumber;

        public Form1()
        {
            InitializeComponent();

            potionsValue = 0;
            potionsNumber = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) potionsNumber = 1;
            else if (radioButton2.Checked) potionsNumber = 5;
            else potionsNumber = 10;

            MessageBox.Show("Total Value is: $" + potionsValue * potionsNumber);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePotionValue(checkBox1, 5);
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePotionValue(checkBox2, 10);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePotionValue(checkBox3, 15);
        }

        private void UpdatePotionValue(CheckBox cb, float potionValue)
        {
            if (cb.Checked)
                potionsValue += potionValue;
            else
                potionsValue -= potionValue;
        }
    }
}
