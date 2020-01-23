using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore4 : Form
    {
        public Hardcore4()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private Point pad1 = new Point(413, 61);
        private Point pad2 = new Point(173, 301);
        
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
            tmrPad1.Enabled = true;
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
            tmrPad1.Enabled = false;
            tmrPad2.Enabled = false;
            pad1 = new Point(413, 61);
            pad2 = new Point(173, 301);
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
            MessageBox.Show("You Win!");
            Hide();

            //Level Specific Code
            var l5 = new Hardcore5();
            l5.Show();

        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void tmrPad1_Tick(object sender, EventArgs e)
        {
            pad1.X += 2;
            pad1.Y += 2;
            lblPad1.Location = pad1;
            if (lblPad1.Location == lblStop1.Location)
            {
                tmrPad1.Enabled = false;
            }
        }

        private void tmrPad2_Tick(object sender, EventArgs e)
        {
            pad2.X += 2;
            pad2.Y += 2;
            lblPad2.Location = pad2;
            if (lblPad2.Location == lblStop2.Location)
            {
                tmrPad2.Enabled = false;
            }
        }

        private void PadEnter(object sender, EventArgs e)
        {
            if (start)
            {
                tmrPad2.Enabled = true;
            }
        }
    }
}
