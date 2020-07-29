using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerCalculatorV2
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

            switch (tbOperation.Text)
            {
                case "soma": d.Add("sID", ((int)Http.Services.SOMA).ToString()); break;
                case "mult": d.Add("sID", ((int)Http.Services.MULT).ToString()); break;
                case "log": d.Add("sID", ((int)Http.Services.LOG).ToString()); break;
                case "sub": d.Add("sID", ((int)Http.Services.SUB).ToString()); break;
                case "div": d.Add("sID", ((int)Http.Services.DIV).ToString()); break;
                case "pow": d.Add("sID", ((int)Http.Services.POW).ToString()); break;
            }

            lbServerResponse.Text = Http.GetInstance.SendToServer(d);
        }
    }
}