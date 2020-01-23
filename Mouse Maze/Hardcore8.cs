using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore8 : Form
    {
        public Hardcore8()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private Point up = new Point(406, 274);
        private Point down = new Point(406, 324);
        private Point left = new Point(406, 299);
        private Point right = new Point(454, 299);
        private int direction = 1;


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
            up = new Point(406, 274);
            down = new Point(406, 324);
            left = new Point(406, 299);
            right = new Point(454, 299);
            lblUp.Location = up;
            lblDown.Location = down;
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
            MessageBox.Show("You Win!");
            Hide();

            //Level Specific Code
            var l9 = new Hardcore9();
            l9.Show();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void Pad_Enter(object sender, EventArgs e)
        {
            var x = (Label) sender;
            switch (x.Tag.ToString())
            {
                case "Up":
                    direction = 1;
                    break;
                case "Down":
                    direction = 2;
                    break;
                case "Left":
                    direction = 3;
                    break;
                case "Right":
                    direction = 4;
                    break;
            }
        }

        private void Pad_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case 1:
                    up.Y -= 2;
                    down.Y -= 2;
                    left.Y -= 2;
                    right.Y -= 2;
                    break;
                case 2:
                    up.Y += 2;
                    down.Y += 2;
                    left.Y += 2;
                    right.Y += 2;
                    break;
                case 3:
                    up.X -= 2;
                    down.X -= 2;
                    left.X -= 2;
                    right.X -= 2;
                    break;
                case 4:
                    up.X += 2;
                    down.X += 2;
                    left.X += 2;
                    right.X += 2;
                    break;
            }
            lblUp.Location = up;
            lblDown.Location = down;
            lblLeft.Location = left;
            lblRight.Location = right;
        }
    }
}