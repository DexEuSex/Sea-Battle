using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    class AuxControls : OverAllGameControls // Воспомогательные контролы
    {

        Control auxControlItself { get; set; }

        public AuxControls(Control transferredControl) : base(transferredControl)
        {
            auxControlItself = transferredControl;
        }

        public void SetBackImage(string fileName)
        {
            auxControlItself.BackgroundImage = Image.FromFile($@"content\pictures\{fileName}.jpg");
        }

    }
}
