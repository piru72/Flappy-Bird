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
            this.pictureRetryButon = new System.Windows.Forms.PictureBox();
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.picturePipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureGroundBottom = new System.Windows.Forms.PictureBox();
            this.picturePipeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRetryButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
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
            this.labelScore.Location = new System.Drawing.Point(240, 614);
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
            // pictureRetryButon
            // 
            this.pictureRetryButon.Image = global::Flappy_Bird.Properties.Resources.retry_button;
            this.pictureRetryButon.Location = new System.Drawing.Point(336, 245);
            this.pictureRetryButon.Name = "pictureRetryButon";
            this.pictureRetryButon.Size = new System.Drawing.Size(88, 85);
            this.pictureRetryButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRetryButon.TabIndex = 6;
            this.pictureRetryButon.TabStop = false;
            // 
            // pictureBird
            // 
            this.pictureBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.pictureBird.Location = new System.Drawing.Point(146, 267);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(100, 63);
            this.pictureBird.TabIndex = 3;
            this.pictureBird.TabStop = false;
            // 
            // picturePipeBottom
            // 
            this.picturePipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.picturePipeBottom.Location = new System.Drawing.Point(445, 440);
            this.picturePipeBottom.Name = "picturePipeBottom";
            this.picturePipeBottom.Size = new System.Drawing.Size(100, 176);
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
            this.picturePipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.picturePipeTop.Location = new System.Drawing.Point(518, -13);
            this.picturePipeTop.Name = "picturePipeTop";
            this.picturePipeTop.Size = new System.Drawing.Size(100, 203);
            this.picturePipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipeTop.TabIndex = 0;
            this.picturePipeTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(795, 690);
            this.Controls.Add(this.pictureRetryButon);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBird);
            this.Controls.Add(this.picturePipeBottom);
            this.Controls.Add(this.pictureGroundBottom);
            this.Controls.Add(this.picturePipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRetryButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
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
    }
}

