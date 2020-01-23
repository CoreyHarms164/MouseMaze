using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Level10 : Form
    {
        public Level10()
        {
            InitializeComponent();
        }

        //Code to be used in all Levels
        private bool start;
        private int mili;
        private int sec;
        private string credits = "Thank you for playing Mouse Maze!\r\n  Complete all levels under the par time to unlock the Hardcore levels!";
        private int typeCount = 0;
        private bool goingRight = true;
        private Point loc = new Point(46, 234);
        private void lbl_Click(object sender, MouseEventArgs e)
        {
            if (!start) return;
            MessageBox.Show(@"Don't click the mouse button!");
            Loose();
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            if (start)
            {
                Loose();
            }
        }

        private void lbl_Enter(object sender, EventArgs e)
        {
            var clicked = sender as Label;
            clicked.Font = new Font(clicked.Font.FontFamily, 22, FontStyle.Bold);
        }

        private void lbl_Leave(object sender, EventArgs e)
        {
            var clicked = sender as Label;
            clicked.Font = new Font(clicked.Font.FontFamily, 18, FontStyle.Regular);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            var ls = new LevelSelect();
            Hide();
            ls.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;
            btnStart.Visible = false;
            btnFinish.Visible = true;
            tmrTime.Enabled = true;
            tmrPad.Enabled = true;
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrPad.Enabled = false;
            loc.X = 46;
            loc.Y = 234;
            lblPad.Location = loc;
            mili = 0;
            sec = 0;
            MessageBox.Show(@"You Loose!");
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            mili++;
            if (mili == 100)
            {
                mili = 0;
                sec++;
            }
            lblMili.Text = mili.ToString();
            lblSec.Text = sec.ToString();
        }

        private void Pad_Tick(object sender, EventArgs e)
        {
            if (goingRight)
            {
                loc.X += 5;
                lblPad.Location = loc;
                if (loc.X > 424)
                {
                    goingRight = false;
                }
            }
            else
            {
                loc.X -= 5;
                lblPad.Location = loc;
                if (loc.X < 51)
                {
                    goingRight = true;
                }
            }          
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Win();
        }

        private void Win()
        {
            double recordTime = Convert.ToInt32(Data.GetTime(Convert.ToInt16(this.Tag)));
            string time;
            if (mili < 10)
            {
                time = sec.ToString() + "0" + mili.ToString();
            }
            else
            {
                time = sec.ToString() + mili.ToString();
            }

            tmrTime.Enabled = false;
            if (Convert.ToInt16(time) < recordTime || !Data.GetComplete((Convert.ToInt16(this.Tag))))
            {
                Data.UpdateTime((Convert.ToInt16(this.Tag)), time);
            }
            Data.LevelComplete((Convert.ToInt16(this.Tag)));
            start = false;
            MessageBox.Show(@"You Win!");
            
            //Level Specific Code:
            ShowCredits();
        }

        private void ShowCredits()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    if (c.Tag.ToString() == "remove")
                    {
                            c.Visible = false;
                    }
                }
                catch (NullReferenceException e)
                {

                }
            }
            lblCredits.Visible = true;
            tmrTyper.Enabled = true;
        }

        private void tmrTyper_Tick(object sender, EventArgs e)
        {
            lblCredits.Text += credits[typeCount].ToString();
            typeCount += 1;
            if (typeCount == credits.Length)
            {
                tmrTyper.Enabled = false;
            }
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }
    }
}
