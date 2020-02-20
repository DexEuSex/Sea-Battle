using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                button.Visible = false;

            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                button.Visible = false;

            whoseTurnComboBox.Visible = false;
            whoseTurnLabel.Visible = false;
            
        }

        
        
        private void mainButton_Click(object sender, EventArgs e)
        {
            whoseTurnComboBox.Visible = true;
            whoseTurnLabel.Visible = true;

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
            {
                button.Visible = true;
                button.Enabled = false;
            }

            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
            {
                button.Visible = true;
                button.BackColor = System.Drawing.SystemColors.Menu;
            }
            hintLabel.Text = "Игрок 1, расположение ваших кораблей вы видите слева. Справа - корабли противника";
            mainButton.Text = "Передать хоть второму игроку";

            switch (whoseTurnComboBox.SelectedItem)
            {
                case "Игрок 2":
                    foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                    {
                        button.BackColor = System.Drawing.SystemColors.Menu;
                        button.Enabled = true;
                    }
                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                    {
                        button.BackColor = DefaultBackColor;
                        button.Enabled = false;
                    }
                    break;
            }

        }
        
        

    }
    
}
