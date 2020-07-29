using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ButtonSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            card1.Tag = "back";
            card2.Tag = "back";
        }

        private void Button1_mouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width + 20, button1.Size.Height + 20);
        }

        private void Button1_mouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void Button1_mouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            button1.Size = new Size(button1.Size.Width - 20, button1.Size.Height - 20);
        }

        private void Button1_mouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void Button1_mouseClick(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void Button1_mouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        // Memory Game Mechanic
        private void card1_MouseEnter(object sender, EventArgs e)
        {
            card1.Size = new Size(card1.Size.Width + 10, card1.Size.Height + 10);
        }

        private void card2_MouseEnter(object sender, EventArgs e)
        {
            card2.Size = new Size(card2.Size.Width + 10, card2.Size.Height + 10);
        }

        private void card1_MouseLeave(object sender, EventArgs e)
        {
            card1.Size = new Size(card1.Size.Width - 10, card1.Size.Height - 10);
        }

        private void card2_MouseLeave(object sender, EventArgs e)
        {
            card2.Size = new Size(card2.Size.Width - 10, card2.Size.Height - 10);
        }

        private void card1_MouseUp(object sender, MouseEventArgs e)
        {
            if((string)card1.Tag == "back")
            {
                card1.BackgroundImage = Properties.Resources.card_tyranitar_front;
                card1.Tag = "front";
            }
        }

        private void card2_MouseUp(object sender, MouseEventArgs e)
        {
            if ((string)card2.Tag == "back")
            {
                card2.BackgroundImage = Properties.Resources.card_tyranitar_front;
                card2.Tag = "front";
            }
        }

        private void HideCards(object sender, MouseEventArgs e)
        {
            if((string)card1.Tag == "front" && (string)card2.Tag == "front")
            {
                card1.BackgroundImage = Properties.Resources.card_back;
                card2.BackgroundImage = Properties.Resources.card_back;
                card1.Tag = "back";
                card2.Tag = "back";
            }
        }
    }
}