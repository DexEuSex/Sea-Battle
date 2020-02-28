using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    abstract class GameButtons
    {

        public virtual void Disable(Control wantedButton)
        {

        }

        public virtual void Enable(Control wantedButton)
        {

        }

        public virtual void SetColor(Control wantedButton)
        {

        }

        public virtual void Show(Control wantedButton)
        {

        }

        public virtual void Hide(Control wantedButton)
        {

        }
    }
}
