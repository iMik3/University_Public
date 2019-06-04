namespace SnakesAndLadders
{
    partial class frmGame
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnExit = new System.Windows.Forms.Button();
            this.mapContainer = new System.Windows.Forms.PictureBox();
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.lblCpuName = new System.Windows.Forms.Label();
            this.picDie = new System.Windows.Forms.PictureBox();
            this.btnDice = new System.Windows.Forms.Button();
            this.timerDie = new System.Windows.Forms.Timer(this.components);
            this.lblTurnMessage = new System.Windows.Forms.Label();
            this.timerTurnMessage = new System.Windows.Forms.Timer(this.components);
            this.lblCpuScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.timerSpecialBox = new System.Windows.Forms.Timer(this.components);
            this.lblSpecialBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(971, 732);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mapContainer
            // 
            this.mapContainer.BackgroundImage = global::SnakesAndLadders.Properties.Resources.map;
            this.mapContainer.Image = global::SnakesAndLadders.Properties.Resources.map;
            this.mapContainer.Location = new System.Drawing.Point(12, 12);
            this.mapContainer.Name = "mapContainer";
            this.mapContainer.Size = new System.Drawing.Size(750, 750);
            this.mapContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapContainer.TabIndex = 2;
            this.mapContainer.TabStop = false;
            // 
            // timerPlayer
            // 
            this.timerPlayer.Tick += new System.EventHandler(this.timerPlayer_Tick);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerName.Location = new System.Drawing.Point(1006, 19);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 32);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(946, 3);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 54);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 5;
            this.picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.Transparent;
            this.picCPU.Image = global::SnakesAndLadders.Properties.Resources.piecePurple;
            this.picCPU.Location = new System.Drawing.Point(806, 3);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(64, 64);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCPU.TabIndex = 7;
            this.picCPU.TabStop = false;
            // 
            // lblCpuName
            // 
            this.lblCpuName.AutoSize = true;
            this.lblCpuName.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuName.ForeColor = System.Drawing.Color.Gold;
            this.lblCpuName.Location = new System.Drawing.Point(866, 19);
            this.lblCpuName.Name = "lblCpuName";
            this.lblCpuName.Size = new System.Drawing.Size(74, 32);
            this.lblCpuName.TabIndex = 6;
            this.lblCpuName.Text = "CPU";
            this.lblCpuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDie
            // 
            this.picDie.BackColor = System.Drawing.Color.Transparent;
            this.picDie.Image = global::SnakesAndLadders.Properties.Resources.dieRed_1;
            this.picDie.Location = new System.Drawing.Point(1116, 470);
            this.picDie.Name = "picDie";
            this.picDie.Size = new System.Drawing.Size(68, 68);
            this.picDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDie.TabIndex = 8;
            this.picDie.TabStop = false;
            // 
            // btnDice
            // 
            this.btnDice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice.Location = new System.Drawing.Point(971, 552);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(102, 57);
            this.btnDice.TabIndex = 1;
            this.btnDice.Text = "Roll dice!";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_ClickAsync);
            // 
            // timerDie
            // 
            this.timerDie.Interval = 10;
            this.timerDie.Tick += new System.EventHandler(this.timerDie_Tick);
            // 
            // lblTurnMessage
            // 
            this.lblTurnMessage.AutoSize = true;
            this.lblTurnMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnMessage.ForeColor = System.Drawing.Color.Gold;
            this.lblTurnMessage.Location = new System.Drawing.Point(785, 131);
            this.lblTurnMessage.Name = "lblTurnMessage";
            this.lblTurnMessage.Size = new System.Drawing.Size(0, 75);
            this.lblTurnMessage.TabIndex = 10;
            // 
            // timerTurnMessage
            // 
            this.timerTurnMessage.Tick += new System.EventHandler(this.timerTurnMessage_Tick);
            // 
            // lblCpuScore
            // 
            this.lblCpuScore.AutoSize = true;
            this.lblCpuScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuScore.ForeColor = System.Drawing.Color.White;
            this.lblCpuScore.Location = new System.Drawing.Point(847, 83);
            this.lblCpuScore.Name = "lblCpuScore";
            this.lblCpuScore.Size = new System.Drawing.Size(37, 39);
            this.lblCpuScore.TabIndex = 11;
            this.lblCpuScore.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(1025, 82);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(37, 39);
            this.lblPlayerScore.TabIndex = 12;
            this.lblPlayerScore.Text = "0";
            // 
            // timerSpecialBox
            // 
            this.timerSpecialBox.Interval = 50;
            this.timerSpecialBox.Tick += new System.EventHandler(this.timerSpecialBox_Tick);
            // 
            // lblSpecialBox
            // 
            this.lblSpecialBox.AutoSize = true;
            this.lblSpecialBox.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialBox.ForeColor = System.Drawing.Color.Gold;
            this.lblSpecialBox.Location = new System.Drawing.Point(793, 627);
            this.lblSpecialBox.Name = "lblSpecialBox";
            this.lblSpecialBox.Size = new System.Drawing.Size(454, 75);
            this.lblSpecialBox.TabIndex = 13;
            this.lblSpecialBox.Text = "Special box!!!";
            this.lblSpecialBox.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SnakesAndLadders.Properties.Resources.backPattern;
            this.ClientSize = new System.Drawing.Size(1264, 774);
            this.ControlBox = false;
            this.Controls.Add(this.lblSpecialBox);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblCpuScore);
            this.Controls.Add(this.lblTurnMessage);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.picDie);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.lblCpuName);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.mapContainer);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snakes and ladders - Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox mapContainer;
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label lblCpuName;
        private System.Windows.Forms.PictureBox picDie;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Timer timerDie;
        private System.Windows.Forms.Label lblTurnMessage;
        private System.Windows.Forms.Timer timerTurnMessage;
        private System.Windows.Forms.Label lblCpuScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Timer timerSpecialBox;
        private System.Windows.Forms.Label lblSpecialBox;
    }
}

