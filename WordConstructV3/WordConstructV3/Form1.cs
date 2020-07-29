using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordConstructV3
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

        private void btnM_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("m");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("n");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("l");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("f");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("v");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("b");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("d");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("g");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("h");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("j");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("q");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("x");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            word += CheckUppercase("z");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(word.Length > 0)
            {
                cbWords.Items.Add(word);
                word = "";
            }
        }

        private string CheckUppercase(string letter)
        {
            if (word.Length == 0)
            {
                return letter.ToUpper();
            }
            else
            {
                return letter;
            }
        }

        private void cbLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLayout.Checked)
            {
                this.BackColor = Color.FromArgb(10, 10, 30);
                cbLayout.ForeColor = Color.White;
                rbLevel1.ForeColor = Color.White;
                rbLevel2.ForeColor = Color.White;
                lbMirroredWord.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                cbLayout.ForeColor = Color.Black;
                rbLevel1.ForeColor = Color.Black;
                rbLevel2.ForeColor = Color.Black;
                lbMirroredWord.ForeColor = Color.Black;
            }
        }

        private void rbLevel2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLevel2.Checked == true)
            {
                btnM.Visible = true;
                btnN.Visible = true;
                btnL.Visible = true;
                btnF.Visible = true;
                btnV.Visible = true;
                btnB.Visible = true;
                btnD.Visible = true;
                btnG.Visible = true;
                btnH.Visible = true;
                btnJ.Visible = true;
                btnQ.Visible = true;
                btnX.Visible = true;
                btnZ.Visible = true;
                btnErase.Visible = true;
                btnResult.Location = new Point(236, 291);
            }
        }

        private void rbLevel1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLevel1.Checked == true)
            {
                btnM.Visible = false;
                btnN.Visible = false;
                btnL.Visible = false;
                btnF.Visible = false;
                btnV.Visible = false;
                btnB.Visible = false;
                btnD.Visible = false;
                btnG.Visible = false;
                btnH.Visible = false;
                btnJ.Visible = false;
                btnQ.Visible = false;
                btnX.Visible = false;
                btnZ.Visible = false;
                btnErase.Visible = false;
                btnResult.Location = new Point(236, 215);
            }
        }

        private void cbWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] arr = cbWords.SelectedItem.ToString().Reverse().ToArray();
            lbMirroredWord.Text = new string(arr);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if(word.Length > 0)
            {
                word = word.Remove(word.Length - 1);
            }
        }
    }
}
