using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
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
            Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            SelectCore();
            if (!Data.GetHardcoreSelected())
            {
                for (var i = 1; i <= 10; i++)
                {
                    lblScores.Text += "Level: " + i + ":    ";
                    if (Data.GetComplete(i))
                    {
                        lblScores.Text += "Complete!" + "   ";
                    }
                    if (Data.GetComplete(i))
                    {
                        lblScores.Text += " Time:   ";
                        string s = Data.GetTime(i).Insert(Data.GetTime(i).Length - 2, ":");
                        lblScores.Text += s + "   ";
                        lblScores.Text += "Par Time:   ";
                        s = Data.GetParTimes(i).Insert(Data.GetParTimes(i).Length - 2, ":");
                        lblScores.Text += s;
                    }
                    lblScores.Text += "\r\n";
                }
            }
            else
            {
                for (var i = 11; i <= 20; i++)
                {
                    lblScores.Text += "Level: " + i + ":    ";
                    if (Data.GetComplete(i) == true)
                    {
                        lblScores.Text += "Complete!" + "   ";
                    }
                    if (Data.GetComplete(i))
                    {
                        lblScores.Text += " Time:   ";
                        string s = Data.GetTime(i).Insert(Data.GetTime(i).Length - 2, ":");
                        lblScores.Text += s;
                    }
                    lblScores.Text += "\r\n";
                }
            }                      
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

        private void label1_Click(object sender, EventArgs e)
        {
            lblScores.Visible = false;
            lblPrompt.Visible = true;
            lblYes.Visible = true;
            lblNo.Visible = true;    
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var label = (Label) sender;
            switch (label.Text)
            {
                case "Yes":
                    Data.Reset();
                    lblYes.Visible = false;
                    lblNo.Visible = false;
                    lblOk.Visible = true;
                    lblPrompt.Text = "Scores reset.";
                    break;
                case "No":
                    lblScores.Visible = true;
                    lblPrompt.Visible = false;
                    lblYes.Visible = false;
                    lblNo.Visible = false;
                    break;
                case "Ok":
                    Hide();
                    var menu = new Menu();
                    menu.Show();
                    break;
            }
        }
    }
}
