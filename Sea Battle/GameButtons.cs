using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    abstract class GameButtons : Form
    {
        Control buttonItself { get; set; }

        public GameButtons(Control transferedButton)
        {
            buttonItself = transferedButton;
        }

        public virtual void IsEnabled(bool wantedСondition)
        {
            buttonItself.Enabled = wantedСondition;
        }

        public virtual void SetColor(Color wantedColor)
        {
            buttonItself.BackColor = wantedColor;
        }

        public virtual void IsVisible(bool wantedButton)
        {
            buttonItself.Visible = wantedButton;
        }
    }
}
