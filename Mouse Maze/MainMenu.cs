using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Hide();
            var ls = new LevelSelect();
            ls.Show();
        }

        private void lblScores_Click(object sender, EventArgs e)
        {
            Hide();
            var s = new Scores();
            s.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Data.WriteData();
            Application.Exit();
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

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!Data.GetIsLoaded())
            {
                Data.Load_Data();
            }
            SelectCore();
        }

        private void SelectCore()
        {
            if (Data.GetHardcoreSelected())
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        c.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        c.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            lblInformation.Visible = true;
            lblBack.Visible = true;
            lblStart.Visible = false;
            lblScores.Visible = false;
            lblInfo.Visible = false;
            lblExit.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblInformation.Visible = false;
            lblBack.Visible = false;
            lblStart.Visible = true;
            lblScores.Visible = true;
            lblInfo.Visible = true;
            lblExit.Visible = true;
        }
    }
}
