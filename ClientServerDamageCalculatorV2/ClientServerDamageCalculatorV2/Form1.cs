using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerDamageCalculatorV2
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
            d.Add("attack", cbAttacks.SelectedItem.ToString());
            d.Add("stab", cbStab.Checked.ToString());
            d.Add("blisseyHP", lbBlisseyHP.Text);

            lbBlisseyHP.Text = Http.GetInstance.SendToServer(d);
        }
    }
}
