using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    abstract class OverAllGameControls : Form
    {
        Control controlItself { get; set; }

        public OverAllGameControls(Control transferedControl)
        {
            controlItself = transferedControl;
        }

        public virtual void IsEnabled(bool wantedСondition)
        {
            controlItself.Enabled = wantedСondition;
        }

        public virtual void SetColor(Color wantedColor)
        {
            controlItself.BackColor = wantedColor;
        }

        public virtual void IsVisible(bool wantedButton)
        {
            controlItself.Visible = wantedButton;
        }
    }
}
