/*************************************************************************************************

This program implements in a simple way the "Snakes and Ladders" game.

GAME OVER FORM

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

namespace SnakesAndLadders
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            lblWhoWin.Text = frmGame.who_win + " won!"; //shows the name of the winning player
            timerCredits.Enabled = true;
        }

        private void btnYes_Click(object sender, EventArgs e) //restarts the game
        {
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e) //closes the application
        {
            Application.Exit();
        }

        private void timerCredits_Tick(object sender, EventArgs e) //animates the credits label on the top with random colors
        {
            byte x = 0, y = 0, z = 0;
            Random r = new Random();

            x = (byte)r.Next(190, 256);
            y = (byte)r.Next(190, 256);
            z = (byte)r.Next(190, 256);
            lblWhoWin.ForeColor = Color.FromArgb(x, y, z);
        }
    }
}
