using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text = String.Format("Minimum Bet: ${0}", betNumericUpDown.Minimum);

            greyhounds[0] = new Greyhound(dogPicture1, randomizer, raceTrackPicture.Width - dogPicture1.Width);
            greyhounds[1] = new Greyhound(dogPicture2, randomizer, raceTrackPicture.Width - dogPicture2.Width);
            greyhounds[2] = new Greyhound(dogPicture3, randomizer, raceTrackPicture.Width - dogPicture3.Width);
            greyhounds[3] = new Greyhound(dogPicture4, randomizer, raceTrackPicture.Width - dogPicture4.Width);

            guys[0] = new Guy("Joe", 50, joesBetLabel,joeRadioButton);
            guys[1] = new Guy("Bob", 100, bobsBetLabel, bobRadioButton);
            guys[2] = new Guy("Al", 75, alsBetLabel, AlRadioButton);
        }

        Random randomizer = new Random();
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];

        private void raceButton_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in guys)
            {
                guy.HoldBets();
            }

            timer1.Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in guys)
            {
                if (guy.RadioButton.Checked == true)
                {
                    bool betOk = guy.PlaceBet(betNumericUpDown.Value, (int)dogNumericUpDown.Value);
                    guy.UpdateLabels(betOk);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Greyhound greyhound in greyhounds)
            {
                if (greyhound.Run())
                {
                    timer1.Stop();
                    MessageBox.Show(String.Format("Dog #{0} won the race!", greyhound.Number), "Race Over", MessageBoxButtons.OK);

                    foreach (var hound  in greyhounds)
                    {
                        hound.TakeStartingPosition();
                    }

                    foreach (Guy guy in guys)
                    {
                        if (guy.Bet.Dog == Convert.ToInt32(greyhound.Number))
                        {
                            guy.Collect(true);
                        }
                        guy.Collect(false);
                        guy.ClearBet();
                        guy.ResumeBets();
                        guy.UpdateLabels();
                    }
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNameLabel.Text = "Joe bets";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNameLabel.Text = "Bob bets";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNameLabel.Text = "Al bets";
        }
    }
}
