using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientServerSample1
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
            d.Add("firstname", tbFirstName.Text);
            d.Add("lastname", tbLastName.Text);

            lbServerResponse.Text = Http.GetInstance.SendToServer(d);
        }
    }
}
