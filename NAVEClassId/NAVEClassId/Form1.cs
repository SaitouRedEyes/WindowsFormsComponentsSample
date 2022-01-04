using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVEClassId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMM_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMM.Checked == true)
            {
                cb100a.Text = "1001";
                cb100b.Text = "1002";
                cb200a.Text = "2001";
                cb200b.Text = "2002";
                cb300a.Text = "3001";
                cb300b.Text = "3002";
            }
        }

        private void rbProg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProg.Checked == true)
            {
                cb100a.Text = "1003";
                cb100b.Text = "1004";
                cb200a.Text = "2003";
                cb200b.Text = "2004";
                cb300a.Text = "3003";
                cb300b.Text = "3004";
            }
        }       
    }
}
