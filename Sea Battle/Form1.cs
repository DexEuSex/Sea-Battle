using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        Control[] pl1shipArray = new Control[20];
        Control[] pl2shipArray = new Control[20];
        Control[] pl1emptyCellArray = new Control[60];
        Control[] pl2emptyCellArray = new Control[60];


        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                button.Visible = false;
                

            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                button.Visible = false;

            whoseTurnComboBox.Visible = false;
            whoseTurnLabel.Visible = false;

            
            // Player 1 Ship Array Start -------------
            // One Cell Ships
            pl1shipArray[0] = pl1OneShipN1; // Заношу кнопки в массив, чтобы потом можно было считывать их координаты через цикл
            pl1shipArray[1] = pl1OneShipN2; // Каждая часть кораблика является отдельной кнопкой
            pl1shipArray[2] = pl1OneShipN3;
            pl1shipArray[3] = pl1OneShipN4;

            // Two Cell Ships
            pl1shipArray[4] = pl1TwoShipN1P1;
            pl1shipArray[5] = pl1TwoShipN1P2;

            pl1shipArray[6] = pl1TwoShipN2P1;
            pl1shipArray[7] = pl1TwoShipN2P2;

            pl1shipArray[8] = pl1TwoShipN3P1;
            pl1shipArray[9] = pl1TwoShipN3P2;

            // Three Cell Ships
            pl1shipArray[10] = pl1ThreeShipN1P1;
            pl1shipArray[11] = pl1ThreeShipN1P2;
            pl1shipArray[12] = pl1ThreeShipN1P3;

            pl1shipArray[13] = pl1ThreeShipN2P1;
            pl1shipArray[14] = pl1ThreeShipN2P2;
            pl1shipArray[15] = pl1ThreeShipN2P3;

            // Four Cell Ship
            pl1shipArray[16] = pl1FourShipP1;
            pl1shipArray[17] = pl1FourShipP2;
            pl1shipArray[18] = pl1FourShipP3;
            pl1shipArray[19] = pl1FourShipP4;
            // Player 1 Ship Array Finish -------------

            // Player 2 Ship Array Start ------------
            pl2shipArray[0] = pl2OneShipN1;
            pl2shipArray[1] = pl2OneShipN2;
            pl2shipArray[2] = pl2OneShipN3;
            pl2shipArray[3] = pl2OneShipN4;

            // Two Cell Ships
            pl2shipArray[4] = pl2TwoShipN1P1;
            pl2shipArray[5] = pl2TwoShipN1P2;

            pl2shipArray[6] = pl2TwoShipN2P1;
            pl2shipArray[7] = pl2TwoShipN2P2;

            pl2shipArray[8] = pl2TwoShipN3P1;
            pl2shipArray[9] = pl2TwoShipN3P2;

            // Three Cell Ships
            pl2shipArray[10] = pl2ThreeShipN1P1;
            pl2shipArray[11] = pl2ThreeShipN1P2;
            pl2shipArray[12] = pl2ThreeShipN1P3;

            pl2shipArray[13] = pl2ThreeShipN2P1;
            pl2shipArray[14] = pl2ThreeShipN2P2;
            pl2shipArray[15] = pl2ThreeShipN2P3;

            // Four Cell Ship
            pl2shipArray[16] = pl2FourShipP1;
            pl2shipArray[17] = pl2FourShipP2;
            pl2shipArray[18] = pl2FourShipP3;
            pl2shipArray[19] = pl2FourShipP4;
            // Player 2 Ship Array Finish ------------
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
                case "Игрок 1":
                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                    {
                        button.BackColor = System.Drawing.SystemColors.Menu;
                        button.Enabled = true;
                    }
                    foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                    {
                        button.BackColor = DefaultBackColor;
                        button.Enabled = false;
                    }
                    foreach (Control ctrl in pl1shipArray)
                    {
                        ctrl.BackColor = System.Drawing.Color.DeepSkyBlue;
                    }
                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                    {
                        button.Click += new System.EventHandler(checkTheHit_Click);
                    }
                    break;

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
                    foreach (Control ctrl in pl2shipArray)
                    {
                        ctrl.BackColor = System.Drawing.Color.DeepSkyBlue;
                    }
                    foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                    {
                        button.Click += new System.EventHandler(checkTheHit_Click);
                    }
                    break;
            }
            
        }

        
        public void hitChecking(Control pushedButton, Control[] arrayOfShips)
        {
           

            for (int i = 0; i < arrayOfShips.Length; i++)
            {
                if (pushedButton.Location == arrayOfShips[i].Location)
                {
                    arrayOfShips[i].BackColor = System.Drawing.Color.Red;
                }
            }
        }
        void checkTheHit_Click(Object sender,  EventArgs e)
        {
            Button clickedButton = (Button)sender;
            for (int i = 0; i < 20; i++)
            {
                if (clickedButton.Location == pl1shipArray[i].Location)
                {
                    clickedButton.BackColor = System.Drawing.Color.Red;
                    clickedButton.Enabled = false;
                }
                if (clickedButton.Location == pl2shipArray[i].Location)
                {
                    clickedButton.BackColor = System.Drawing.Color.Red;
                    clickedButton.Enabled = false;
                }
            }
        }

        
    }
}
