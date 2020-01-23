using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class LevelSelect : Form
    {
        public LevelSelect()
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

        private void lblLvl_Click(object sender, EventArgs e)
        {
            Hide();
            var label = new Label();
            label = (Label) sender;
            if (!Data.GetHardcoreSelected())
            {
                switch (label.Tag.ToString())
                {
                    case "1":
                        var l1 = new Level1();
                        l1.Show();
                        break;
                    case "2":
                        var l2 = new Level2();
                        l2.Show();
                        break;
                    case "3":
                        var l3 = new Level3();
                        l3.Show();
                        break;
                    case "4":
                        var l4 = new Level4();
                        l4.Show();
                        break;
                    case "5":
                        var l5 = new Level5();
                        l5.Show();
                        break;
                    case "6":
                        var l6 = new Level6();
                        l6.Show();
                        break;
                    case "7":
                        var l7 = new Level7();
                        l7.Show();
                        break;
                    case "8":
                        var l8 = new Level8();
                        l8.Show();
                        break;
                    case "9":
                        var l9 = new Level9();
                        l9.Show();
                        break;
                    case "10":
                        var l10 = new Level10();
                        l10.Show();
                        break;
                }
            }
            else
            {
                switch (label.Tag.ToString())
                {
                    case "1":
                        var l1 = new Hardcore1();
                        l1.Show();
                        break;
                    case "2":
                        var l2 = new Hardcore2();
                        l2.Show();
                        break;
                    case "3":
                        var l3 = new Hardcore3();
                        l3.Show();
                        break;
                    case "4":
                        var l4 = new Hardcore4();
                        l4.Show();
                        break;
                    case "5":
                        var l5 = new Hardcore5();
                        l5.Show();
                        break;
                    case "6":
                        var l6 = new Hardcore6();
                        l6.Show();
                        break;
                    case "7":
                        var l7 = new Hardcore7();
                        l7.Show();
                        break;
                    case "8":
                        var l8 = new Hardcore8();
                        l8.Show();
                        break;
                    case "9":
                        var l9 = new Hardcore9();
                        l9.Show();
                        break;
                    case "10":
                        var l10 = new Hardcore10();
                        l10.Show();
                        break;
                }
            }
        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {
            ShowLevels();

            if (Data.GetHardcore())
            {
                lblHardcore.Visible = true;
            }       
            SelectCore();
        }

        private void ShowLevels()
        {
            if (!Data.GetHardcoreSelected())
            {
                for (var i = 1; i <= 10; i++)
                {
                    if (Data.GetComplete(i))
                    {
                        Activate(i);
                    }
                }
            }
            else
            {
                for (var i = 11; i <= 20; i++)
                {
                    if (Data.GetComplete(i))
                    {
                        Activate(i - 10);
                    }
                }
            }
        }

        private void Activate(int i)
        {
            switch (i)
            {
                case 1:
                    lbl2.Visible = true;
                    break;
                case 2:
                    lbl3.Visible = true;
                    break;
                case 3:
                    lbl4.Visible = true;
                    break;
                case 4:
                    lbl5.Visible = true;
                    break;
                case 5:
                    lbl6.Visible = true;
                    break;
                case 6:
                    lbl7.Visible = true;
                    break;
                case 7:
                    lbl8.Visible = true;
                    break;
                case 8:
                    lbl9.Visible = true;
                    break;
                case 9:
                    lbl10.Visible = true;
                    break;  
            }
        }

        private void SelectCore()
        {
            if (Data.GetHardcoreSelected())
            {
                lblHardcore.Text = "Normal Mode";
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
                lblHardcore.Text = "Hardcore Mode";
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        c.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void lblHardcore_Click(object sender, EventArgs e)
        {
            ClearLevels();
            Data.SetHardcoreSelected();
            SelectCore();
            ShowLevels();
        }

        private void ClearLevels()
        {
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
        }
    }
}
