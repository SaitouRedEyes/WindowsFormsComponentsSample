using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorV3
{
    public partial class Form1 : Form
    {
        int n1, n2, result;
        bool OKFirstNumber;
        string signal;

        public Form1()
        {
            InitializeComponent();
            n1 = n2 = result = 0;
            OKFirstNumber = false;
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
            AddFirstNumber(tbInput.Text, "+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddFirstNumber(tbInput.Text, "-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddFirstNumber(tbInput.Text, "*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AddFirstNumber(tbInput.Text, "/");
        }

        private void NumberClicked(int numberClicked)
        {
            tbInput.Text += numberClicked.ToString();
        }

        private void AddFirstNumber(string firstNumber, string partialSignal)
        {
            if(firstNumber != "")
            {
                signal = partialSignal;
                n1 = int.Parse(firstNumber);
                OKFirstNumber = true;
                tbInput.Text = "";
            }
            else
            {
                Console.WriteLine("Falta 1º número");
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (OKFirstNumber == true && tbInput.Text != "")
            {
                n2 = int.Parse(tbInput.Text);

                if (signal == "+")
                {
                    result = n1 + n2;
                }
                else if (signal == "-")
                {
                    result = n1 - n2;
                }
                else if (signal == "*")
                {
                    result = n1 * n2;
                }
                else
                {
                    result = n1 / n2;
                }

                lbResult.Text = result.ToString();
                tbInput.Text = "";
                OKFirstNumber = false;
            }
            else
            {
                Console.WriteLine("Algo deu errado");
            }
        }

        private void cbLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLayout.Checked)
            {
                this.BackColor = Color.Black;
                cbLayout.ForeColor = Color.White;
                rbDefault.ForeColor = Color.White;
                rbDefaultPlus.ForeColor = Color.White;
                lbResult.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                cbLayout.ForeColor = Color.Black;
                rbDefault.ForeColor = Color.Black;
                rbDefaultPlus.ForeColor = Color.Black;
                lbResult.ForeColor = Color.Black;
            }
        }

        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefault.Checked == true)
            {
                btnMultiply.Visible = false;
                btnDivide.Visible = false;
            }
        }

        private void rbDefaultPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefaultPlus.Checked == true)
            {
                btnMultiply.Visible = true;
                btnDivide.Visible = true;
            }
        }
    }
}
