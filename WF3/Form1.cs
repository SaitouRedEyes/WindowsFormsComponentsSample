using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if(!tbPlayer.Text.Equals("")) 
            {
                cbPlayers.Items.Add(tbPlayer.Text);

                MessageBox.Show("Jogador Adicionado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Não podemos adicionar este jogador");
            }
        }       

        private void cbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPlayerSelected.Text = (string)cbPlayers.SelectedItem;
        }
    }
}
