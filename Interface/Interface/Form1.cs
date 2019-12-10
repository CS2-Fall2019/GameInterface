//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Interface
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// GameInterface is used to access farkle and candyland as well as keep track of
    /// times played and overall play time.
    /// </summary>
    public partial class GameInterface : Form
    {
        /// <summary>
        /// Counter variable for candyland games
        /// </summary>
        private int candyCount = 0;

        /// <summary>
        /// Counter variable for farkle games.
        /// </summary>
        private int farkleCount = 0;

        /// <summary>
        /// Candyland start time.
        /// </summary>
        private DateTime candyStartTime = DateTime.Now;

        /// <summary>
        /// Candyland overall time.
        /// </summary>
        private TimeSpan candyOverallTime = TimeSpan.MinValue;

        /// <summary>
        /// Farkle start time.
        /// </summary>
        private DateTime farkleStartTime = DateTime.Now;

        /// <summary>
        /// Farkle overall time.
        /// </summary>
        private TimeSpan farkleOverallTime = TimeSpan.MinValue;

        /// <summary>
        /// Random number generator.
        /// </summary>
        private Random rand = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameInterface" /> class.
        /// </summary>
        public GameInterface()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the candyland counter.
        /// </summary>
        public int CandyCount
        {
            get => this.candyCount;
            set => this.candyCount = value;
        }

        /// <summary>
        /// Gets or sets the farkle counter.
        /// </summary>
        public int FarkleCount
        {
            get => this.farkleCount;
            set => this.farkleCount = value;
        }

        /// <summary>
        /// Gets or sets candyland start time.
        /// </summary>
        public DateTime CandyStartTime
        {
            get => this.candyStartTime;
            set => this.candyStartTime = value;
        }

        /// <summary>
        /// Gets or sets the candyland overall time.
        /// </summary>
        public TimeSpan CandyOverallTime
        {
            get => this.candyOverallTime;
            set => this.candyOverallTime = value;
        }

        /// <summary>
        /// Gets or sets the farkle start time.
        /// </summary>
        public DateTime FarkleStartTime
        {
            get => this.farkleStartTime;
            set => this.farkleStartTime = value;
        }

        /// <summary>
        /// Gets or sets the farkle overall time.
        /// </summary>
        public TimeSpan FarkleOverallTime
        {
            get => this.farkleOverallTime;
            set => this.farkleOverallTime = value;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayFarkle_MouseHover(object sender, EventArgs e)
        {
            this.lblPlayFarkle.BackColor = Color.FromArgb(214, 199, 156);
            this.lblFarkleGamesPlayedCounter.ForeColor = Color.Blue;
            this.lblFarkleGamesPlayedText.ForeColor = Color.Blue;
            this.lblFarkleTimeCount.ForeColor = Color.Blue;
            this.lblFarkleTimeText.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayFarkle_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayFarkle.BackColor = Color.FromArgb(192, 255, 192);
            this.lblFarkleGamesPlayedCounter.ForeColor = Color.Black;
            this.lblFarkleGamesPlayedText.ForeColor = Color.Black;
            this.lblFarkleTimeCount.ForeColor = Color.Black;
            this.lblFarkleTimeText.ForeColor = Color.Black;
        }

        /// <summary>
        /// Highlight effect on hover
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayCandyland_MouseHover(object sender, EventArgs e)
        {
            this.lblPlayCandyland.BackColor = Color.FromArgb(214, 199, 156);
            this.lblCandylandGamesPlayedCounter.ForeColor = Color.Blue;
            this.lblCandylandGamesPlayedText.ForeColor = Color.Blue;
            this.lblCandylandTimeCount.ForeColor = Color.Blue;
            this.lblCandylandTimeText.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayCandyland_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayCandyland.BackColor = Color.FromArgb(192, 255, 192);
            this.lblCandylandGamesPlayedCounter.ForeColor = Color.Black;
            this.lblCandylandGamesPlayedText.ForeColor = Color.Black;
            this.lblCandylandTimeCount.ForeColor = Color.Black;
            this.lblCandylandTimeText.ForeColor = Color.Black;
        }

        /// <summary>
        /// Since Tony hasnt been rick rolled in awhile, we need to help :)
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlay1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=oHg5SJYRHA0");
        }

        /// <summary>
        /// Click event for farkle label.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayFarkle_Click(object sender, EventArgs e)
        {
            this.farkleStartTime = DateTime.Now;
            this.pbFarkle.Visible = this.Visible;
            while (this.pbFarkle.Value != 100)
            {
                int farkleLoadProgressRate = this.rand.Next(300) + 1;
                this.pbFarkle.PerformStep();
                System.Threading.Thread.Sleep(farkleLoadProgressRate);
            }

            if (this.pbFarkle.Value == 100)
            {
                // Game_CandyLand.CandyLandGame candylandForm = new Game_CandyLand.CandyLandGame();
                // candylandForm.Show();
                this.farkleCount++;
                this.lblFarkleGamesPlayedCounter.Text = this.farkleCount.ToString();
                Farkle.MainMenu farkleMenu = new Farkle.MainMenu();
                farkleMenu.ShowDialog();
                this.pbFarkle.Value = 0;
                this.pbFarkle.Visible = false;

                // Declare TimeSpan and DateTime.                    
                TimeSpan totalTimeFarkle;
                DateTime farkleEndTime = DateTime.Now;

                // If farkleOverallTime is at minvalue then run this.
                if (this.farkleOverallTime == TimeSpan.MinValue)
                {
                    // this part of the if statement should only run on the first time through.
                    // totalTime equals farkleEndTime subtract farkleStartTime.
                    totalTimeFarkle = farkleEndTime - this.farkleStartTime;

                    // Change farkleOverallTime to totalTime, thus ensuring that the else statement will run from this point on.
                    this.farkleOverallTime = totalTimeFarkle;
                }
                else
                {
                    // totalTime equals farkleEndTime subtract farkleStartTime plus all the previous times added up. 
                    totalTimeFarkle = this.farkleOverallTime + (farkleEndTime - this.farkleStartTime);
                    this.farkleOverallTime = totalTimeFarkle;
                }

                // Display totalTime played in lblFarklelandTimeCount.
                this.lblFarkleTimeCount.Text = totalTimeFarkle.ToString(@"hh\:mm\:ss");
            }
        }

        /// <summary>
        /// Click event for candyland label.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void LblPlayCandyland_Click(object sender, EventArgs e)
        {
            this.candyStartTime = DateTime.Now;
            this.pbCandyland.Visible = this.Visible;
            while (this.pbCandyland.Value != 100)
            {
                int candylandLoadProgressRate = this.rand.Next(300) + 1;
                this.pbCandyland.PerformStep();
                System.Threading.Thread.Sleep(candylandLoadProgressRate);
            }

            if (this.pbCandyland.Value == 100)
            {
                this.candyCount++;
                this.lblCandylandGamesPlayedCounter.Text = this.candyCount.ToString();
                Game_CandyLand.CandyLandGame candylandForm = new Game_CandyLand.CandyLandGame();
                candylandForm.ShowDialog();
                this.pbCandyland.Value = 0;
                this.pbCandyland.Visible = false;
                               
                // Declare TimeSpan and DateTime.                    
                TimeSpan totalTime;
                DateTime candyEndTime = DateTime.Now;

                // If candyOverallTime is at minvalue then run this.
                if (this.candyOverallTime == TimeSpan.MinValue)
                {
                    // this part of the if statement should only run on the first time through.
                    // totalTime equals candyEndTime subtract candyStartTime.
                    totalTime = candyEndTime - this.candyStartTime;

                    // Change candyOverallTime to totalTime, thus ensuring that the else statement will run from this point on.
                    this.candyOverallTime = totalTime;
                }
                else
                {
                    // totalTime equals candyEndTime subtract this.candyStartTime plus all the previous times added up. 
                    totalTime = this.candyOverallTime + (candyEndTime - this.candyStartTime);
                    this.candyOverallTime = totalTime;
                }

                // Display totalTime played in lblCandylandTimeCount.
                this.lblCandylandTimeCount.Text = totalTime.ToString(@"hh\:mm\:ss");                
            }
        }        
    }
}
