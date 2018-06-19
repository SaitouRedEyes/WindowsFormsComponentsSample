using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonSample
{
    class Card
    {
        public Button myButton;
        public bool front;

        public Card(Button newButton)
        {
            myButton = newButton;
            front = false;
        }
    }
}
