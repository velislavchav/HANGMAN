namespace Hangman
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tbInsertChar = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblInputChar = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.lblAttemptsLeft = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pbHangMan = new System.Windows.Forms.PictureBox();
            this.pbAnswer = new System.Windows.Forms.PictureBox();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInsertChar
            // 
            this.tbInsertChar.BackColor = System.Drawing.Color.Honeydew;
            this.tbInsertChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInsertChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInsertChar.ForeColor = System.Drawing.Color.YellowGreen;
            this.tbInsertChar.Location = new System.Drawing.Point(432, 355);
            this.tbInsertChar.Margin = new System.Windows.Forms.Padding(4);
            this.tbInsertChar.MaxLength = 1;
            this.tbInsertChar.Name = "tbInsertChar";
            this.tbInsertChar.Size = new System.Drawing.Size(46, 57);
            this.tbInsertChar.TabIndex = 6;
            this.tbInsertChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInsertChar_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(521, 355);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 57);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check it";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblInputChar
            // 
            this.lblInputChar.AutoSize = true;
            this.lblInputChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInputChar.Location = new System.Drawing.Point(405, 308);
            this.lblInputChar.Name = "lblInputChar";
            this.lblInputChar.Size = new System.Drawing.Size(93, 60);
            this.lblInputChar.TabIndex = 9;
            this.lblInputChar.Text = "Input char\r\n    here\r\n\r\n";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblScore.Location = new System.Drawing.Point(14, 18);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 25);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score: ";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMissed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMissed.Location = new System.Drawing.Point(14, 233);
            this.lblMissed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(133, 29);
            this.lblMissed.TabIndex = 12;
            this.lblMissed.Text = "m i s s e d: ";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLength.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLength.Location = new System.Drawing.Point(14, 47);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(83, 25);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Length: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(861, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 57);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.lblAttemptsLeft);
            this.gbInformation.Controls.Add(this.lblScore);
            this.gbInformation.Controls.Add(this.lblLength);
            this.gbInformation.Controls.Add(this.lblMissed);
            this.gbInformation.Location = new System.Drawing.Point(382, 23);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(639, 276);
            this.gbInformation.TabIndex = 15;
            this.gbInformation.TabStop = false;
            // 
            // lblAttemptsLeft
            // 
            this.lblAttemptsLeft.AutoSize = true;
            this.lblAttemptsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttemptsLeft.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAttemptsLeft.Location = new System.Drawing.Point(463, 30);
            this.lblAttemptsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttemptsLeft.Name = "lblAttemptsLeft";
            this.lblAttemptsLeft.Size = new System.Drawing.Size(125, 25);
            this.lblAttemptsLeft.TabIndex = 13;
            this.lblAttemptsLeft.Text = "Attempts left:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pbHangMan
            // 
            this.pbHangMan.Location = new System.Drawing.Point(42, 35);
            this.pbHangMan.Name = "pbHangMan";
            this.pbHangMan.Size = new System.Drawing.Size(308, 377);
            this.pbHangMan.TabIndex = 8;
            this.pbHangMan.TabStop = false;
            // 
            // pbAnswer
            // 
            this.pbAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAnswer.Location = new System.Drawing.Point(671, 322);
            this.pbAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.pbAnswer.Name = "pbAnswer";
            this.pbAnswer.Size = new System.Drawing.Size(145, 121);
            this.pbAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer.TabIndex = 5;
            this.pbAnswer.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 466);
            this.Controls.Add(this.tbInsertChar);
            this.Controls.Add(this.lblInputChar);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbHangMan);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.pbAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Game_Load);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnswer;
        private System.Windows.Forms.TextBox tbInsertChar;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbHangMan;
        private System.Windows.Forms.Label lblInputChar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblAttemptsLeft;
    }
}