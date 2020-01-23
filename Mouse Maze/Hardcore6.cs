using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore6 : Form
    {
        public Hardcore6()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private bool padToFinish;
        private int padStage = 1;
        private Point pad = new Point(500, 67);

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
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrPad.Enabled = false;
            pad.X = 500;
            pad.Y = 67;
            lblPad.Location = pad;
            padStage = 1;
            lblTop.Visible = false;
            lblLeft.Visible = false;
            lblMiddle.Visible = true;
            lblRight.Visible = false;
            lblBottom.Visible = false;
            lblBottomRight.Visible = true;
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
            var l7 = new Hardcore7();
            l7.Show();
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
            if (padToFinish)
            {
                switch (padStage)
                {
                    case 1:
                        pad.X += 2;
                        if (pad.X == 850)
                        {
                            padStage++;
                        }
                        break;
                    case 2:
                        pad.Y -= 2;
                        if (pad.Y == 67)
                        {
                            padStage++;
                        }
                        break;
                    case 3:
                        pad.X -= 2;
                        if (pad.X == 500)
                        {
                            padToFinish = false;
                            padStage = 1;
                        }
                        break;
                }
                lblPad.Location = pad;
            }
            else
            {
                switch (padStage)
                {
                    case 1:
                        pad.X += 2;
                        if (pad.X == 850)
                        {
                            padStage++;
                        }
                        break;
                    case 2:
                        pad.Y += 2;
                        if (pad.Y == 545)
                        {
                            padStage++;
                        }
                        break;
                    case 3:
                        pad.X -= 2;
                        if (pad.X == 500)
                        {
                            padToFinish = true;
                            padStage = 1;
                        }
                        break;
                }
                lblPad.Location = pad;
            }
        }

        private void Trigger_Enter(object sender, EventArgs e)
        {
            if (start)
            {
                
                var x = (Label)sender;
                switch (x.Tag.ToString())
                {
                    case "1":
                        lblMiddle.Visible = false;
                        lblRight.Visible = true;
                        lblLeft.Visible = true;
                        break;
                    case "2":
                        lblLeft.Visible = false;
                        lblTop.Visible = true;
                        lblMiddle.Visible = true;
                        lblBottom.Visible = true;
                        lblBack.Visible = true;
                        lblBottomRight.Visible = false;
                        tmrPad.Enabled = true;
                        break;
                }
            }           
        } 
    }
}
