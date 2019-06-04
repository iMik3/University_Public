/*************************************************************************************************

This program implements in a simple way the "Snakes and Ladders" game.

MAIN MENU FORM

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
    public partial class MainMenu : Form
    {
        public static Bitmap playerImage = Properties.Resources.pieceGreen; //player image shown in the menu (initialisated with the green piece)
        string color = "Green"; //player piece
        public static string plName = null; //player name

        public MainMenu()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e) //load the game form
        {
            new frmGame().Show(); //show the next form
            this.Hide(); //hide this form
        }

        private void btnRight_Click(object sender, EventArgs e) //right arrow button
        {
            switch (color) //switch the piece color
            {
                case "Green":
                    PlayerSelection.Image = Properties.Resources.pieceRed;
                    color = "Red";
                    break;
                case "Red":
                    PlayerSelection.Image = Properties.Resources.pieceWhite;
                    color = "White";
                    break;
                case "White":
                    PlayerSelection.Image = Properties.Resources.pieceBlack;
                    color = "Black";
                    break;
                case "Black":
                    PlayerSelection.Image = Properties.Resources.pieceGreen;
                    color = "Green";
                    break;
            }
            var idPlayerLeftSelection = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(String.Concat("piece", color)); //getting the image from the resources
            playerImage = idPlayerLeftSelection; //saving it for later
        }

        private void btnLeft_Click(object sender, EventArgs e) //left arrow button
        {
            switch (color) //switch the piece color
            {
                case "Green":
                    PlayerSelection.Image = Properties.Resources.pieceBlack;
                    color = "Black";
                    break;
                case "Black":
                    PlayerSelection.Image = Properties.Resources.pieceWhite;
                    color = "White";
                    break;
                case "White":
                    PlayerSelection.Image = Properties.Resources.pieceRed;
                    color = "Red";
                    break;
                case "Red":
                    PlayerSelection.Image = Properties.Resources.pieceGreen;
                    color = "Green";
                    break;
            }
            var idPlayerRightSelection = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(String.Concat("piece", color)); //getting the image from the resources
            playerImage = idPlayerRightSelection; //saving it for later
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            startGame.Enabled = false; //deactivating the start button during the form loading
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e) //checks the player name to ensure it respects the parameters
        {
            //if the player name is between 3 and 18 letters, saves the name for later and activates the start button
            if ((txtPlayerName.Text != "") && (txtPlayerName.TextLength >= 3) && (txtPlayerName.TextLength <= 18))
            {
                plName = txtPlayerName.Text;
                startGame.Enabled = true;
            }
            else
            {
                startGame.Enabled = false;
            }
        }
    }
}
