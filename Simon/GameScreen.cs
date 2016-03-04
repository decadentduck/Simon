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
            Thread.Sleep(3000);
            
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            turnLabel.Text = "Computer's Turn";
            Thread.Sleep(500);

            Random rand = new Random();
            Form1.pattern.Add(rand.Next(0,4));

            //TODO Add audio when buttons flash

            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                
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

                Refresh();
                Thread.Sleep(600);

            }

            patternPlace = 0;
            turnLabel.Text = "Your Turn";
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO AUDIO green
            if (Form1.pattern[patternPlace] == 0)
            {
                greenButton.BackColor = Color.LightGreen;
                Refresh();
                Thread.Sleep(700);
                greenButton.BackColor = Color.Green;
                Refresh();

                patternPlace++;
                if(patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            //TODO Audio BLUE
            if (Form1.pattern[patternPlace] == 1)
            {
                blueButton.BackColor = Color.LightBlue;
                Refresh();
                Thread.Sleep(700);
                blueButton.BackColor = Color.Blue;
                Refresh();

                patternPlace++;
                if (patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            //TODO audio Red
            if (Form1.pattern[patternPlace] == 2)
            {
                redButton.BackColor = Color.Pink;
                Refresh();
                Thread.Sleep(700);
                redButton.BackColor = Color.Red;
                Refresh();

                patternPlace++;
                if (patternPlace == Form1.pattern.Count) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            //TODO audio yellow
            if (Form1.pattern[patternPlace] == 3)
            {
                yellowButton.BackColor = Color.LightYellow;
                Refresh();
                Thread.Sleep(700);
                yellowButton.BackColor = Color.Yellow;
                Refresh();

                patternPlace++;
                if (patternPlace == Form1.pattern.Count ) { ComputerTurn(); }
            }
            else { GameOver(); }
        }

        private void GameOver()
        {
            //TODO play sound 
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen go = new GameOverScreen();
            f.Controls.Add(go);
        }
    }
}
