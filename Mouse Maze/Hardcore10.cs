using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Maze
{
    public partial class Hardcore10 : Form
    {
        public Hardcore10()
        {
            InitializeComponent();
        }

        private bool start;
        private int mili;
        private int sec;
        private Point BossLocation = new Point(416, -98);
        private int delay;
        private int bossStage;
        private Random attackX = new Random();
        private Random attackY = new Random();
        private Point bulletsStart = new Point(148, 67);
        private readonly Point obsticle1Start = new Point(488, 136);
        private readonly Point obsticle2Start = new Point(252, 136);
        private readonly Point obsticle3Start = new Point(704, 136);
        private Size obsticleSize = new Size(12, 15);
        private Size obsticle2Size = new Size(18, 15);
        private int woundedCounter;
        private bool woundAlt = true;
        private bool woundComplete;
        private int setStage = 1;
        private bool moveObsticle3;


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
            var x = new LevelSelect();
            Hide();
            x.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = true;
            btnStart.Visible = false;
            tmrTime.Enabled = true;
            tmrBossEnter.Enabled = true;
            BossLocation = new Point(416, -98);
            picBoss.Location = BossLocation;
            picBoss.Visible = true;

        }

        private void Loose()
        {
            btnStart.Show();
            start = false;
            //Timers
            tmrTime.Enabled = false;
            tmrBoss.Enabled = false;
            tmrBossEnter.Enabled = false;
            Delay.Enabled = false;
            tmrAttack.Enabled = false;
            tmrBullets.Enabled = false;
            tmrWound.Enabled = false;
            tmrStageMove.Enabled = false;
            woundComplete = false;
            tmrSet3.Enabled = false;
            tmrSet4.Enabled = false;
            //Bullets
            lblBullet1.Location = bulletsStart;
            lblBullet2.Location = bulletsStart;
            lblBullet3.Location = bulletsStart;
            lblBullet4.Location = bulletsStart;
            lblBullet1.Visible = false;
            lblBullet2.Visible = false;
            lblBullet3.Visible = false;
            lblBullet4.Visible = false;
            //Variables
            bossStage = 0;
            woundedCounter = 0;
            mili = 0;
            sec = 0;
            delay = 0;
            setStage = 1;
            moveObsticle3 = false;
            lblObstacle1.Visible = false;
            lblObsticle2.Visible = false;
            lblObsticle3.Visible = false;
            lblObstacle1.Location = obsticle1Start;
            lblObsticle2.Location = obsticle2Start;
            lblObsticle3.Location = obsticle3Start;
            lblObstacle1.Size = obsticleSize;
            lblObsticle2.Size = obsticle2Size;
            lblObsticle3.Size = obsticle2Size;
            btnAttack.Visible = false;
            BossHealth.Visible = false;
            BossHealth.Value = 0;
            MessageBox.Show("You Loose!");
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

        private void Win()
        {
            start = false;
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

            lblCredits1.Visible = true;
            lblCredits2.Visible = true;
            tmrCredits.Enabled = true;
        }

        private void BossEnter_Tick(object sender, EventArgs e)
        {
            BossLocation.Y += 2;
            picBoss.Location = BossLocation;
            if (BossLocation.Y == 56)
            {
                BossHealth.Visible = true;
                BossHealth.Value = BossHealth.Maximum;
                tmrBossEnter.Enabled = false;
                Delay.Enabled = true;
            }
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            delay++;
            if (delay == 3)
            {
                Delay.Enabled = false;
                NextBossStage();
            }
        }

        private void Boss_Tick(object sender, EventArgs e)
        {
            var mousePos = MousePosition.X;
            BossLocation = picBoss.Location;
            mousePos -=  39;
            mousePos -= Location.X;
            switch (bossStage)
            {
                case 1:
                    if(BossLocation.X + 2 < mousePos && BossLocation.X < mousePos)
                    {
                        BossLocation.X += 5;
                    }
                    else if(BossLocation.X > mousePos && BossLocation.X - 2 > mousePos)
                    {
                        BossLocation.X -= 5;
                    }
                    break;
                case 2:
                    if (BossLocation.X < mousePos && BossLocation.X + 3 < mousePos)
                    {
                        BossLocation.X += 7;
                    }
                    else if (BossLocation.X > mousePos && BossLocation.X - 3 > mousePos)
                    {
                        BossLocation.X -= 7;
                    }
                    break;
                default:
                    if (BossLocation.X < mousePos && BossLocation.X + 5 < mousePos)
                    {
                        BossLocation.X += 10;
                    }
                    else if (BossLocation.X > mousePos && BossLocation.X - 5 > mousePos)
                    {
                        BossLocation.X -= 10;
                    }
                    break;
            }
            picBoss.Location = BossLocation;
        }

        private void Bullets_Tick(object sender, EventArgs e)
        {
            Point bullet;
            switch (bossStage)
            {
                case 1:
                    bullet = lblBullet1.Location;
                    if (bullet.Y > 622)
                    {
                        bullet = picBoss.Location;
                        bullet.X += 37;
                        lblBullet1.Location = bullet;
                    }
                    bullet.Y += 5;
                    lblBullet1.Location = bullet;
                    break;
                case 2:
                    bullet = lblBullet2.Location;
                    if (bullet.Y > 622)
                    {
                        bullet = picBoss.Location;
                        bullet.X += 33;
                        lblBullet2.Location = bullet;
                    }
                    bullet.Y += 7;
                    lblBullet2.Location = bullet;
                    break;
                case 3:
                    bullet = lblBullet3.Location;
                    if (bullet.Y > 622)
                    {
                        bullet = picBoss.Location;
                        bullet.X += 33;
                        lblBullet3.Location = bullet;
                    }
                    bullet.Y += 10;
                    lblBullet3.Location = bullet;
                    break;
                case 4:
                    bullet = lblBullet4.Location;
                    if (bullet.Y > 622)
                    {
                        bullet = picBoss.Location;
                        bullet.X += 33;
                        lblBullet4.Location = bullet;
                    }
                    bullet.Y += 10;
                    lblBullet4.Location = bullet;
                    break;
            }
        }

        private void Attack_Tick(object sender, EventArgs e)
        {
            var attack = new Point();
            if (!btnAttack.Visible)
            {
                attack.X = attackX.Next(46, 843);
                attack.Y = attackY.Next(160, 555);
                btnAttack.Location = attack;
                btnAttack.Visible = true;
            }
            else
            {
                btnAttack.Visible = false;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Visible = false;
            BossHealth.Value -= 20;
            if (BossHealth.Value == 0)
            {
                tmrWound.Enabled = true;
            }
        }

        private void NextBossStage()
        {
            var bullet = picBoss.Location;
            switch (bossStage)
            {
                case 0:
                    bossStage++;
                    bullet.X += 37;
                    lblBullet1.Location = bullet;
                    lblBullet1.Visible = true;
                    break;
                case 1:
                    bossStage++;
                    bullet.X += 33;
                    lblBullet2.Location = bullet;
                    lblBullet2.Visible = true;
                    BossHealth.Value = 100;
                    break;
                case 2:
                    bossStage++;
                    setStage++;
                    bullet.X += 31;
                    lblBullet3.Location = bullet;
                    lblBullet3.Visible = true;
                    BossHealth.Value = 100;
                    break;
                case 3:
                    bossStage++;
                    setStage++;
                    bullet.X += 28;
                    lblBullet4.Location = bullet;
                    lblBullet4.Visible = true;
                    BossHealth.Value = 100;
                    break;
            }
            tmrBoss.Enabled = true;
            tmrBullets.Enabled = true;
            tmrAttack.Enabled = true;
        }

        private void Wound_Tick(object sender, EventArgs e)
        {
            Point boss;
            lblBullet1.Visible = false;
            lblBullet2.Visible = false;
            lblBullet3.Visible = false;
            lblBullet4.Visible = false;
            tmrBoss.Enabled = false;
            tmrBullets.Enabled = false;
            tmrAttack.Enabled = false;
            if (woundedCounter < 100)
            {
                boss = picBoss.Location;
                if (woundAlt)
                {
                    woundAlt = false;
                    boss.X += 3;
                }
                else
                {
                    woundAlt = true;
                    boss.X -= 3;
                }
                picBoss.Location = boss;
                woundedCounter++;
            }
            else if(woundedCounter == 100)
            {
                woundedCounter++;
                switch (bossStage)
                {
                    case 1:
                        woundComplete = true;
                        break;
                    case 2:
                        tmrStageMove.Enabled = true;
                        break;
                    case 3:
                        lblObstacle1.Visible = false;
                        tmrStageMove.Enabled = true;
                        break;
                    case 4:
                        picDefeat.Location = picBoss.Location;
                        picBoss.Visible = false;
                        picDefeat.Visible = true;
                        Win();
                        break;
                }
            }
            
            if (woundComplete)
            {
                woundedCounter = 0;
                woundComplete = false;
                tmrWound.Enabled = false;
                NextBossStage();
            }
        }

        private void StageMove_Tick(object sender, EventArgs e)
        {
            var boss = picBoss.Location;
            switch (setStage)
            {
                case 3:
                    if (667 < boss.X && boss.X < 679)
                    {
                        boss.X = 673;
                        tmrStageMove.Enabled = false;
                        moveObsticle3 = true;
                        lblObsticle3.Visible = true;
                        setStage++;
                    }
                    else
                    {
                        if (boss.X < 673)
                        {
                            boss.X += 5;
                        }
                        else
                        {
                            boss.X -= 5;
                        }
                    }
                    break;
                case 2:
                    if (215 < boss.X && boss.X < 227)
                    {
                        boss.X = 221;
                        tmrSet4.Enabled = true;
                        lblObsticle2.Visible = true;
                        setStage++;

                    }
                    else
                    {
                        if (boss.X < 221)
                        {
                            boss.X += 5;
                        }
                        else
                        {
                            boss.X -= 5;
                        }
                    }
                    break;

                case 1:
                    if (446 < boss.X && boss.X < 458)
                    {
                        boss.X = 452;
                        tmrStageMove.Enabled = false;
                        tmrSet3.Enabled = true;
                        lblObstacle1.Visible = true;
                    }
                    else
                    {
                        if (boss.X < 452)
                        {
                            boss.X += 5;
                        }
                        else
                        {
                            boss.X -= 5;
                        }
                    }
                    break;
            }
            picBoss.Location = boss;
        }

        private void Stage3_Tick(object sender, EventArgs e)
        {
            var obst = lblObstacle1.Location;
            var size = lblObstacle1.Size;
            if (obst.Y != 358)
            {
                obst.Y += 2;
            }
            else
            {
                if (size.Width != 596)
                {
                    size.Width += 4;
                    lblObstacle1.Size = size;
                    obst.X -= 2;
                }
                else
                {
                    woundComplete = true;
                    tmrSet3.Enabled = false;
                }
            }
            lblObstacle1.Location = obst;
        }

        private void Stage4_Tick(object sender, EventArgs e)
        {
            var obst2 = lblObsticle2.Location;
            var obst3 = lblObsticle3.Location;
            var size2 = lblObsticle2.Size;
            var size3 = lblObsticle3.Size;

            if (obst2.Y != 229)
            {
                obst2.Y += 3;
            }
            else
            {
                if (size2.Height != 255)
                {
                    size2.Height += 3;
                    lblObsticle2.Size = size2;
                }
               
            }
            lblObsticle2.Location = obst2;
            if (moveObsticle3)
            {
                if (obst3.Y != 229)
                {
                    obst3.Y += 3;
                }
                else
                {
                    if (size3.Height != 255)
                    {
                        size3.Height += 3;
                        lblObsticle3.Size = size3;
                    }
                    else
                    {
                        woundComplete = true;
                        tmrSet4.Enabled = false;
                    }
                }
            }
            lblObsticle3.Location = obst3;
        }

        private void Credits_Tick(object sender, EventArgs e)
        {
            var x = lblCredits1.Location;
            var y = lblCredits2.Location;
            x.Y -= 3;
            y.Y -= 3;
            lblCredits1.Location = x;
            lblCredits2.Location = y;
            if (x.Y < 195)
            {
                tmrCredits.Enabled = false;
            }
        }
    }
}
