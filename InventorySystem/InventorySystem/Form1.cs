using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if(!tbItem.Text.Equals(""))
            {
                if(!cbItensList.Items.Contains(tbItem.Text))
                {
                    cbItensList.Items.Add(tbItem.Text);
                    tbItem.Clear();
                    MessageBox.Show("Item adicionado com sucesso");
                }
                else
                {
                    MessageBox.Show("Este item já existe na lista");
                }
            }
            else
            {
                MessageBox.Show("Insira um Item válido");
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if(cbItensList.Items.Contains(tbItem.Text))
            {
                cbItensList.Items.Remove(tbItem.Text);
                tbItem.Clear();
                MessageBox.Show("Item removido com sucesso");
            }
            else
            {
                MessageBox.Show("Este Item não existe na lista");
            }
        }
    }
}
