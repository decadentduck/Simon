using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon
{
    public partial class GameScreen : UserControl
    {
        public static int patternPlace;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(5000);
            
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random rand = new Random();
            Form1.pattern.Add(rand.Next(0,4));

            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                Thread.Sleep(700);

                switch (Form1.pattern[i])
                {
                    case 0:
                        greenButton.BackColor = Color.LightGreen;
                        break;
                    case 1:
                        blueButton.BackColor = Color.LightBlue;
                        break;
                    case 2:
                        redButton.BackColor = Color.Pink;
                        break;
                    case 3:
                        yellowButton.BackColor = Color.LightYellow;
                        break;
                    default:
                        break;
                }

                Refresh();
                Thread.Sleep(500);

                greenButton.BackColor = Color.Green;
                blueButton.BackColor = Color.Blue;
                redButton.BackColor = Color.Red;
                yellowButton.BackColor = Color.Yellow;
            }

            patternPlace = 0;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[patternPlace] == 0)
            {
                greenButton.BackColor = Color.LightGreen;
                Thread.Sleep(500);
                greenButton.BackColor = Color.Green;

                patternPlace++;
                if(patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[patternPlace] == 1)
            {
                blueButton.BackColor = Color.LightBlue;
                Thread.Sleep(500);
                blueButton.BackColor = Color.Blue;

                patternPlace++;
                if (patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[patternPlace] == 2)
            {
                redButton.BackColor = Color.Pink;
                Thread.Sleep(500);
                redButton.BackColor = Color.Red;

                patternPlace++;
                if (patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[patternPlace] == 3)
            {
                yellowButton.BackColor = Color.LightYellow;
                Thread.Sleep(500);
                yellowButton.BackColor = Color.Yellow;

                patternPlace++;
                if (patternPlace == Form1.pattern.Count ) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void GameOver()
        {
            //play sound and call up a new screen
            GameOverScreen go = new GameOverScreen();
            this.Controls.Add(go);
            go.BringToFront();
        }
    }
}
