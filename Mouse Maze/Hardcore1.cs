using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore1 : Form
    {
        public Hardcore1()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private bool pad1Right = true;
        private bool pad2Up = true;
        private Point pad1 = new Point(253, 283);
        private Point pad2 = new Point(851, 283);
        

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
            tmrPads.Enabled = true;
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrPads.Enabled = false;
            pad1 = new Point(253, 283);
            pad2 = new Point(851, 283);
            lblPad1.Location = pad1;
            lblPad2.Location = pad2;
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
            var l2 = new Hardcore2();
            l2.Show();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void tmrPads_Tick(object sender, EventArgs e)
        {
            if (pad1Right)
            {
                pad1.X += 3;
                lblPad1.Location = pad1;
                if (pad1.X > 560)
                {
                    pad1Right = false;
                }
            }
            else
            {
                pad1.X -= 3;
                lblPad1.Location = pad1;
                if (pad1.X < 248)
                {
                    pad1Right = true;
                }
            }

            if (pad2Up)
            {
                pad2.Y -= 3;
                lblPad2.Location = pad2;
                if (pad2.Y < 78)
                {
                    pad2Up = false;
                }
            }
            else
            {
                pad2.Y += 3;
                lblPad2.Location = pad2;
                if (pad2.Y > 283)
                {
                    pad2Up = true;
                }
            }
        }
    }
}
