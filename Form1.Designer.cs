namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.pictureCloud4 = new System.Windows.Forms.PictureBox();
            this.pictureCloud3 = new System.Windows.Forms.PictureBox();
            this.pictureCloud2 = new System.Windows.Forms.PictureBox();
            this.pictureCloud1 = new System.Windows.Forms.PictureBox();
            this.pictureExitButton = new System.Windows.Forms.PictureBox();
            this.picturePlayButton = new System.Windows.Forms.PictureBox();
            this.pictureRetryButon = new System.Windows.Forms.PictureBox();
            this.picturePipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureGroundBottom = new System.Windows.Forms.PictureBox();
            this.picturePipeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRetryButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGroundBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Alternates Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(62, 614);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(158, 51);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "Score : ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBird
            // 
            this.pictureBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.pictureBird.Location = new System.Drawing.Point(120, 263);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(100, 63);
            this.pictureBird.TabIndex = 3;
            this.pictureBird.TabStop = false;
            // 
            // pictureCloud4
            // 
            this.pictureCloud4.Image = global::Flappy_Bird.Properties.Resources.cloud;
            this.pictureCloud4.Location = new System.Drawing.Point(85, 414);
            this.pictureCloud4.Name = "pictureCloud4";
            this.pictureCloud4.Size = new System.Drawing.Size(135, 63);
            this.pictureCloud4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloud4.TabIndex = 12;
            this.pictureCloud4.TabStop = false;
            // 
            // pictureCloud3
            // 
            this.pictureCloud3.Image = global::Flappy_Bird.Properties.Resources.cloud;
            this.pictureCloud3.Location = new System.Drawing.Point(648, 470);
            this.pictureCloud3.Name = "pictureCloud3";
            this.pictureCloud3.Size = new System.Drawing.Size(135, 63);
            this.pictureCloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloud3.TabIndex = 11;
            this.pictureCloud3.TabStop = false;
            // 
            // pictureCloud2
            // 
            this.pictureCloud2.Image = global::Flappy_Bird.Properties.Resources.cloud;
            this.pictureCloud2.Location = new System.Drawing.Point(327, 127);
            this.pictureCloud2.Name = "pictureCloud2";
            this.pictureCloud2.Size = new System.Drawing.Size(135, 63);
            this.pictureCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloud2.TabIndex = 10;
            this.pictureCloud2.TabStop = false;
            // 
            // pictureCloud1
            // 
            this.pictureCloud1.Image = global::Flappy_Bird.Properties.Resources.cloud;
            this.pictureCloud1.Location = new System.Drawing.Point(49, 12);
            this.pictureCloud1.Name = "pictureCloud1";
            this.pictureCloud1.Size = new System.Drawing.Size(135, 63);
            this.pictureCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloud1.TabIndex = 9;
            this.pictureCloud1.TabStop = false;
            // 
            // pictureExitButton
            // 
            this.pictureExitButton.Image = global::Flappy_Bird.Properties.Resources.no_button;
            this.pictureExitButton.Location = new System.Drawing.Point(468, 245);
            this.pictureExitButton.Name = "pictureExitButton";
            this.pictureExitButton.Size = new System.Drawing.Size(90, 90);
            this.pictureExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExitButton.TabIndex = 8;
            this.pictureExitButton.TabStop = false;
            this.pictureExitButton.Click += new System.EventHandler(this.pictureExitButton_Click);
            // 
            // picturePlayButton
            // 
            this.picturePlayButton.Image = global::Flappy_Bird.Properties.Resources.play_button;
            this.picturePlayButton.Location = new System.Drawing.Point(276, 245);
            this.picturePlayButton.Name = "picturePlayButton";
            this.picturePlayButton.Size = new System.Drawing.Size(90, 90);
            this.picturePlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayButton.TabIndex = 7;
            this.picturePlayButton.TabStop = false;
            this.picturePlayButton.Click += new System.EventHandler(this.picturePlayButtonOnClick);
            // 
            // pictureRetryButon
            // 
            this.pictureRetryButon.Image = global::Flappy_Bird.Properties.Resources.retry_button;
            this.pictureRetryButon.Location = new System.Drawing.Point(372, 245);
            this.pictureRetryButon.Name = "pictureRetryButon";
            this.pictureRetryButon.Size = new System.Drawing.Size(90, 90);
            this.pictureRetryButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRetryButon.TabIndex = 6;
            this.pictureRetryButon.TabStop = false;
            this.pictureRetryButon.Click += new System.EventHandler(this.pictureRetryButon_Click);
            // 
            // picturePipeBottom
            // 
            this.picturePipeBottom.Image = global::Flappy_Bird.Properties.Resources.Asset_1;
            this.picturePipeBottom.Location = new System.Drawing.Point(468, 510);
            this.picturePipeBottom.Name = "picturePipeBottom";
            this.picturePipeBottom.Size = new System.Drawing.Size(90, 82);
            this.picturePipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipeBottom.TabIndex = 2;
            this.picturePipeBottom.TabStop = false;
            // 
            // pictureGroundBottom
            // 
            this.pictureGroundBottom.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.pictureGroundBottom.Location = new System.Drawing.Point(-24, 598);
            this.pictureGroundBottom.Name = "pictureGroundBottom";
            this.pictureGroundBottom.Size = new System.Drawing.Size(841, 76);
            this.pictureGroundBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGroundBottom.TabIndex = 1;
            this.pictureGroundBottom.TabStop = false;
            // 
            // picturePipeTop
            // 
            this.picturePipeTop.Image = global::Flappy_Bird.Properties.Resources.Asset_1;
            this.picturePipeTop.Location = new System.Drawing.Point(528, 121);
            this.picturePipeTop.Name = "picturePipeTop";
            this.picturePipeTop.Size = new System.Drawing.Size(90, 85);
            this.picturePipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipeTop.TabIndex = 0;
            this.picturePipeTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(795, 665);
            this.Controls.Add(this.pictureBird);
            this.Controls.Add(this.pictureCloud4);
            this.Controls.Add(this.pictureCloud3);
            this.Controls.Add(this.pictureCloud2);
            this.Controls.Add(this.pictureCloud1);
            this.Controls.Add(this.pictureExitButton);
            this.Controls.Add(this.picturePlayButton);
            this.Controls.Add(this.pictureRetryButon);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePipeBottom);
            this.Controls.Add(this.pictureGroundBottom);
            this.Controls.Add(this.picturePipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRetryButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGroundBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePipeTop;
        private System.Windows.Forms.PictureBox pictureGroundBottom;
        private System.Windows.Forms.PictureBox picturePipeBottom;
        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureRetryButon;
        private System.Windows.Forms.PictureBox picturePlayButton;
        private System.Windows.Forms.PictureBox pictureExitButton;
        private System.Windows.Forms.PictureBox pictureCloud1;
        private System.Windows.Forms.PictureBox pictureCloud2;
        private System.Windows.Forms.PictureBox pictureCloud3;
        private System.Windows.Forms.PictureBox pictureCloud4;
    }
}

