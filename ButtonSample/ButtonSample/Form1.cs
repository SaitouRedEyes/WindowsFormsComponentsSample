using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ButtonSample
{
    public partial class Form1 : Form
    {
        List<Card> cards;

        public Form1()
        {
            InitializeComponent();

            cards = new List<Card>();

            cards.Add(new Card(card1));
            cards.Add(new Card(card2));
        }

        private void Button1_mouseEnter(object sender, System.EventArgs e)
        {
            button1.Size = new Size(button1.Size.Width + 20, 
                                    button1.Size.Height + 20);
        }

        private void Button1_mouseHover(object sender, System.EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void Button1_mouseLeave(object sender, System.EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            button1.Size = new Size(button1.Size.Width - 20, 
                                    button1.Size.Height - 20);
        }

        private void Button1_mouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void Button1_mouseClick(object sender, System.EventArgs e)
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
            card1.Size = new Size(card1.Size.Width + 10, 
                                  card1.Size.Height + 10);
        }

        private void card2_MouseEnter(object sender, EventArgs e)
        {
            card2.Size = new Size(card2.Size.Width + 10, card2.Size.Height + 10);
        }

        private void card1_MouseLeave(object sender, EventArgs e)
        {
            card1.Size = new Size(card1.Size.Width - 10, 
                                  card1.Size.Height - 10);
        }

        private void card2_MouseLeave(object sender, EventArgs e)
        {
            card2.Size = new Size(card2.Size.Width - 10, card2.Size.Height - 10);
        }

        private void card1_MouseUp(object sender, MouseEventArgs e)
        {
            ShowCard(cards[0]);
        }

        private void card2_MouseUp(object sender, MouseEventArgs e)
        {
            ShowCard(cards[1]);
        }

        private void ShowCard(Card card)
        {
            if (card.front == false)
            {
                card.myButton.BackgroundImage = Properties.Resources.card_tyranitar_front;
                card.front = true;
            }
        }

        private void HideCards(object sender, MouseEventArgs e)
        {
            if(cards[0].front == true && 
               cards[1].front == true)
            {
                foreach(Card c in cards)
                {
                    c.myButton.BackgroundImage = Properties.Resources.card_back;
                    c.front = false;
                }
            }
        }
    }
}
