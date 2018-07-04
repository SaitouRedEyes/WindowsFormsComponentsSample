using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((string)comboBox1.SelectedItem)
            {
                case "Akira": pictureBox1.BackgroundImage = Properties.Resources.akira; break;
                case "Cavaleiros do Zodíaco": pictureBox1.BackgroundImage = Properties.Resources.cavaleiros_do_zodiaco; break;
                case "Cowboy Bebop": pictureBox1.BackgroundImage = Properties.Resources.cowboy_bebop; break;
                case "Dragon Ball": pictureBox1.BackgroundImage = Properties.Resources.dragon_ball; break;
                case "Inu Yasha": pictureBox1.BackgroundImage = Properties.Resources.inu_yasha; break;
                case "Sailor Moon": pictureBox1.BackgroundImage = Properties.Resources.sailor_moon; break;
                case "Sakura Card Captor": pictureBox1.BackgroundImage = Properties.Resources.sakura_card_captor; break;
                case "Samurai Warriors": pictureBox1.BackgroundImage = Properties.Resources.samurai_warriors; break;
                case "Samurai X": pictureBox1.BackgroundImage = Properties.Resources.samurai_x; break;
                case "Shurato": pictureBox1.BackgroundImage = Properties.Resources.shurato; break;
                case "Yu Yu Hakusho": pictureBox1.BackgroundImage = Properties.Resources.yuyu_hakusho; break;
            }
        }
    }
}
