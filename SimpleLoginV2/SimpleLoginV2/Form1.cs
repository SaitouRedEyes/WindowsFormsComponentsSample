using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginV2
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
            d.Add("sID", ((int)Http.Services.LOGIN).ToString());
            d.Add("email", tbEmail.Text);
            d.Add("senha", tbPass.Text);

            lbServerResponse.Text = Http.GetInstance.SendToServer(d);
        }
    }
}
