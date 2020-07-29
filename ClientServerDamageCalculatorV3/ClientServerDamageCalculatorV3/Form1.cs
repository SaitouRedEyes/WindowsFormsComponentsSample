using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerDamageCalculatorV3
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
            d.Add("sID", ((int)Http.Services.CALC_DAMAGE).ToString());
            d.Add("saitamaHP", lbSaitamaHP.Text);
            d.Add("gokuHP", lbGokuHP.Text);

            result = Http.GetInstance.SendToServer(d);
            
            lbSaitamaHP.Text = result.Substring(0, result.IndexOf(";"));
            lbGokuHP.Text = result.Remove(0, result.IndexOf(";") + 1);

            if (lbSaitamaHP.Text == "0")
            {
                pbSaitama.BackgroundImage = Properties.Resources.knee_saitama;
            }
            
            if(lbGokuHP.Text == "0")
            {
                pbGoku.BackgroundImage = Properties.Resources.goku_faint;
            }
        }
    }
}
