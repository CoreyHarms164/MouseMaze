using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore2 : Form
    {
        public Hardcore2()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private bool pad1Down = true;
        private bool pad2Down = true;
        private bool pad3Down = true;
        private bool pad4Down = true;
        private bool pad5Left = true;
        private Point p1 = new Point(207, 125);
        private Point p2 = new Point(268, 125);
        private Point p3 = new Point(331, 125);
        private Point p4 = new Point(398, 125);
        private Point p5 = new Point(554, 296);


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
            tmrPad1.Enabled = true;
            tmrPad2.Enabled = true;
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrPad1.Enabled = false;
            tmrPad2.Enabled = false;
            p1 = new Point(207, 125);
            p2 = new Point(268, 125);
            p3 = new Point(331, 125);
            p4 = new Point(398, 125);
            p5 = new Point(554, 296);
            pad1Down = true;
            pad2Down = true;
            pad3Down = true;
            pad4Down = true;
            pad5Left = true;
            lblPad1.Location = p1;
            lblPad2.Location = p2;
            lblPad3.Location = p3;
            lblPad4.Location = p4;
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
            var l3 = new Hardcore3();
            l3.Show();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void Pad1_Tick(object sender, EventArgs e)
        {
            if (pad1Down)
            {
                p1.Y += 3;
                if (p1.Y >= 150)
                {
                    pad1Down = false;
                }
            }
            else
            {
                p1.Y -= 3;
                if (p1.Y == 125)
                {
                   pad1Down = true;
                }
            }
            lblPad1.Location = p1;

            if (pad2Down)
            {
                p2.Y += 5;
                if (p2.Y == 150)
                {
                    pad2Down = false;
                }
            }
            else
            {
                p2.Y -= 5;
                if (p2.Y == 125)
                {
                    pad2Down = true;
                }
            }
            lblPad2.Location = p2;

            if (pad5Left)
            {
                p5.X -= 4;
                if (p5.X <= 484)
                {
                    pad5Left = false;
                }
            }
            else
            {
                p5.X += 3;
                if (p5.X >= 554)
                {
                    pad5Left = true;
                }
            }
            lblPad5.Location = p5;
        }

        private void Pad2_Tick(object sender, EventArgs e)
        {
            if (pad3Down)
            {
                p3.Y += 3;
                if (p3.Y >= 150)
                {
                    pad3Down = false;
                }
            }
            else
            {
                p3.Y -= 3;
                if (p3.Y == 125)
                {
                    pad3Down = true;
                }
            }
            lblPad3.Location = p3;

            if (pad4Down)
            {
                p4.Y += 5;
                if (p4.Y == 150)
                {
                    pad4Down = false;
                }
            }
            else
            {
                p4.Y -= 5;
                if (p4.Y == 125)
                {
                    pad4Down = true;
                }
            }
            lblPad4.Location = p4;
        }
    }
}
