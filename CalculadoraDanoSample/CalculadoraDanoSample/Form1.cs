using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDanoSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDamage(object sender, EventArgs e)
        {
            try
            {
                int result = cbCriticalHit.Checked == true ? int.Parse(lbLife.Text) - (int.Parse(tbDamage.Text) * 2) :
                                                             int.Parse(lbLife.Text) - int.Parse(tbDamage.Text);

                if (result <= 0) lbLife.Text = "0";
                else lbLife.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Escreva um valor de dano válido");
            }
        }
    }
}
