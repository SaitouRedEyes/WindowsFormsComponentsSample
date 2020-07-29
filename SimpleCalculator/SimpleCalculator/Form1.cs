using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1, n2, result;
        bool OKFirstNumber, OKSecondNumber, OKSignal;
        string signal;

        public Form1()
        {
            InitializeComponent();
            n1 = n2 = result = 0;
            OKFirstNumber = OKSecondNumber = OKSignal = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberClicked(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberClicked(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberClicked(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberClicked(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberClicked(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberClicked(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberClicked(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberClicked(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberClicked(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberClicked(0);
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            signal = "+";
            OKSignal = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            signal = "-";
            OKSignal = true;
        }

        private void NumberClicked(int numberClicked)
        {
            if (!OKFirstNumber)
            {
                n1 = numberClicked;
                OKFirstNumber = true;
            }
            else if (OKFirstNumber == true && OKSignal == true)
            {
                n2 = numberClicked;
                OKSecondNumber = true;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(OKFirstNumber == true && OKSecondNumber == true)
            {
                if(signal == "+")
                {
                    result = n1 + n2;
                }
                else
                {
                    result = n1 - n2;
                }

                Console.WriteLine("O resultado é: " + result);
                OKFirstNumber = OKSecondNumber = OKSignal = false;
            }
        }
    }
}
