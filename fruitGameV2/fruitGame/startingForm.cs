/*************************************************************************************************

This program simulates a fruit machine with 3 reels of symbols, randomly chosen each time 
the player presses the button "spin".

The image 7 represents "Big Win"
The image 8 represents "Bar"

- Any combination of 2 equal numbers (excluding 7 and 8) will add 5 points to the score
- Any combination of 3 equal numbers (excluding 7 and 8) will add 15 points to the score
- Any combination of 2 equal numbers (7 or 8) will add 200 points to the score
- Any combination of 3 equal numbers (7 or 8) will add 2000 points to the score
- Any combination of 3 different numbers will decrease the score of 50 points

STARTING FORM

Michele Chiarello : michele[dot]chiarello[at]gmail[dot]com

**************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitGame
{


    public partial class startingForm : Form
    {
        System.Media.SoundPlayer coin = new System.Media.SoundPlayer(Properties.Resources.noSound); //creates an empty audio object before, to avoid a delay during the coin sound play. VS Studio Bug?! :)
        public static int startingScore = 0; //player's starting credits

        public startingForm()
        {
            InitializeComponent();
            coin.Play(); //plays the previous empty audio file now, during the initialisation
        }

        private void startingForm_Load(object sender, EventArgs e)
        {
            coin = new System.Media.SoundPlayer(Properties.Resources.insert_coin); //assigning to the coin object the real audio resource
        }

        private void btnExit_Click(object sender, EventArgs e) //closes the application
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Sets the startingScore to 5, plays the animation sound and loads the next form
        {
            coin.Play(); //now the animation will not have any delay
            startingScore = 5;
            new frmGame().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //Sets the startingScore to 15, plays the animation sound and loads the next form
        {
            coin.Play();
            startingScore = 15;
            new frmGame().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //Sets the startingScore to 200, plays the animation sound and loads the next form
        {
            coin.Play();
            startingScore = 200;
            new frmGame().Show();
            this.Hide();
        }
    }
}
