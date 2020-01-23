using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore7 : Form
    {
        public Hardcore7()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private Point left = new Point(411, 283);
        private Point right = new Point(459, 283);
        private bool goingRight;


        private void lbl_Click(object sender, MouseEventArgs e)
        {
            if (start)
            {
                MessageBox.Show(@"Don't click the mouse button!");
                Loose();
            }
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
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrPad.Enabled = false;
            left = new Point(411, 283);
            right = new Point(459, 283);
            lblLeft.Location = left;
            lblRight.Location = right;
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Win();
        }

        private void Win()
        {
            double recordTime = Convert.ToInt32(Data.GetTime((Convert.ToInt16(this.Tag))));
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
            Hide();

            //Level Specific Code
            var l8 = new Hardcore8();
            l8.Show();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }


        private void Pad_Tick(object sender, EventArgs e)
        {
            if (goingRight)
            {
                right.X += 2;
                left.X += 2;
            }
            else
            {
                right.X -= 2;
                left.X -= 2;
            }
            lblRight.Location = right;
            lblLeft.Location = left;
        }

        private void Pad_Enter(object sender, EventArgs e)
        {
            if (!start) return;
            if (!tmrPad.Enabled)
            {
                tmrPad.Enabled = true;
            }
            var x = (Label)sender;
            switch (x.Tag.ToString())
            {
                case "Right":
                    goingRight = true;
                    break;
                case "Left":
                    goingRight = false;
                    break;
            }
        }

        private void Trigger_Enter(object sender, EventArgs e)
        {
            tmrPad.Enabled = false;
        }
    }
}
