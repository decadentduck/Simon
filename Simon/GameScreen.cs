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
using System.Media;

namespace Simon
{
    public partial class GameScreen : UserControl
    {
        public static int patternPlace;

        //SoundPlayer[]
        SoundPlayer green = new SoundPlayer(Properties.Resources.green);
        SoundPlayer blue = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer yellow = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer red = new SoundPlayer(Properties.Resources.red);
        SoundPlayer wrong = new SoundPlayer(Properties.Resources.mistake);

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

        /// <summary>
        /// Creates the Computers random pattern that the user needs to follow. 
        /// Then flashes colours in the pattern order and plays sounds.
        /// </summary>
        private void ComputerTurn()
        {
            turnLabel.Text = "Computer's Turn";
            Thread.Sleep(500);

            Random rand = new Random();
            Form1.pattern.Add(rand.Next(0,4));

            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                
                switch (Form1.pattern[i])
                {
                    case 0:
                        greenButton.BackColor = Color.LightGreen;
                        green.Play();
                        break;
                    case 1:
                        blueButton.BackColor = Color.LightBlue;
                        blue.Play();
                        break;
                    case 2:
                        redButton.BackColor = Color.Pink;
                        red.Play();
                        break;
                    case 3:
                        yellowButton.BackColor = Color.LightYellow;
                        yellow.Play();
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

        /// <summary>
        /// For each button click the program will compare the user's input to the pattern they are supposed to be following
        /// if they get the pattern correct it will go to the computer turn to add to the pattern
        /// if the input does not match it goes to the game over screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[patternPlace] == 0)
            {
                green.Play();
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
            if (Form1.pattern[patternPlace] == 1)
            {
                blue.Play();
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
            if (Form1.pattern[patternPlace] == 2)
            {
                red.Play();
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
            if (Form1.pattern[patternPlace] == 3)
            {
                yellow.Play();
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
            wrong.Play();
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen go = new GameOverScreen();
            f.Controls.Add(go);
        }
    }
}
