using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sea_Battle
{
    class CommonShips
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

        public CommonShips(string shipName, int hp)
        {
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
    }
}
