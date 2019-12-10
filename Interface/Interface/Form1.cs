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


namespace Interface
{
    public partial class GameInterface : Form
    {
        public GameInterface()
        {
            InitializeComponent();
        }

        // Intergers used to keep track of how many games have been played.
        int candyCount = 0;
        int farkleCount = 0;

        // Used as start time for games is changed in button press.
        DateTime candyStartTime = DateTime.Now;
        TimeSpan candyOverallTime = TimeSpan.MinValue;
        DateTime farkleStartTime = DateTime.Now;
        TimeSpan farkleOverallTime = TimeSpan.MinValue;

        ///
        /// 
        Random rand = new Random();

        /// <summary>
        /// Highlight effect on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayFarkle_MouseHover(object sender, EventArgs e)
        {
            this.lblPlayFarkle.BackColor = Color.FromArgb(214, 199, 156);
            lblFarkleGamesPlayedCounter.ForeColor = Color.Blue;
            lblFarkleGamesPlayedText.ForeColor = Color.Blue;
            lblFarkleTimeCount.ForeColor = Color.Blue;
            lblFarkleTimeText.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayFarkle_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayFarkle.BackColor = Color.FromArgb(192, 255, 192);
            lblFarkleGamesPlayedCounter.ForeColor = Color.Black;
            lblFarkleGamesPlayedText.ForeColor = Color.Black;
            lblFarkleTimeCount.ForeColor = Color.Black;
            lblFarkleTimeText.ForeColor = Color.Black;
        }

        /// <summary>
        /// Highlight effect on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayCandyland_MouseHover(object sender, EventArgs e)
        {
            this.lblPlayCandyland.BackColor = Color.FromArgb(214, 199, 156);
            lblCandylandGamesPlayedCounter.ForeColor = Color.Blue;
            lblCandylandGamesPlayedText.ForeColor = Color.Blue;
            lblCandylandTimeCount.ForeColor = Color.Blue;
            lblCandylandTimeText.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayCandyland_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayCandyland.BackColor = Color.FromArgb(192, 255, 192);
            lblCandylandGamesPlayedCounter.ForeColor = Color.Black;
            lblCandylandGamesPlayedText.ForeColor = Color.Black;
            lblCandylandTimeCount.ForeColor = Color.Black;
            lblCandylandTimeText.ForeColor = Color.Black;
        }

        /// <summary>
        /// Since Tony hasnt been rick rolled in awhile, we need to help :)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlay1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=oHg5SJYRHA0");
        }

        private void lblPlayFarkle_Click(object sender, EventArgs e)
        {
            pbFarkle.Visible = Visible;
            while (pbFarkle.Value != 100)
            {
                int FarkleLoadProgressRate = rand.Next(300) + 1;
                pbFarkle.PerformStep();
                System.Threading.Thread.Sleep(FarkleLoadProgressRate);
            }

            if (pbFarkle.Value == 100)
            {
                farkleStartTime = DateTime.Now;
                //Game_CandyLand.CandyLandGame CandylandForm = new Game_CandyLand.CandyLandGame();
                //CandylandForm.Show();
                farkleCount++;
                lblFarkleGamesPlayedCounter.Text = farkleCount.ToString();
                Farkle.MainMenu FarkleMenu = new Farkle.MainMenu();
                FarkleMenu.ShowDialog();
                pbFarkle.Value = 0;
                pbFarkle.Visible = false;

                // Declare TimeSpan and DateTime.                    
                TimeSpan totalTimeFarkle;
                DateTime farkleEndTime = DateTime.Now;

                // If farkleOverallTime is at minvalue then run this.
                if (farkleOverallTime == TimeSpan.MinValue)
                {
                    // this part of the if statement should only run on the first time through.
                    // totalTime equals farkleEndTime subtract farkleStartTime.
                    totalTimeFarkle = (farkleEndTime - farkleStartTime);

                    // Change farkleOverallTime to totalTime, thus ensuring that the else statement will run from this point on.
                    farkleOverallTime = totalTimeFarkle;
                }
                else
                {
                    // totalTime equals farkleEndTime subtract farkleStartTime plus all the previous times added up. 
                    totalTimeFarkle = farkleOverallTime + (farkleEndTime - farkleStartTime);
                    farkleOverallTime = totalTimeFarkle;
                }
                // Display totalTime played in lblFarklelandTimeCount.
                lblFarkleTimeCount.Text = totalTimeFarkle.ToString(@"hh\:mm\:ss");
            }
        }

        private void lblPlayCandyland_Click(object sender, EventArgs e)
        {
            candyStartTime = DateTime.Now;
            pbCandyland.Visible = Visible;
            while (pbCandyland.Value != 100)
            {
                int CandylandLoadProgressRate = rand.Next(300) + 1;
                pbCandyland.PerformStep();
                System.Threading.Thread.Sleep(CandylandLoadProgressRate);
            }

            if(pbCandyland.Value == 100)
            {
                candyCount++;
                lblCandylandGamesPlayedCounter.Text = candyCount.ToString();
                Game_CandyLand.CandyLandGame CandylandForm = new Game_CandyLand.CandyLandGame();
                CandylandForm.ShowDialog();
                pbCandyland.Value = 0;
                pbCandyland.Visible = false;
                               
                // Declare TimeSpan and DateTime.                    
                TimeSpan totalTime;
                DateTime candyEndTime = DateTime.Now;

                // If candyOverallTime is at minvalue then run this.
                if (candyOverallTime == TimeSpan.MinValue)
                {
                    // this part of the if statement should only run on the first time through.
                    // totalTime equals candyEndTime subtract candyStartTime.
                    totalTime = (candyEndTime - candyStartTime);

                    // Change candyOverallTime to totalTime, thus ensuring that the else statement will run from this point on.
                    candyOverallTime = totalTime;
                }
                else
                {
                    // totalTime equals candyEndTime subtract candyStartTime plus all the previous times added up. 
                    totalTime = candyOverallTime + (candyEndTime - candyStartTime);
                    candyOverallTime = totalTime;
                }
                // Display totalTime played in lblCandylandTimeCount.
                lblCandylandTimeCount.Text = totalTime.ToString(@"hh\:mm\:ss");                
            }
        }
    }
}
