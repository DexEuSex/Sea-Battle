using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    class AuxButtons : GameButtons // Воспомогательные кнопки 
    {

        Control buttonItself { get; set; }

        public AuxButtons(Control transferedButton) : base(transferedButton)
        {
            buttonItself = transferedButton;
        }

        public void SetBackImage(string fileName)
        {
            buttonItself.BackgroundImage = Image.FromFile($@"content\pictures\{fileName}.jpg");
        }

    }
}
