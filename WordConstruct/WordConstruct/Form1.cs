using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordConstruct
{
    public partial class Form1 : Form
    {
        string word;

        public Form1()
        {
            InitializeComponent();
            word = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("a");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("e");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("i");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("o");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("u");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("p");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("r");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("s");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("t");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("c");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Console.WriteLine(word);
            word = "";
        }

        private string CheckUppercase(string letter)
        {
            if(word.Length == 0)
            {
                return letter.ToUpper();
            }
            else
            {
                return letter;
            }
        }
    }
}
