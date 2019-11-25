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
            lblFarkleGamesPlayedCounter.ForeColor = Color.GhostWhite;
            lblFarkleGamesPlayedText.ForeColor = Color.GhostWhite;
            lblFarkleTimeCount.ForeColor = Color.GhostWhite;
            lblFarkleTimeText.ForeColor = Color.GhostWhite;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayFarkle_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayFarkle.BackColor = Color.FromArgb(21, 32, 48);
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
            lblCandylandGamesPlayedCounter.ForeColor = Color.GhostWhite;
            lblCandylandGamesPlayedText.ForeColor = Color.GhostWhite;
            lblCandylandTimeCount.ForeColor = Color.GhostWhite;
            lblCandylandTimeText.ForeColor = Color.GhostWhite;
        }

        /// <summary>
        /// Set back to normal color on mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayCandyland_MouseLeave(object sender, EventArgs e)
        {
            this.lblPlayCandyland.BackColor = GameInterface.ActiveForm.BackColor;
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
            while(pbFarkle.Value != 100)
            {
                int FarkleLoadProgressRate = rand.Next(300) + 1;
                pbFarkle.PerformStep();
                System.Threading.Thread.Sleep(FarkleLoadProgressRate);
            }

            if (pbFarkle.Value == 100)
            {
                //Game_CandyLand.CandyLandGame CandylandForm = new Game_CandyLand.CandyLandGame();
                //CandylandForm.Show();
                Farkle.MainMenu FarkleMenu = new Farkle.MainMenu();
                FarkleMenu.Show();
                pbFarkle.Value = 0;
                pbFarkle.Visible = false;
            }
        }

        private void lblPlayCandyland_Click(object sender, EventArgs e)
        {
            pbCandyland.Visible = Visible;
            while (pbCandyland.Value != 100)
            {
                int CandylandLoadProgressRate = rand.Next(300) + 1;
                pbCandyland.PerformStep();
                System.Threading.Thread.Sleep(CandylandLoadProgressRate);
            }

            if(pbCandyland.Value == 100)
            {
                Game_CandyLand.CandyLandGame CandylandForm = new Game_CandyLand.CandyLandGame();
                CandylandForm.Show();
                pbCandyland.Value = 0;
                pbCandyland.Visible = false;
            }
        }
    }
}
