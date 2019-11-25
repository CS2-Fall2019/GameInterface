﻿//-----------------------------------------------------------------------
// <copyright file="PlayerBoard.Designer.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    /// <summary>
    /// The PlayerBoard class (designer).
    /// </summary>
    public partial class PlayerBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// The Game Board picture box.
        /// </summary>
        private System.Windows.Forms.PictureBox pbxGameBoard;

        /// <summary>
        /// The Draw button.
        /// </summary>
        private System.Windows.Forms.Button btnDraw;

        /// <summary>
        /// The Output Log label.
        /// </summary>
        private System.Windows.Forms.Label lblOutputLog;

        /// <summary>
        /// The Exit button.
        /// </summary>
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        /// The Label 1 label.
        /// </summary>
        private System.Windows.Forms.Label lblLabel1;

        /// <summary>
        /// The Label 2 label.
        /// </summary>
        private System.Windows.Forms.Label lblLabel2;

        /// <summary>
        /// The Label 3 label.
        /// </summary>
        private System.Windows.Forms.Label lblLabel3;

        /// <summary>
        /// The label 4 label.
        /// </summary>
        private System.Windows.Forms.Label lblLabel4;

        /// <summary>
        /// The image list.
        /// </summary>
        private System.Windows.Forms.ImageList imgListCards;

        /// <summary>
        /// The display for picture box.
        /// </summary>
        private System.Windows.Forms.PictureBox pbxCardDisplay;

        /// <summary>
        /// The next player button.
        /// </summary>
        private System.Windows.Forms.Button btnNextPlayer;

        /// <summary>
        /// The round label.
        /// </summary>
        private System.Windows.Forms.Label lblRound;

        /// <summary>
        /// The messages label.
        /// </summary>
        private System.Windows.Forms.Label lblMessages;

        /// <summary>
        /// The messages label.
        /// </summary>
        private System.Windows.Forms.Label lblPlayerTurn;

        /// <summary>
        /// The messages label.
        /// </summary>
        private System.Windows.Forms.Button BtnInstructions;

        #region Windows Form Designer generated code

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerBoard));
            this.pbxGameBoard = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblOutputLog = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.lblLabel3 = new System.Windows.Forms.Label();
            this.lblLabel4 = new System.Windows.Forms.Label();
            this.imgListCards = new System.Windows.Forms.ImageList(this.components);
            this.pbxCardDisplay = new System.Windows.Forms.PictureBox();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.BtnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGameBoard
            // 
            this.pbxGameBoard.Image = ((System.Drawing.Image)(resources.GetObject("pbxGameBoard.Image")));
            this.pbxGameBoard.Location = new System.Drawing.Point(10, 9);
            this.pbxGameBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGameBoard.MaximumSize = new System.Drawing.Size(1211, 882);
            this.pbxGameBoard.MinimumSize = new System.Drawing.Size(1211, 882);
            this.pbxGameBoard.Name = "pbxGameBoard";
            this.pbxGameBoard.Size = new System.Drawing.Size(1211, 882);
            this.pbxGameBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxGameBoard.TabIndex = 0;
            this.pbxGameBoard.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDraw.Enabled = false;
            this.btnDraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDraw.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.HotPink;
            this.btnDraw.Location = new System.Drawing.Point(1258, 69);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(134, 153);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw Card";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // lblOutputLog
            // 
            this.lblOutputLog.AutoSize = true;
            this.lblOutputLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLog.ForeColor = System.Drawing.Color.Magenta;
            this.lblOutputLog.Location = new System.Drawing.Point(1208, 705);
            this.lblOutputLog.Name = "lblOutputLog";
            this.lblOutputLog.Size = new System.Drawing.Size(170, 18);
            this.lblOutputLog.TabIndex = 3;
            this.lblOutputLog.Text = "Welcome to CandyLand!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.HotPink;
            this.btnExit.Location = new System.Drawing.Point(1258, 226);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblLabel1
            // 
            this.lblLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel1.ForeColor = System.Drawing.Color.White;
            this.lblLabel1.Image = ((System.Drawing.Image)(resources.GetObject("lblLabel1.Image")));
            this.lblLabel1.Location = new System.Drawing.Point(218, 822);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.Size = new System.Drawing.Size(44, 47);
            this.lblLabel1.TabIndex = 5;
            this.lblLabel1.Text = "Player1";
            this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabel2
            // 
            this.lblLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel2.ForeColor = System.Drawing.Color.White;
            this.lblLabel2.Image = ((System.Drawing.Image)(resources.GetObject("lblLabel2.Image")));
            this.lblLabel2.Location = new System.Drawing.Point(142, 725);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.Size = new System.Drawing.Size(44, 47);
            this.lblLabel2.TabIndex = 6;
            this.lblLabel2.Text = "Player2";
            this.lblLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabel3
            // 
            this.lblLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel3.ForeColor = System.Drawing.Color.White;
            this.lblLabel3.Image = ((System.Drawing.Image)(resources.GetObject("lblLabel3.Image")));
            this.lblLabel3.Location = new System.Drawing.Point(54, 803);
            this.lblLabel3.Name = "lblLabel3";
            this.lblLabel3.Size = new System.Drawing.Size(44, 47);
            this.lblLabel3.TabIndex = 7;
            this.lblLabel3.Text = "Player3";
            this.lblLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabel4
            // 
            this.lblLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel4.ForeColor = System.Drawing.Color.White;
            this.lblLabel4.Image = ((System.Drawing.Image)(resources.GetObject("lblLabel4.Image")));
            this.lblLabel4.Location = new System.Drawing.Point(142, 803);
            this.lblLabel4.Name = "lblLabel4";
            this.lblLabel4.Size = new System.Drawing.Size(44, 47);
            this.lblLabel4.TabIndex = 8;
            this.lblLabel4.Text = "Player4";
            this.lblLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgListCards
            // 
            this.imgListCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCards.ImageStream")));
            this.imgListCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCards.Images.SetKeyName(0, "Green.png");
            this.imgListCards.Images.SetKeyName(1, "Double Green.png");
            this.imgListCards.Images.SetKeyName(2, "Red.png");
            this.imgListCards.Images.SetKeyName(3, "Double Red.png");
            this.imgListCards.Images.SetKeyName(4, "Orange.png");
            this.imgListCards.Images.SetKeyName(5, "Double Orange.png");
            this.imgListCards.Images.SetKeyName(6, "Blue.png");
            this.imgListCards.Images.SetKeyName(7, "Double Blue.png");
            this.imgListCards.Images.SetKeyName(8, "Purple.jpeg");
            this.imgListCards.Images.SetKeyName(9, "Double Purple.jpeg");
            this.imgListCards.Images.SetKeyName(10, "Yellow.png");
            this.imgListCards.Images.SetKeyName(11, "Double Yellow.png");
            this.imgListCards.Images.SetKeyName(12, "Peppermint.png");
            this.imgListCards.Images.SetKeyName(13, "Peanut.png");
            this.imgListCards.Images.SetKeyName(14, "Lollipop.png");
            this.imgListCards.Images.SetKeyName(15, "Ice Cream.png");
            this.imgListCards.Images.SetKeyName(16, "Gum Drop.png");
            this.imgListCards.Images.SetKeyName(17, "GingerBreadMan.png");
            // 
            // pbxCardDisplay
            // 
            this.pbxCardDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCardDisplay.Location = new System.Drawing.Point(1276, 513);
            this.pbxCardDisplay.Name = "pbxCardDisplay";
            this.pbxCardDisplay.Size = new System.Drawing.Size(100, 50);
            this.pbxCardDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCardDisplay.TabIndex = 9;
            this.pbxCardDisplay.TabStop = false;
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPlayer.ForeColor = System.Drawing.Color.HotPink;
            this.btnNextPlayer.Location = new System.Drawing.Point(1258, 282);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(134, 51);
            this.btnNextPlayer.TabIndex = 10;
            this.btnNextPlayer.Text = "Go to Next Players Turn";
            this.btnNextPlayer.UseVisualStyleBackColor = false;
            this.btnNextPlayer.Click += new System.EventHandler(this.BtnNextPlayer_Click);
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.Lime;
            this.lblRound.Location = new System.Drawing.Point(1246, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(146, 58);
            this.lblRound.TabIndex = 11;
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.ForeColor = System.Drawing.Color.Magenta;
            this.lblMessages.Location = new System.Drawing.Point(1208, 740);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 18);
            this.lblMessages.TabIndex = 12;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.Magenta;
            this.lblPlayerTurn.Location = new System.Drawing.Point(1217, 376);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(209, 24);
            this.lblPlayerTurn.TabIndex = 13;
            this.lblPlayerTurn.Text = "It is Player Ones turn.";
            // 
            // BtnInstructions
            // 
            this.BtnInstructions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstructions.ForeColor = System.Drawing.Color.HotPink;
            this.BtnInstructions.Location = new System.Drawing.Point(1258, 339);
            this.BtnInstructions.Name = "BtnInstructions";
            this.BtnInstructions.Size = new System.Drawing.Size(134, 23);
            this.BtnInstructions.TabIndex = 14;
            this.BtnInstructions.Text = "Instructions";
            this.BtnInstructions.UseVisualStyleBackColor = false;
            this.BtnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1560, 943);
            this.Controls.Add(this.BtnInstructions);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.pbxCardDisplay);
            this.Controls.Add(this.lblLabel4);
            this.Controls.Add(this.lblLabel3);
            this.Controls.Add(this.lblLabel2);
            this.Controls.Add(this.lblLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutputLog);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.pbxGameBoard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(910, 570);
            this.Name = "PlayerBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyLand";
            this.Load += new System.EventHandler(this.PlayerBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}