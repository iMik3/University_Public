/*************************************************************************************************

This program implements in a simple way the "Snakes and Ladders" game.

GAME FORM

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
    public partial class frmGame : Form
    {
        const bool MAP_DEBUG = false; //DEBUG MODE

        Player player1, computer; //creating the players objects
        string whoIsPlaying = null; //no-one is playing now
        public static string who_win = null; //no-one won yet
        byte face = 0; //initialising the die face
        mapCoordinates[] box = new mapCoordinates[100]; //array containing the 100 boxes of the map
        System.Media.SoundPlayer die_sound = new System.Media.SoundPlayer(Properties.Resources.noSound); //creating an empty audio object to avoid a sound delay during the animation of the die

        struct mapCoordinates //box data
        {
            public Int32 boxNumber; //real box number (on the map)
            public Int32 x_axis; //X coordinate
            public Int32 y_axis; //Y coordinate
            public Int32 specialBox; //contains the value of the box where to move the player if the current one is a snake or a ladder
        }

        class Player //player object data
        {
            public string player_Name = null;

            //actual player position
            public Int32 x_Position = 0;
            public Int32 y_Position = 0;

            //previous player position
            public Int32 old_x_Position = 0;
            public Int32 old_y_Position = 0;

            public byte score = 0;

            public PictureBox sprite = new PictureBox(); //player image
        }

        public frmGame()
        {
            InitializeComponent();

            populateMap(box); //initializing mapArray

            //creating the players objects
            player1 = new Player();
            computer = new Player();

            //setting players name and picture properties
            player1.player_Name = MainMenu.plName;
            player1.sprite.Image = MainMenu.playerImage;
            player1.sprite.Width = 55;
            player1.sprite.Height = 55;
            player1.sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.sprite.BackColor = Color.Transparent;

            computer.player_Name = "CPU";
            computer.sprite.Image = Properties.Resources.piecePurple;
            computer.sprite.Width = 55;
            computer.sprite.Height = 55;
            computer.sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.sprite.BackColor = Color.Transparent;

            //adding to mapContainer the players, so that they are visible on the map
            mapContainer.Controls.AddRange(new Control[] { player1.sprite, computer.sprite });

            //setting the position of the players on the map
            player1.x_Position = 70;
            player1.y_Position = 605;
            player1.old_x_Position = player1.x_Position;
            player1.old_y_Position = player1.y_Position;
            player1.sprite.Location = new Point(player1.x_Position, player1.y_Position);

            computer.x_Position = 35;
            computer.y_Position = 650;
            computer.old_x_Position = computer.x_Position;
            computer.old_y_Position = computer.y_Position;
            computer.sprite.Location = new Point(computer.x_Position, computer.y_Position);

            //updating player1 info on the form
            picPlayer.Image = MainMenu.playerImage;
            lblPlayerName.Text = MainMenu.plName;

            whoIsPlaying = player1.player_Name; //setting the game to let player1 to start
            showTurn(whoIsPlaying);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            lblTurnMessage.Visible = false;
            die_sound = new System.Media.SoundPlayer(Properties.Resources.dieThrow); //creating the real die sound animation
        }

        private async void btnDice_ClickAsync(object sender, EventArgs e)
        {
            lblTurnMessage.ForeColor = Color.Gold;
            timerTurnMessage.Enabled = false; //stopping the TurnMessage animation

            picDie.Location = new Point(1116, 470); //resetting the position of the die
            btnDice.Enabled = false; //deactivating the usage of the button
            timerDie.Enabled = true; //starting the animation of the die

            //waiting that the player1 turn is completed
            await Task.Delay(3000);

            if (lblSpecialBox.Visible)
            { //if the special box label is visible, deactivate it
                timerSpecialBox.Enabled = false;
                lblSpecialBox.Visible = false;
            }


            //computer turn
            if (who_win == null)
            {
                whoIsPlaying = computer.player_Name;
                showTurn(whoIsPlaying);
                picDie.Location = new Point(1116, 470);
                await Task.Delay(1000);
                lblTurnMessage.ForeColor = Color.Gold;
                timerDie.Enabled = true;

                //wait that the computer turn is completed
                await Task.Delay(3000);
            }

            if (lblSpecialBox.Visible)
            { //if the special box label is visible, deactivate it
                timerSpecialBox.Enabled = false;
                lblSpecialBox.Visible = false;
            }

            //again player1 turn
            whoIsPlaying = player1.player_Name;
            showTurn(whoIsPlaying);
            btnDice.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e) //terminates the application
        {
            Application.Exit();
        }

        private void populateMap(mapCoordinates[] mapArray)
        {
            /*
                     ________________ 
                    |                |
                    |                |
                    |                |
                    |                |
                    |                |
           (1st box)|________________|
                    
             
            1st box coordinates = (50, 642)
            every box is 59 x 59 px
            
             */
            Int32 current_x = 50, current_y = 642, i = 0, line_counter = 1, actual_box = 0;

            while (line_counter < 6)
            {

                for (i = 0; i < 10; i++)
                { //allocating the first row
                    mapArray[actual_box].boxNumber = (actual_box + 1);
                    mapArray[actual_box].x_axis = (current_x);
                    mapArray[actual_box].y_axis = current_y;
                    current_x += 65; // box width + gap till the next box
                    actual_box++;
                }

                current_x -= 65;
                current_y -= 66;

                for (i = 0; i < 10; i++)
                { //allocating the second row
                    mapArray[actual_box].boxNumber = (actual_box + 1);
                    mapArray[actual_box].x_axis = (current_x);
                    mapArray[actual_box].y_axis = current_y;
                    current_x -= 65; // box width + gap till the next box
                    actual_box++;
                }

                current_x += 65;
                current_y -= 66;
                line_counter++; //incrementing the line counter till 5, because we are populating the rows tow by two
            }

            /*
             * Initialising the specialBox field for every box in the map.
             * It could be avoided since in C# every array is initialised during the compilation.
             */
            for (i = 0; i < 100; i++)
            { 
                mapArray[i].specialBox = 0;
            }

            //allocating the special boxes
            mapArray[3].specialBox = 13;
            mapArray[8].specialBox = 30;
            mapArray[15].specialBox = 5;
            mapArray[20].specialBox = 41;
            mapArray[27].specialBox = 83;
            mapArray[35].specialBox = 43;
            mapArray[46].specialBox = 25;
            mapArray[48].specialBox = 29;
            mapArray[50].specialBox = 66;
            mapArray[55].specialBox = 52;
            mapArray[61].specialBox = 18;
            mapArray[62].specialBox = 59;
            mapArray[70].specialBox = 90;
            mapArray[79].specialBox = 99;
            mapArray[86].specialBox = 23;
            mapArray[92].specialBox = 72;
            mapArray[94].specialBox = 74;
            mapArray[97].specialBox = 77;

            //debug picture boxes, to check the overlapping of the virtual and the real map
            if (MAP_DEBUG)
            {
                for (int j = 0; j < 100; j++)
                {
                    PictureBox test = new PictureBox();
                    test.Width = 59;
                    test.Height = 59;
                    test.BackColor = Color.Black;
                    mapContainer.Controls.Add(test);
                    test.Location = new Point(mapArray[j].x_axis, mapArray[j].y_axis);
                }
            }
        }

        private async void checkScore(Player x) //checks the player score
        {
            x.score += face; //adding to the actual score the actual die face

            if (x.score == 79 || x.score == 99) //if the player is on the box 80 or 100
            {
                //WIN!!!
                who_win = x.player_Name;
                this.Hide();
                new frmGameOver().Show();
            }
            else if (x.score > 99)
            {
                x.score = Convert.ToByte(99 - (x.score - 99)); //decreasing the score going back on the boxes
            }
            if (box[x.score].specialBox != 0)
            { //changing the score if the player is on a special box
                movePlayer(x); //and after moving the player to the special box before to move it on the destination
                x.score = Convert.ToByte(box[x.score].specialBox); //updating the score
                timerSpecialBox.Enabled = true;
                await Task.Delay(800);
            }
            movePlayer(x); //moving the player after recalculating the score
        }

        private void showTurn(string name) //changes the turn message
        {
            if (name != "CPU")
            {
                lblTurnMessage.Text = "It's your turn!";
            }
            else
            {
                lblTurnMessage.Text = "It's CPU turn!";
            }
            timerTurnMessage.Enabled = true;
        }

        private void movePlayer(Player pl)
        {
            //saving the actual coordinates of the sprite of the player to the variables containing the old position
            pl.old_x_Position = pl.x_Position;
            pl.old_y_Position = pl.y_Position;

            //updating the actual coordinates
            pl.x_Position = box[pl.score].x_axis;
            pl.y_Position = box[pl.score].y_axis;

            timerPlayer.Enabled = true; //calling the function in the timer to move it
        }

        private void timerPlayer_Tick(object sender, EventArgs e) //moves the player
        {

            if (whoIsPlaying != "CPU") //if the actual player is player1
            {
                if (player1.old_x_Position != player1.x_Position || player1.old_y_Position != player1.y_Position)
                {
                    picPlayer.Refresh(); //refreshes the image to avoid flickering
                    player1.sprite.Location = new Point(player1.x_Position, player1.y_Position);
                }
            }
            else //if the player is the CPU
            {
                if (computer.old_x_Position != computer.x_Position || computer.old_y_Position != computer.y_Position)
                {
                    picCPU.Refresh(); //refreshes the image to avoid flickering
                    computer.sprite.Location = new Point(computer.x_Position, computer.y_Position);
                }
            }

            if (player1.x_Position == computer.x_Position && player1.y_Position == computer.y_Position)
            { //if the players are on the same box, shifts the picture boxes to don't overlap them
                picPlayer.Refresh();
                picCPU.Refresh();
                player1.sprite.Location = new Point(player1.x_Position + 20, player1.y_Position - 40);
                computer.sprite.Location = new Point(computer.x_Position - 15, computer.y_Position + 10);
            }
            timerPlayer.Enabled = false;
        }

        private void timerDie_Tick(object sender, EventArgs e) //animates the die
        {
            Random r = new Random();
            die_sound.Play();

            while (picDie.Left > 989 || picDie.Top > 279) //Moving the dice
            {
                face = (byte)r.Next(1, 7); //generates random number from 1 to 6
                var dieFace = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(String.Concat("dieRed_", face));
                picDie.Image = dieFace;

                picDie.Refresh(); //refreshes the image to avoid flickering
                if (picDie.Left > 989) { picDie.Left -= 6; } //decrease X
                if (picDie.Top > 279) { picDie.Top -= 10; } //decrease Y
                picDie.Location = new Point(picDie.Left, picDie.Top); //draw the dice
            }
            if (whoIsPlaying != "CPU")
            {
                checkScore(player1);
                lblPlayerScore.Text = Convert.ToString(player1.score + 1); //updates the player score
            }
            else
            {
                checkScore(computer);
                lblCpuScore.Text = Convert.ToString(computer.score + 1); //updates the CPU score
            }
            timerDie.Enabled = false;
        }

        private void timerSpecialBox_Tick(object sender, EventArgs e) //if the player is on a special box, shows it on the screen
        {
            lblSpecialBox.Visible = true;

            if (lblSpecialBox.ForeColor == Color.Gold)
            {
                lblSpecialBox.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                lblSpecialBox.ForeColor = Color.Gold;
            }
        }

        private void timerTurnMessage_Tick(object sender, EventArgs e) //animates the colors of the label that shows the player turns
        {
            lblTurnMessage.Visible = true;

            if (lblTurnMessage.ForeColor == Color.Gold)
            {
                lblTurnMessage.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                lblTurnMessage.ForeColor = Color.Gold;
            }
        }
    }
}