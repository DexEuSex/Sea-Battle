using System;
using System.Drawing;
using System.Linq;
using System.Media;
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
        Control[] pl1emptyCellArray = new Control[80];
        Control[] pl2emptyCellArray = new Control[80];
        int whoseTurn = 0; // Переменная, проверяющая текущий ход. Непарнео число - ход первого игрока. Парное число - ход второго игрока.
        
        async private void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(100);
            
            //SoundPlayer mainTheme = new SoundPlayer(@"content\music\seabattlemain.wav");
            //mainTheme.Play(); Добавлю в будущем

            #region Player 1 Ships Storage
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
            #endregion
            #region Player 2 Ships Storage
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
            #region Player 1 Empty Cells Storage
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
            #region Player 2 Empty Cells Storage
            pl2emptyCellArray[0] =  pl2EmptyButton1;
            pl2emptyCellArray[1] =  pl2EmptyButton2;
            pl2emptyCellArray[2] =  pl2EmptyButton3;
            pl2emptyCellArray[3] =  pl2EmptyButton4;
            pl2emptyCellArray[4] =  pl2EmptyButton5;
            pl2emptyCellArray[5] =  pl2EmptyButton6;
            pl2emptyCellArray[6] =  pl2EmptyButton7;
            pl2emptyCellArray[7] =  pl2EmptyButton8;
            pl2emptyCellArray[8] =  pl2EmptyButton9;
            pl2emptyCellArray[9] =  pl2EmptyButton10;
            pl2emptyCellArray[10] = pl2EmptyButton11;
            pl2emptyCellArray[11] = pl2EmptyButton12;
            pl2emptyCellArray[12] = pl2EmptyButton13;
            pl2emptyCellArray[13] = pl2EmptyButton14;
            pl2emptyCellArray[14] = pl2EmptyButton15;
            pl2emptyCellArray[15] = pl2EmptyButton16;
            pl2emptyCellArray[16] = pl2EmptyButton17;
            pl2emptyCellArray[17] = pl2EmptyButton18;
            pl2emptyCellArray[18] = pl2EmptyButton19;
            pl2emptyCellArray[19] = pl2EmptyButton20;
            pl2emptyCellArray[20] = pl2EmptyButton21;
            pl2emptyCellArray[21] = pl2EmptyButton22;
            pl2emptyCellArray[22] = pl2EmptyButton23;
            pl2emptyCellArray[23] = pl2EmptyButton24;
            pl2emptyCellArray[24] = pl2EmptyButton25;
            pl2emptyCellArray[25] = pl2EmptyButton26;
            pl2emptyCellArray[26] = pl2EmptyButton27;
            pl2emptyCellArray[27] = pl2EmptyButton28;
            pl2emptyCellArray[28] = pl2EmptyButton29;
            pl2emptyCellArray[29] = pl2EmptyButton30;
            pl2emptyCellArray[30] = pl2EmptyButton31;
            pl2emptyCellArray[31] = pl2EmptyButton32;
            pl2emptyCellArray[32] = pl2EmptyButton33;
            pl2emptyCellArray[33] = pl2EmptyButton34;
            pl2emptyCellArray[34] = pl2EmptyButton35;
            pl2emptyCellArray[35] = pl2EmptyButton36;
            pl2emptyCellArray[36] = pl2EmptyButton37;
            pl2emptyCellArray[37] = pl2EmptyButton38;
            pl2emptyCellArray[38] = pl2EmptyButton39;
            pl2emptyCellArray[39] = pl2EmptyButton40;
            pl2emptyCellArray[40] = pl2EmptyButton41;
            pl2emptyCellArray[41] = pl2EmptyButton42;
            pl2emptyCellArray[42] = pl2EmptyButton43;
            pl2emptyCellArray[43] = pl2EmptyButton44;
            pl2emptyCellArray[44] = pl2EmptyButton45;
            pl2emptyCellArray[45] = pl2EmptyButton46;
            pl2emptyCellArray[46] = pl2EmptyButton47;
            pl2emptyCellArray[47] = pl2EmptyButton48;
            pl2emptyCellArray[48] = pl2EmptyButton49;
            pl2emptyCellArray[49] = pl2EmptyButton50;
            pl2emptyCellArray[50] = pl2EmptyButton51;
            pl2emptyCellArray[51] = pl2EmptyButton52;
            pl2emptyCellArray[52] = pl2EmptyButton53;
            pl2emptyCellArray[53] = pl2EmptyButton54;
            pl2emptyCellArray[54] = pl2EmptyButton55;
            pl2emptyCellArray[55] = pl2EmptyButton56;
            pl2emptyCellArray[56] = pl2EmptyButton57;
            pl2emptyCellArray[57] = pl2EmptyButton58;
            pl2emptyCellArray[58] = pl2EmptyButton59;
            pl2emptyCellArray[59] = pl2EmptyButton60;
            pl2emptyCellArray[60] = pl2EmptyButton61;
            pl2emptyCellArray[61] = pl2EmptyButton62;
            pl2emptyCellArray[62] = pl2EmptyButton63;
            pl2emptyCellArray[63] = pl2EmptyButton64;
            pl2emptyCellArray[64] = pl2EmptyButton65;
            pl2emptyCellArray[65] = pl2EmptyButton66;
            pl2emptyCellArray[66] = pl2EmptyButton67;
            pl2emptyCellArray[67] = pl2EmptyButton68;
            pl2emptyCellArray[68] = pl2EmptyButton69;
            pl2emptyCellArray[69] = pl2EmptyButton70;
            pl2emptyCellArray[70] = pl2EmptyButton71;
            pl2emptyCellArray[71] = pl2EmptyButton72;
            pl2emptyCellArray[72] = pl2EmptyButton73;
            pl2emptyCellArray[73] = pl2EmptyButton74;
            pl2emptyCellArray[74] = pl2EmptyButton75;
            pl2emptyCellArray[75] = pl2EmptyButton76;
            pl2emptyCellArray[76] = pl2EmptyButton77;
            pl2emptyCellArray[77] = pl2EmptyButton78;
            pl2emptyCellArray[78] = pl2EmptyButton79;
            pl2emptyCellArray[79] = pl2EmptyButton80;
            #endregion

            foreach (Button button in groupBoxPL1.Controls.OfType<Button>())
            {
                button.Click += new EventHandler(checkTheHitOnPL1Array_Click);
                button.BackColor = SystemColors.Menu;
                button.Visible = true;
                button.Enabled = true;
            }
            foreach (Button button in groupBoxPL2.Controls.OfType<Button>())
            {
                button.Click += new EventHandler(checkTheHitOnPL2Array_Click);
                button.BackColor = SystemColors.Menu;
                button.Visible = true;
                button.Enabled = true;
            }
            
            mainButton.Visible = false;
            hidePL1BFButton.Visible = false; // Скрытие кнопок, отвечающих за включение режима невидимости игрового поля игрока
            hidePL2BFButton.Visible = false; // Скрытие кнопок, отвечающих за включение режима невидимости игрового поля игрока
            hidePL1BFButton.Enabled = false;
            hidePL2BFButton.Enabled = false;

            whoseTurnComboBox.Visible = true;
            whoseTurnComboBox.Enabled = false;
            whoseTurnLabel.Visible = true;
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            whoseTurn++;
            if (whoseTurn > 2)
                whoseTurn--;

            mainButton.Visible = true;
            startButton.Visible = false;
            mainButton.Text = "Передать ход другому игроку";
            switchTheSide();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            whoseTurn++;
            hidePL1BFButton.Visible = false;
            hidePL2BFButton.Visible = false;
            switchTheSide();
        }

        void CheckTHeVinner()
        {
            if (pl1WinBar.Value == 100)
            {
                MessageBox.Show("Игрок 1 победил!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pl2WinBar.Value == 100)
            {
                MessageBox.Show("Игрок 2 победил!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //void checkTheHit_Click(Object sender, EventArgs e)
        //{
        //    Button clickedButton = (Button)sender;
        //    for (int i = 0; i < pl1shipArray.Length; i++)
        //    {
        //        if (clickedButton.Location == pl1shipArray[i].Location)
        //        {
        //            clickedButton.BackColor = Color.Red;
        //            clickedButton.Enabled = false;

        //        }
        //        else if (clickedButton.Location == pl2shipArray[i].Location)
        //        {
        //            clickedButton.BackColor = Color.Red;
        //            clickedButton.Enabled = false;
        //        }
        //        else 
        //        {
        //            clickedButton.Enabled = false;
        //        }
        //    }
        //    if (clickedButton.BackColor != Color.Red) // Проверка на "непопадание" в корабль противника
        //    {
        //        if (whoseTurn % 2 != 0)
        //        {
        //            hidePL1BFButton.Visible = true;
        //            hidePL2BFButton.Visible = true;
        //            hidePL1BFButton.Text = "Игрок 1 промазал! Игрок 2, ваш ход!";


        //        }
        //        else if (whoseTurn % 2 == 0)
        //        {
        //            hidePL1BFButton.Visible = true;
        //            hidePL2BFButton.Visible = true;
        //            hidePL2BFButton.Text = "Игрок 2 промазал! Игрок 1, ваш ход!";
        //        }
        //    }
        //}

        void checkTheHitOnPL1Array_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            for (int i = 0; i < pl1shipArray.Length; i++)
            {
                if (clickedButton.Location == pl1shipArray[i].Location)
                {
                    pl2WinBar.Value += 5;
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Enabled = false;
                }
                else
                {
                    clickedButton.Enabled = false;
                }
            }
            if (clickedButton.BackColor != Color.Red) // Проверка на "непопадание" в корабль противника
            {
                clickedButton.BackColor = Color.Gray;
                hidePL1BFButton.Visible = true;
                hidePL2BFButton.Visible = true;
                hidePL1BFButton.Text = "Игрок 2 промазал! Игрок 1, ваш ход!";
            }
            CheckTHeVinner();
        }
        void checkTheHitOnPL2Array_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            for (int i = 0; i < pl2shipArray.Length; i++)
            {
                if (clickedButton.Location == pl2shipArray[i].Location)
                {
                    pl1WinBar.Value += 5;
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Enabled = false;
                }
                else
                {
                    clickedButton.Enabled = false;
                }
            }
            if (clickedButton.BackColor != Color.Red) // Проверка на "непопадание" в корабль противника
            {
                clickedButton.BackColor = Color.Gray;
                hidePL1BFButton.Visible = true;
                hidePL2BFButton.Visible = true;
                hidePL1BFButton.Text = "Игрок 1 промазал! Игрок 2, ваш ход!";
            }
            CheckTHeVinner();
        }


        void switchTheSide()
        {
            
            if (whoseTurn % 2 != 0) // Если очередь игрока 1
            {
                    whoseTurnComboBox.SelectedIndex = 0; // Выводит в Combobox, что сейчас ход первого игрока
                    hintLabel.Text = "Игрок 1, расположение ваших кораблей вы видите слева. Справа - корабли противника";
                    mainButton.Text = "Передать хоть второму игроку";

                    foreach (Button button in groupBoxPL2.Controls.OfType<Button>()) // Отрисовка поля противника перед началом боя
                    {
                        
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                        if (button.BackColor == Color.Gray)
                        {
                            button.BackColor = Color.Gray;
                            button.Enabled = false;
                        }
                        if (button.BackColor != Color.Red && button.BackColor != Color.Gray)
                        {
                            button.BackColor = SystemColors.Menu;
                            button.Enabled = true;
                        }
                    }

                    for (int i = 0; i < pl1emptyCellArray.Length; i++)
                    {
                        pl1emptyCellArray[i].BackColor = (pl1emptyCellArray[i].BackColor == Color.Gray ? Color.Gray : SystemColors.Menu);
                        pl1emptyCellArray[i].Enabled = false;
                    }

                    for (int i = 0; i < pl1shipArray.Length; i++)
                    {
                        pl1shipArray[i].BackColor = (pl1shipArray[i].BackColor == Color.Red ? Color.Red : Color.DeepSkyBlue);
                        pl1shipArray[i].Enabled = false;
                    }
            }
                
            else if (whoseTurn % 2 == 0) // Если очередь игрока 2
            {
                    whoseTurnComboBox.SelectedIndex = 1; // Выводит в Combobox, что сейчас ход второго игрока
                    hintLabel.Text = "Игрок 2, расположение ваших кораблей вы видите справа. Слева - корабли противника";
                    mainButton.Text = "Передать хоть второму игроку";

                    foreach (Button button in groupBoxPL1.Controls.OfType<Button>()) // Отрисовка поля противника перед началом боя
                    {
                        
                        if (button.BackColor == Color.Red)
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                        if (button.BackColor == Color.Gray)
                        {
                            button.BackColor = Color.Gray;
                            button.Enabled = false;
                        }
                        if (button.BackColor != Color.Red && button.BackColor != Color.Gray)
                        {
                            button.BackColor = SystemColors.Menu;
                            button.Enabled = true;
                        }
                    }

                    for (int i = 0; i < pl2emptyCellArray.Length; i++)
                    {
                        pl2emptyCellArray[i].BackColor = (pl2emptyCellArray[i].BackColor == Color.Gray ? Color.Gray : SystemColors.Menu);
                        pl2emptyCellArray[i].Enabled = false;
                    }

                    for (int i = 0; i < pl2shipArray.Length; i++)
                    {
                        pl2shipArray[i].BackColor = (pl2shipArray[i].BackColor == Color.Red ? Color.Red : Color.DeepSkyBlue);
                        pl2shipArray[i].Enabled = false;
                    }
            }
            
        }

    }
}
