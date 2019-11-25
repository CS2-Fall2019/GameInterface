namespace Interface
{
    partial class GameInterface
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
            this.lblPlayFarkle = new System.Windows.Forms.Label();
            this.lblPlayCandyland = new System.Windows.Forms.Label();
            this.lblFarkleGamesPlayedText = new System.Windows.Forms.Label();
            this.lblFarkleGamesPlayedCounter = new System.Windows.Forms.Label();
            this.lblCandylandGamesPlayedCounter = new System.Windows.Forms.Label();
            this.lblCandylandGamesPlayedText = new System.Windows.Forms.Label();
            this.lblFarkleTimeCount = new System.Windows.Forms.Label();
            this.lblFarkleTimeText = new System.Windows.Forms.Label();
            this.lblCandylandTimeCount = new System.Windows.Forms.Label();
            this.lblCandylandTimeText = new System.Windows.Forms.Label();
            this.lblPlay1 = new System.Windows.Forms.Label();
            this.pbFarkle = new System.Windows.Forms.ProgressBar();
            this.pbCandyland = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblPlayFarkle
            // 
            this.lblPlayFarkle.AutoSize = true;
            this.lblPlayFarkle.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayFarkle.Location = new System.Drawing.Point(52, 37);
            this.lblPlayFarkle.Name = "lblPlayFarkle";
            this.lblPlayFarkle.Size = new System.Drawing.Size(136, 49);
            this.lblPlayFarkle.TabIndex = 0;
            this.lblPlayFarkle.Text = "Play Farkle";
            this.lblPlayFarkle.Click += new System.EventHandler(this.lblPlayFarkle_Click);
            this.lblPlayFarkle.MouseLeave += new System.EventHandler(this.lblPlayFarkle_MouseLeave);
            this.lblPlayFarkle.MouseHover += new System.EventHandler(this.lblPlayFarkle_MouseHover);
            // 
            // lblPlayCandyland
            // 
            this.lblPlayCandyland.AutoSize = true;
            this.lblPlayCandyland.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayCandyland.Location = new System.Drawing.Point(294, 37);
            this.lblPlayCandyland.Name = "lblPlayCandyland";
            this.lblPlayCandyland.Size = new System.Drawing.Size(192, 49);
            this.lblPlayCandyland.TabIndex = 1;
            this.lblPlayCandyland.Text = "Play CandyLand";
            this.lblPlayCandyland.Click += new System.EventHandler(this.lblPlayCandyland_Click);
            this.lblPlayCandyland.MouseLeave += new System.EventHandler(this.lblPlayCandyland_MouseLeave);
            this.lblPlayCandyland.MouseHover += new System.EventHandler(this.lblPlayCandyland_MouseHover);
            // 
            // lblFarkleGamesPlayedText
            // 
            this.lblFarkleGamesPlayedText.AutoSize = true;
            this.lblFarkleGamesPlayedText.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarkleGamesPlayedText.Location = new System.Drawing.Point(38, 109);
            this.lblFarkleGamesPlayedText.Name = "lblFarkleGamesPlayedText";
            this.lblFarkleGamesPlayedText.Size = new System.Drawing.Size(98, 28);
            this.lblFarkleGamesPlayedText.TabIndex = 2;
            this.lblFarkleGamesPlayedText.Text = "Games Played:";
            // 
            // lblFarkleGamesPlayedCounter
            // 
            this.lblFarkleGamesPlayedCounter.AutoSize = true;
            this.lblFarkleGamesPlayedCounter.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarkleGamesPlayedCounter.Location = new System.Drawing.Point(180, 109);
            this.lblFarkleGamesPlayedCounter.Name = "lblFarkleGamesPlayedCounter";
            this.lblFarkleGamesPlayedCounter.Size = new System.Drawing.Size(19, 28);
            this.lblFarkleGamesPlayedCounter.TabIndex = 3;
            this.lblFarkleGamesPlayedCounter.Text = "0";
            // 
            // lblCandylandGamesPlayedCounter
            // 
            this.lblCandylandGamesPlayedCounter.AutoSize = true;
            this.lblCandylandGamesPlayedCounter.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandylandGamesPlayedCounter.Location = new System.Drawing.Point(451, 109);
            this.lblCandylandGamesPlayedCounter.Name = "lblCandylandGamesPlayedCounter";
            this.lblCandylandGamesPlayedCounter.Size = new System.Drawing.Size(19, 28);
            this.lblCandylandGamesPlayedCounter.TabIndex = 5;
            this.lblCandylandGamesPlayedCounter.Text = "0";
            // 
            // lblCandylandGamesPlayedText
            // 
            this.lblCandylandGamesPlayedText.AutoSize = true;
            this.lblCandylandGamesPlayedText.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandylandGamesPlayedText.Location = new System.Drawing.Point(309, 109);
            this.lblCandylandGamesPlayedText.Name = "lblCandylandGamesPlayedText";
            this.lblCandylandGamesPlayedText.Size = new System.Drawing.Size(98, 28);
            this.lblCandylandGamesPlayedText.TabIndex = 4;
            this.lblCandylandGamesPlayedText.Text = "Games Played:";
            // 
            // lblFarkleTimeCount
            // 
            this.lblFarkleTimeCount.AutoSize = true;
            this.lblFarkleTimeCount.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarkleTimeCount.Location = new System.Drawing.Point(180, 155);
            this.lblFarkleTimeCount.Name = "lblFarkleTimeCount";
            this.lblFarkleTimeCount.Size = new System.Drawing.Size(19, 28);
            this.lblFarkleTimeCount.TabIndex = 7;
            this.lblFarkleTimeCount.Text = "0";
            // 
            // lblFarkleTimeText
            // 
            this.lblFarkleTimeText.AutoSize = true;
            this.lblFarkleTimeText.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarkleTimeText.Location = new System.Drawing.Point(38, 155);
            this.lblFarkleTimeText.Name = "lblFarkleTimeText";
            this.lblFarkleTimeText.Size = new System.Drawing.Size(122, 28);
            this.lblFarkleTimeText.TabIndex = 6;
            this.lblFarkleTimeText.Text = "Total Time Played:";
            // 
            // lblCandylandTimeCount
            // 
            this.lblCandylandTimeCount.AutoSize = true;
            this.lblCandylandTimeCount.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandylandTimeCount.Location = new System.Drawing.Point(451, 155);
            this.lblCandylandTimeCount.Name = "lblCandylandTimeCount";
            this.lblCandylandTimeCount.Size = new System.Drawing.Size(19, 28);
            this.lblCandylandTimeCount.TabIndex = 9;
            this.lblCandylandTimeCount.Text = "0";
            // 
            // lblCandylandTimeText
            // 
            this.lblCandylandTimeText.AutoSize = true;
            this.lblCandylandTimeText.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandylandTimeText.Location = new System.Drawing.Point(309, 155);
            this.lblCandylandTimeText.Name = "lblCandylandTimeText";
            this.lblCandylandTimeText.Size = new System.Drawing.Size(122, 28);
            this.lblCandylandTimeText.TabIndex = 8;
            this.lblCandylandTimeText.Text = "Total Time Played:";
            // 
            // lblPlay1
            // 
            this.lblPlay1.AutoSize = true;
            this.lblPlay1.Location = new System.Drawing.Point(242, 233);
            this.lblPlay1.Name = "lblPlay1";
            this.lblPlay1.Size = new System.Drawing.Size(30, 13);
            this.lblPlay1.TabIndex = 10;
            this.lblPlay1.Text = "Play!";
            this.lblPlay1.Click += new System.EventHandler(this.lblPlay1_Click);
            // 
            // pbFarkle
            // 
            this.pbFarkle.Location = new System.Drawing.Point(62, 210);
            this.pbFarkle.Name = "pbFarkle";
            this.pbFarkle.Size = new System.Drawing.Size(115, 23);
            this.pbFarkle.TabIndex = 11;
            this.pbFarkle.Visible = false;
            // 
            // pbCandyland
            // 
            this.pbCandyland.Location = new System.Drawing.Point(332, 210);
            this.pbCandyland.Name = "pbCandyland";
            this.pbCandyland.Size = new System.Drawing.Size(115, 23);
            this.pbCandyland.TabIndex = 12;
            this.pbCandyland.Visible = false;
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.pbCandyland);
            this.Controls.Add(this.pbFarkle);
            this.Controls.Add(this.lblPlay1);
            this.Controls.Add(this.lblCandylandTimeCount);
            this.Controls.Add(this.lblCandylandTimeText);
            this.Controls.Add(this.lblFarkleTimeCount);
            this.Controls.Add(this.lblFarkleTimeText);
            this.Controls.Add(this.lblCandylandGamesPlayedCounter);
            this.Controls.Add(this.lblCandylandGamesPlayedText);
            this.Controls.Add(this.lblFarkleGamesPlayedCounter);
            this.Controls.Add(this.lblFarkleGamesPlayedText);
            this.Controls.Add(this.lblPlayCandyland);
            this.Controls.Add(this.lblPlayFarkle);
            this.Name = "GameInterface";
            this.Text = "Game interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayFarkle;
        private System.Windows.Forms.Label lblPlayCandyland;
        private System.Windows.Forms.Label lblFarkleGamesPlayedText;
        private System.Windows.Forms.Label lblFarkleGamesPlayedCounter;
        private System.Windows.Forms.Label lblCandylandGamesPlayedCounter;
        private System.Windows.Forms.Label lblCandylandGamesPlayedText;
        private System.Windows.Forms.Label lblFarkleTimeCount;
        private System.Windows.Forms.Label lblFarkleTimeText;
        private System.Windows.Forms.Label lblCandylandTimeCount;
        private System.Windows.Forms.Label lblCandylandTimeText;
        private System.Windows.Forms.Label lblPlay1;
        private System.Windows.Forms.ProgressBar pbFarkle;
        private System.Windows.Forms.ProgressBar pbCandyland;
    }
}

