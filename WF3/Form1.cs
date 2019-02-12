using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3
{
    public partial class Form1 : Form
    {
        private List<string> classes;

        public Form1()
        {
            InitializeComponent();
            classes = new List<string>();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if(!tbPlayer.Equals("") && CouldAddPlayer(tbPlayer.Text))
            {
                cbPlayers.Items.Add(tbPlayer.Text);

                if(rbWarrior.Checked == true)
                {
                    classes.Add(rbWarrior.Text);
                }
                else if (rbMage.Checked == true)
                {
                    classes.Add(rbMage.Text);
                }
                else
                {
                    classes.Add(rbArcher.Text);
                }

                MessageBox.Show("Jogador Adicionado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Já existe jogador com este Nick!");
            }
        }

        private void cbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPlayer.Text = cbPlayers.Items[cbPlayers.SelectedIndex].ToString();
            labelClass.Text = classes[cbPlayers.SelectedIndex];
        }

        private Boolean CouldAddPlayer(string newPlayer)
        {
            foreach(string player in cbPlayers.Items)
            {
                if(player.Equals(newPlayer))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
