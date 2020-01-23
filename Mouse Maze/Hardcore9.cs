using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore9 : Form
    {
        public Hardcore9()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private int path = 1;
        private int delay = 1;
        private int[] horizontal = new int[8];
        private int[] vertical = new int[8];
        private List<Label> horizontalLabels = new List<Label>();
        private List<Label> verticalLabels = new List<Label>();
        private List<Point> hLocations = new List<Point>();
        private List<Point> vLocations = new List<Point>();
        private bool[] hRedoComplete = new bool[8];
        private bool[] vRedoComplete = new bool[8];
        

        private void Hardcore9_Load(object sender, EventArgs e)
        {
            Focus();

            horizontalLabels.Add(lblH0);
            horizontalLabels.Add(lblH1);
            horizontalLabels.Add(lblH2);
            horizontalLabels.Add(lblH3);
            horizontalLabels.Add(lblH4);
            horizontalLabels.Add(lblH5);
            horizontalLabels.Add(lblH6);
            horizontalLabels.Add(lblH7);
            verticalLabels.Add(lblV0);
            verticalLabels.Add(lblV1);
            verticalLabels.Add(lblV2);
            verticalLabels.Add(lblV3);
            verticalLabels.Add(lblV4);
            verticalLabels.Add(lblV5);
            verticalLabels.Add(lblV6);
            verticalLabels.Add(lblV7);

            for (var h = 0; h < 8; h++)
            {
                horizontal[h] = horizontalLabels[h].Width;
            }
            for (var v = 0; v < 8; v++)
            {
                vertical[v] = verticalLabels[v].Height;
            }
            for (var p = 0; p < 8; p++)
            {
                hLocations.Add(horizontalLabels[p].Location);
            }
            for (var q = 0; q < 8; q++)
            {
                vLocations.Add(verticalLabels[q].Location);
            }
        }

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
            if (tmrRedo.Enabled) return;
            start = true;
            btnStart.Visible = false;
            btnFinish.Visible = true;
            tmrTime.Enabled = true;
            tmrRun.Enabled = true;
            hRedoComplete = new bool[8];
            vRedoComplete = new bool[8];
        }

        private void Loose()
        {
            btnStart.Show();
            btnFinish.Hide();
            start = false;
            tmrTime.Enabled = false;
            tmrRun.Enabled = false;
            delay = 1;
            delay = 1;
            path = 1;
            mili = 0;
            sec = 0;
            tmrRedo.Enabled = true;
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
            var l10 = new Hardcore10();
            l10.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void Run_Tick(object sender, EventArgs e)
        {
            if (delay < 100)
            {
                delay++;
            }
            else
            {
                Point x;
                switch (path)
                {
                    case 1:
                        lblH0.Width -= 2;
                        if (lblH0.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 2:
                        lblV0.Height -= 2;
                        x = lblV0.Location;
                        x.Y += 2;
                        lblV0.Location = x;
                        if (lblV0.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 3:
                        lblH1.Width -= 3;
                        x = lblH1.Location;
                        x.X += 3;
                        lblH1.Location = x;
                        if (lblH1.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 4:
                        lblV1.Height -= 3;
                        if (lblV1.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 5:
                        lblH2.Width -= 4;
                        if (lblH2.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 6:
                        lblV2.Height -= 4;
                        x = lblV2.Location;
                        x.Y += 4;
                        lblV2.Location = x;
                        if (lblV2.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 7:
                        lblH3.Width -= 4;
                        if (lblH3.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 8:
                        lblV3.Height -= 4;
                        if (lblV3.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 9:
                        lblH4.Width -= 5;
                        x = lblH4.Location;
                        x.X += 5;
                        lblH4.Location = x;
                        if (lblH4.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 10:
                        lblV4.Height -= 5;
                        if (lblV4.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 11:
                        lblH5.Width -= 6;
                        if (lblH5.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 12:
                        lblV5.Height -= 6;
                        x = lblV5.Location;
                        x.Y += 6;
                        lblV5.Location = x;
                        if (lblV5.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 13:
                        lblH6.Width -= 6;
                        if (lblH6.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 14:
                        lblV6.Height -= 6;
                        if (lblV6.Height < 1)
                        {
                            path++;
                        }
                        break;
                    case 15:
                        lblH7.Width -= 6;
                        x = lblH7.Location;
                        x.X += 6;
                        lblH7.Location = x;
                        if (lblH7.Width < 1)
                        {
                            path++;
                        }
                        break;
                    case 16:
                        lblV7.Height -= 6;
                        x = lblV7.Location;
                        x.Y += 6;
                        lblV7.Location = x;
                        if (lblV7.Height < 1)
                        {
                            path++;
                        }
                        break;
                }
            }                     
        }

        private void Redo_Tick(object sender, EventArgs e)
        {
            Point point;
            for (var h = 0; h < 8; h++)
            {
                if (horizontalLabels[h].Width < horizontal[h])
                {
                    horizontalLabels[h].Width += 10;
                    if (horizontalLabels[h].Tag.ToString() == "r")
                    {
                        point = horizontalLabels[h].Location;
                        point.X -= 10;
                        horizontalLabels[h].Location = point;
                    }
                }
                else
                {
                    horizontalLabels[h].Width = horizontal[h];
                    horizontalLabels[h].Location = hLocations[h];
                    hRedoComplete[h] = true;
                }
            }

            for (var v = 0; v < 8; v++)
            {
                if (verticalLabels[v].Height < vertical[v])
                {
                    verticalLabels[v].Height += 10;
                    if (verticalLabels[v].Tag.ToString() == "r")
                    {
                        point = verticalLabels[v].Location;
                        point.Y -= 10;
                        verticalLabels[v].Location = point;
                    }
                }
                else
                {
                    verticalLabels[v].Height = vertical[v];
                    verticalLabels[v].Location = vLocations[v];
                    vRedoComplete[v] = true;
                }
            }
            if (hRedoComplete.All(x => x) && vRedoComplete.All(x => x))
            {
                tmrRedo.Enabled = false;
            }          
        }
    }
}
