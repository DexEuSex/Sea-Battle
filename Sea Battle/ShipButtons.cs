using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sea_Battle
{
    class ShipButtons 
    {
        int hp;
        public string Name { get; set; }

        public bool Alive { get; set; }

        public int HealthPoints
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                    Alive = false;
                }
                else
                    hp = value;
            }
        }


        public ShipButtons(string shipName, int hp, Control[] transferredButtons) 
        {
            Control[] ownedButtons = new Button[transferredButtons.Length];
            for (int i = 0; i < transferredButtons.Length; i++)
            {
                ownedButtons[i] = transferredButtons[i];
            }
            Name = shipName;
            Alive = true;
            HealthPoints = hp;
        }

        public void Destroyed(Control[] autoHittedBurrons)
        {
            for (int i = 0; i < autoHittedBurrons.Length; i++)
            {
                autoHittedBurrons[i].BackColor = Color.Red;
                autoHittedBurrons[i].Enabled = false;
            }
        }

        //public override void Disable(Control wantedButton)
        //{
        //    wantedButton.Enabled = false;
        //}

        //public override void Enable(Control wantedButton)
        //{
        //    wantedButton.Enabled = true;
        //}

        //public override void SetColor(Control wantedButton, Color wantedColor)
        //{
        //    wantedButton.BackColor = wantedColor;
        //}

        //public override void Show(Control wantedButton)
        //{
        //    wantedButton.Visible = true;
        //}

        //public override void Hide(Control wantedButton)
        //{
        //    wantedButton.Visible = false;
        //}

    }
}
