using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("n1", tbN1.Text);
            d.Add("n2", tbN2.Text);
            d.Add("op", tbOperation.Text);

            lbServerResponse.Text = Http.GetInstance.SendToServer(d);
        }
    }
}
