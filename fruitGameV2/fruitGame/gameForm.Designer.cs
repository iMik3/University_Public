namespace fruitGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgSlot1 = new System.Windows.Forms.PictureBox();
            this.imgSlot2 = new System.Windows.Forms.PictureBox();
            this.imgSlot3 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::fruitGame.Properties.Resources.Slots;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::fruitGame.Properties.Resources.Spin;
            this.btnStart.Location = new System.Drawing.Point(345, 420);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spin";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgSlot1
            // 
            this.imgSlot1.BackColor = System.Drawing.Color.White;
            this.imgSlot1.Image = global::fruitGame.Properties.Resources._6;
            this.imgSlot1.InitialImage = null;
            this.imgSlot1.Location = new System.Drawing.Point(118, 142);
            this.imgSlot1.Name = "imgSlot1";
            this.imgSlot1.Size = new System.Drawing.Size(100, 85);
            this.imgSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlot1.TabIndex = 2;
            this.imgSlot1.TabStop = false;
            // 
            // imgSlot2
            // 
            this.imgSlot2.BackColor = System.Drawing.Color.White;
            this.imgSlot2.Image = global::fruitGame.Properties.Resources._6;
            this.imgSlot2.InitialImage = null;
            this.imgSlot2.Location = new System.Drawing.Point(368, 142);
            this.imgSlot2.Name = "imgSlot2";
            this.imgSlot2.Size = new System.Drawing.Size(100, 85);
            this.imgSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlot2.TabIndex = 3;
            this.imgSlot2.TabStop = false;
            // 
            // imgSlot3
            // 
            this.imgSlot3.BackColor = System.Drawing.Color.White;
            this.imgSlot3.Image = global::fruitGame.Properties.Resources._6;
            this.imgSlot3.InitialImage = null;
            this.imgSlot3.Location = new System.Drawing.Point(615, 142);
            this.imgSlot3.Name = "imgSlot3";
            this.imgSlot3.Size = new System.Drawing.Size(100, 85);
            this.imgSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlot3.TabIndex = 4;
            this.imgSlot3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::fruitGame.Properties.Resources.Spin_Clicked;
            this.btnExit.Location = new System.Drawing.Point(379, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore.ForeColor = System.Drawing.Color.Red;
            this.lblTextScore.Location = new System.Drawing.Point(638, 380);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(96, 33);
            this.lblTextScore.TabIndex = 7;
            this.lblTextScore.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Orange;
            this.lblScore.Location = new System.Drawing.Point(585, 420);
            this.lblScore.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(200, 57);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Image = global::fruitGame.Properties.Resources.cashout;
            this.btnCash.Location = new System.Drawing.Point(103, 420);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(133, 51);
            this.btnCash.TabIndex = 9;
            this.btnCash.Text = "Cash out";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fruitGame.Properties.Resources.bo_play_pattern;
            this.ClientSize = new System.Drawing.Size(836, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imgSlot3);
            this.Controls.Add(this.imgSlot2);
            this.Controls.Add(this.imgSlot1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgSlot1;
        private System.Windows.Forms.PictureBox imgSlot2;
        private System.Windows.Forms.PictureBox imgSlot3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCash;
    }
}

