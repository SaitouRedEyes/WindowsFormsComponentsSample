using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerDamageCalculator
{
    public partial class Form1 : Form
    {
        private string result;

        public Form1()
        {
            InitializeComponent();
            result = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("saitamaHP", lbSaitamaHP.Text);

            result = Http.GetInstance.SendToServer(d);

            lbSaitamaHP.Text = result;

            if(lbSaitamaHP.Text == "0")
            {
                pbSaitama.BackgroundImage = Properties.Resources.knee_saitama;
            }
        }
    }
}
