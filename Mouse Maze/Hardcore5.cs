using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore5 : Form
    {
        public Hardcore5()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private bool[] Traps = new bool[9];
        private Random rand = new Random();


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
            for (var i = 0; i <= rand.Next(3, 5); i++)
            {
                var x = rand.Next(0, 9);
                if (Traps[x])
                {
                    i--;
                }
                else
                {
                    Traps[x] = true;
                }
            }
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrTrap0.Enabled = false;
            tmrTrap1.Enabled = false;
            tmrTrap2.Enabled = false;
            tmrTrap3.Enabled = false;
            tmrTrap4.Enabled = false;
            tmrTrap5.Enabled = false;
            tmrTrap6.Enabled = false;
            tmrTrap7.Enabled = false;
            tmrTrap8.Enabled = false;
            lblTrap0.Visible = false;
            lblTrap1.Visible = false;
            lblTrap2.Visible = false;
            lblTrap3.Visible = false;
            lblTrap4.Visible = false;
            lblTrap5.Visible = false;
            lblTrap6.Visible = false;
            lblTrap7.Visible = false;
            lblTrap8.Visible = false;
            mili = 0;
            sec = 0;
            MessageBox.Show(@"You Loose!");
            for (var i = 0; i < 9; i++)
            {
                Traps[i] = false;
            }
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
            var l6 = new Hardcore6();
            l6.Show();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Focus();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }


        private void Trap_Enter(object sender, EventArgs e)
        {
            if (!start) return;
            var x = (Label)sender;
            if (Traps[Convert.ToInt16(x.Tag)])
            {
                switch (Convert.ToInt16(x.Tag))
                {
                    case 0:
                        lblTrap0.Visible = true;
                        tmrTrap0.Enabled = true;
                        break;
                    case 1:
                        lblTrap1.Visible = true;
                        tmrTrap1.Enabled = true;
                        break;
                    case 2:
                        lblTrap2.Visible = true;
                        tmrTrap2.Enabled = true;
                        break;
                    case 3:
                        lblTrap3.Visible = true;
                        tmrTrap3.Enabled = true;
                        break;
                    case 4:
                        lblTrap4.Visible = true;
                        tmrTrap4.Enabled = true;
                        break;
                    case 5:
                        lblTrap5.Visible = true;
                        tmrTrap5.Enabled = true;
                        break;
                    case 6:
                        lblTrap6.Visible = true;
                        tmrTrap6.Enabled = true;
                        break;
                    case 7:
                        lblTrap7.Visible = true;
                        tmrTrap7.Enabled = true;
                        break;
                    case 8:
                        lblTrap8.Visible = true;
                        tmrTrap8.Enabled = true;
                        break;
                }
            }
        }

        private void Trap0_Tick(object sender, EventArgs e)
        {
            lblTrap0.Visible = !lblTrap0.Visible;
        }

        private void Trap1_Tick(object sender, EventArgs e)
        {
            lblTrap1.Visible = !lblTrap1.Visible;
        }
        private void Trap2_Tick(object sender, EventArgs e)
        {
            lblTrap2.Visible = !lblTrap2.Visible;
        }
        private void Trap3_Tick(object sender, EventArgs e)
        {
            lblTrap3.Visible = !lblTrap3.Visible;
        }
        private void Trap4_Tick(object sender, EventArgs e)
        {
            lblTrap4.Visible = !lblTrap4.Visible;
        }
        private void Trap5_Tick(object sender, EventArgs e)
        {
            lblTrap5.Visible = !lblTrap5.Visible;
        }
        private void Trap6_Tick(object sender, EventArgs e)
        {
            lblTrap6.Visible = !lblTrap6.Visible;
        }
        private void Trap7_Tick(object sender, EventArgs e)
        {
            lblTrap7.Visible = !lblTrap7.Visible;
        }
        private void Trap8_Tick(object sender, EventArgs e)
        {
            lblTrap8.Visible = !lblTrap8.Visible;
        }
    }
}
