using System;
using System.Drawing;
using System.Linq;
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
        Control[] pl1emptyCellArray = new Control[80];
        Control[] pl2emptyCellArray = new Control[60];


        private void Form1_Load(object sender, EventArgs e)
        {
            #region ShipStorage
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
            #endregion
            #region EmptyCellsStorage
            pl1emptyCellArray[0]  = pl1EmptyButton1;
            pl1emptyCellArray[1]  = pl1EmptyButton2;
            pl1emptyCellArray[2]  = pl1EmptyButton3;
            pl1emptyCellArray[3]  = pl1EmptyButton4;
            pl1emptyCellArray[4]  = pl1EmptyButton5;
            pl1emptyCellArray[5]  = pl1EmptyButton6;
            pl1emptyCellArray[6]  = pl1EmptyButton7;
            pl1emptyCellArray[7]  = pl1EmptyButton8;
            pl1emptyCellArray[8]  = pl1EmptyButton9;
            pl1emptyCellArray[9]  = pl1EmptyButton10;
            pl1emptyCellArray[10] = pl1EmptyButton11;
            pl1emptyCellArray[11] = pl1EmptyButton12;
            pl1emptyCellArray[12] = pl1EmptyButton13;
            pl1emptyCellArray[13] = pl1EmptyButton14;
            pl1emptyCellArray[14] = pl1EmptyButton15;
            pl1emptyCellArray[15] = pl1EmptyButton16;
            pl1emptyCellArray[16] = pl1EmptyButton17;
            pl1emptyCellArray[17] = pl1EmptyButton18;
            pl1emptyCellArray[18] = pl1EmptyButton19;
            pl1emptyCellArray[19] = pl1EmptyButton20;
            pl1emptyCellArray[20] = pl1EmptyButton21;
            pl1emptyCellArray[21] = pl1EmptyButton22;
            pl1emptyCellArray[22] = pl1EmptyButton23;
            pl1emptyCellArray[23] = pl1EmptyButton24;
            pl1emptyCellArray[24] = pl1EmptyButton25;
            pl1emptyCellArray[25] = pl1EmptyButton26;
            pl1emptyCellArray[26] = pl1EmptyButton27;
            pl1emptyCellArray[27] = pl1EmptyButton28;
            pl1emptyCellArray[28] = pl1EmptyButton29;
            pl1emptyCellArray[29] = pl1EmptyButton30;
            pl1emptyCellArray[30] = pl1EmptyButton31;
            pl1emptyCellArray[31] = pl1EmptyButton32;
            pl1emptyCellArray[32] = pl1EmptyButton33;
            pl1emptyCellArray[33] = pl1EmptyButton34;
            pl1emptyCellArray[34] = pl1EmptyButton35;
            pl1emptyCellArray[35] = pl1EmptyButton36;
            pl1emptyCellArray[36] = pl1EmptyButton37;
            pl1emptyCellArray[37] = pl1EmptyButton38;
            pl1emptyCellArray[38] = pl1EmptyButton39;
            pl1emptyCellArray[39] = pl1EmptyButton40;
            pl1emptyCellArray[40] = pl1EmptyButton41;
            pl1emptyCellArray[41] = pl1EmptyButton42;
            pl1emptyCellArray[42] = pl1EmptyButton43;
            pl1emptyCellArray[43] = pl1EmptyButton44;
            pl1emptyCellArray[44] = pl1EmptyButton45;
            pl1emptyCellArray[45] = pl1EmptyButton46;
            pl1emptyCellArray[46] = pl1EmptyButton47;
            pl1emptyCellArray[47] = pl1EmptyButton48;
            pl1emptyCellArray[48] = pl1EmptyButton49;
            pl1emptyCellArray[49] = pl1EmptyButton50;
            pl1emptyCellArray[50] = pl1EmptyButton51;
            pl1emptyCellArray[51] = pl1EmptyButton52;
            pl1emptyCellArray[52] = pl1EmptyButton53;
            pl1emptyCellArray[53] = pl1EmptyButton54;
            pl1emptyCellArray[54] = pl1EmptyButton55;
            pl1emptyCellArray[55] = pl1EmptyButton56;
            pl1emptyCellArray[56] = pl1EmptyButton57;
            pl1emptyCellArray[57] = pl1EmptyButton58;
            pl1emptyCellArray[58] = pl1EmptyButton59;
            pl1emptyCellArray[59] = pl1EmptyButton60;
            pl1emptyCellArray[60] = pl1EmptyButton61;
            pl1emptyCellArray[61] = pl1EmptyButton62;
            pl1emptyCellArray[62] = pl1EmptyButton63;
            pl1emptyCellArray[63] = pl1EmptyButton64;
            pl1emptyCellArray[64] = pl1EmptyButton65;
            pl1emptyCellArray[65] = pl1EmptyButton66;
            pl1emptyCellArray[66] = pl1EmptyButton67;
            pl1emptyCellArray[67] = pl1EmptyButton68;
            pl1emptyCellArray[68] = pl1EmptyButton69;
            pl1emptyCellArray[69] = pl1EmptyButton70;
            pl1emptyCellArray[70] = pl1EmptyButton71;
            pl1emptyCellArray[71] = pl1EmptyButton72;
            pl1emptyCellArray[72] = pl1EmptyButton73;
            pl1emptyCellArray[73] = pl1EmptyButton74;
            pl1emptyCellArray[74] = pl1EmptyButton75;
            pl1emptyCellArray[75] = pl1EmptyButton76;
            pl1emptyCellArray[76] = pl1EmptyButton77;
            pl1emptyCellArray[77] = pl1EmptyButton78;
            pl1emptyCellArray[78] = pl1EmptyButton79;
            pl1emptyCellArray[79] = pl1EmptyButton80;
            #endregion

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                button.Visible = false;


            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                button.Visible = false;

            whoseTurnComboBox.Visible = false;
            whoseTurnLabel.Visible = false;


        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            hintLabel.Text = "Выберите, чей ход!";
            whoseTurnComboBox.Visible = true;
            whoseTurnLabel.Visible = true;

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
            {
                button.BackColor = SystemColors.Menu;
                button.Visible = true;
                button.Enabled = true;
            }

            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
            {
                button.BackColor = SystemColors.Menu;
                button.Visible = true;
                button.Enabled = true;
            }
            switchTheSide();
        }

        void checkTheHit_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            for (int i = 0; i < 20; i++)
            {
                if (clickedButton.Location == pl1shipArray[i].Location)
                {
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Enabled = false;
                }
                if (clickedButton.Location == pl2shipArray[i].Location)
                {
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Enabled = false;
                }
                else
                {
                    clickedButton.Enabled = false;
                }
            }
        }

        void switchTheSide()
        {
            switch (whoseTurnComboBox.SelectedItem)
            {
                case "Игрок 1":
                    hintLabel.Text = "Игрок 1, расположение ваших кораблей вы видите слева. Справа - корабли противника";
                    mainButton.Text = "Передать хоть второму игроку";

                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                    {
                        button.Click += new EventHandler(checkTheHit_Click);
                        button.BackColor = SystemColors.Menu;
                        button.Enabled = true;
                    }
                    foreach (Control button in pl1emptyCellArray)
                    {
                        button.Enabled = false;
                        button.BackColor = SystemColors.Menu;
                    }
                    foreach (Button button in pl1shipArray)
                    {
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Red;
                        }
                        if (button.BackColor == SystemColors.Menu)
                        {
                            button.BackColor = Color.DeepSkyBlue;
                        }
                        button.Enabled = false;
                    }
                    break;

                case "Игрок 2":

                    hintLabel.Text = "Игрок 2, расположение ваших кораблей вы видите справа. Слева - корабли противника";
                    mainButton.Text = "Передать хоть второму игроку";

                    foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
                    {
                        button.Click += new EventHandler(checkTheHit_Click);
                        button.BackColor = SystemColors.Menu;
                        button.Enabled = true;
                    }

                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
                    {
                        if (button.Enabled == true)
                        {
                            button.BackColor = SystemColors.Menu;
                            button.Enabled = false;
                        }
                    }

                    foreach (Button button in pl2shipArray)
                    {
                        if (button.Enabled == false)
                        {
                            button.BackColor = Color.Red;
                        }
                        if (button.Enabled == true)
                        {
                            button.BackColor = Color.DeepSkyBlue;
                        }
                    }

                    
                    
                    break;
                default:
                    MessageBox.Show("Выберите, чей ход!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

    }
}
