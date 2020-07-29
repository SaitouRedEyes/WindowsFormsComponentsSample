using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!n1TextBox.Text.Equals("") && 
                !n2TextBox.Text.Equals(""))
            {
                try
                {
                    float n1 = float.Parse(n1TextBox.Text);
                    float n2 = float.Parse(n2TextBox.Text);

                    float result = n1 + n2;

                    resultLabel.Text = result.ToString();
                }
                catch(FormatException)
                {
                    MessageBox.Show("Insira um valor numérico válido");
                }
            }
            else
            {
                MessageBox.Show("Insira um valor");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("label clicado");
        }
    }
}
