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
        private int potionsValue;
        private int potionsNumber;

        public Form1()
        {
            InitializeComponent();
            
            potionsNumber = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            potionsValue = 0;

            if (checkBox1.Checked)
            {
                potionsValue += 3;
            }

            if (checkBox2.Checked)
            {
                potionsValue += 6;
            }

            if (checkBox3.Checked)
            {
                potionsValue += 9;
            }

            if (radioButton1.Checked)
            {
                potionsNumber = 1;
            }
            else if (radioButton2.Checked)
            {
                potionsNumber = 10;
            }
            else
            {
                potionsNumber = 100;
            }            

            MessageBox.Show("Total Value is: $" + potionsValue * potionsNumber);
        }      
    }
}
