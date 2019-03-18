using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(celsiusTB.Text))
            {
                if(MeasuresCB.SelectedItem.Equals("Fahrenheit"))
                {

                    result.Text = ((float.Parse(celsiusTB.Text) * 9 / 5) + 32) + "F";
                }
                else
                {
                    result.Text = (float.Parse(celsiusTB.Text) + 273.15) + "K";
                }
            }
            else
            {
                MessageBox.Show("Insira um valor de temperatura válido");
                result.Text = "";
            }
        }

        private void celsiusTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
