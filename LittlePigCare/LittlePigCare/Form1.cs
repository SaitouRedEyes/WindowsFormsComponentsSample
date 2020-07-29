using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittlePigCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbPig.Tag = "vivo";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            if((string)pbPig.Tag == "vivo")
            {
                pbPig.Size = new Size(pbPig.Size.Width + 10, pbPig.Size.Height + 10);

                if (pbPig.Size.Width > 300 || pbPig.Size.Height > 300)
                {
                    pbPig.BackgroundImage = Properties.Resources.dead_fat_pig;
                    pbPig.Tag = "morto";
                }
            }
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            if ((string)pbPig.Tag == "vivo")
            {
                pbPig.Size = new Size(pbPig.Size.Width - 10, pbPig.Size.Height - 10);

                if (pbPig.Size.Width <= 50 || pbPig.Size.Height <= 50)
                {
                    pbPig.BackgroundImage = Properties.Resources.dead_tired_pig;
                    pbPig.Tag = "morto";
                }
            }
        }
    }
}
