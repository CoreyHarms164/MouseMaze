namespace Mouse_Maze
{
    partial class Hardcore10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hardcore10));
            this.lblBack = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMili = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBoss = new System.Windows.Forms.PictureBox();
            this.picDefeat = new System.Windows.Forms.PictureBox();
            this.lblBullet1 = new System.Windows.Forms.Label();
            this.lblBullet2 = new System.Windows.Forms.Label();
            this.lblBullet3 = new System.Windows.Forms.Label();
            this.lblBullet4 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.BossHealth = new System.Windows.Forms.ProgressBar();
            this.tmrBossEnter = new System.Windows.Forms.Timer(this.components);
            this.tmrBoss = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.tmrBullets = new System.Windows.Forms.Timer(this.components);
            this.tmrAttack = new System.Windows.Forms.Timer(this.components);
            this.tmrWound = new System.Windows.Forms.Timer(this.components);
            this.tmrStageMove = new System.Windows.Forms.Timer(this.components);
            this.tmrSet3 = new System.Windows.Forms.Timer(this.components);
            this.tmrSet4 = new System.Windows.Forms.Timer(this.components);
            this.lblObstacle1 = new System.Windows.Forms.Label();
            this.lblObsticle3 = new System.Windows.Forms.Label();
            this.lblObsticle2 = new System.Windows.Forms.Label();
            this.tmrCredits = new System.Windows.Forms.Timer(this.components);
            this.lblCredits1 = new System.Windows.Forms.Label();
            this.lblCredits2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefeat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Red;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(81, 37);
            this.lblBack.TabIndex = 29;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblBack.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(396, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 37);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Level 10";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(870, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 34);
            this.label4.TabIndex = 32;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Red;
            this.lblSec.Location = new System.Drawing.Point(808, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(70, 32);
            this.lblSec.TabIndex = 31;
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMili
            // 
            this.lblMili.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMili.ForeColor = System.Drawing.Color.Red;
            this.lblMili.Location = new System.Drawing.Point(889, 9);
            this.lblMili.Name = "lblMili";
            this.lblMili.Size = new System.Drawing.Size(70, 32);
            this.lblMili.TabIndex = 30;
            this.lblMili.Text = "00";
            this.lblMili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(949, 552);
            this.label7.TabIndex = 50;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(433, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 51;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBoss
            // 
            this.picBoss.BackColor = System.Drawing.Color.DarkRed;
            this.picBoss.Image = ((System.Drawing.Image)(resources.GetObject("picBoss.Image")));
            this.picBoss.Location = new System.Drawing.Point(416, 56);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(79, 98);
            this.picBoss.TabIndex = 52;
            this.picBoss.TabStop = false;
            this.picBoss.Visible = false;
            this.picBoss.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // picDefeat
            // 
            this.picDefeat.BackColor = System.Drawing.Color.DarkRed;
            this.picDefeat.Image = ((System.Drawing.Image)(resources.GetObject("picDefeat.Image")));
            this.picDefeat.Location = new System.Drawing.Point(416, 56);
            this.picDefeat.Name = "picDefeat";
            this.picDefeat.Size = new System.Drawing.Size(79, 98);
            this.picDefeat.TabIndex = 53;
            this.picDefeat.TabStop = false;
            this.picDefeat.Visible = false;
            // 
            // lblBullet1
            // 
            this.lblBullet1.Location = new System.Drawing.Point(148, 67);
            this.lblBullet1.Name = "lblBullet1";
            this.lblBullet1.Size = new System.Drawing.Size(10, 79);
            this.lblBullet1.TabIndex = 54;
            this.lblBullet1.Text = "label1";
            this.lblBullet1.Visible = false;
            this.lblBullet1.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblBullet2
            // 
            this.lblBullet2.Location = new System.Drawing.Point(174, 67);
            this.lblBullet2.Name = "lblBullet2";
            this.lblBullet2.Size = new System.Drawing.Size(15, 79);
            this.lblBullet2.TabIndex = 55;
            this.lblBullet2.Text = "label2";
            this.lblBullet2.Visible = false;
            this.lblBullet2.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblBullet3
            // 
            this.lblBullet3.Location = new System.Drawing.Point(204, 67);
            this.lblBullet3.Name = "lblBullet3";
            this.lblBullet3.Size = new System.Drawing.Size(20, 79);
            this.lblBullet3.TabIndex = 56;
            this.lblBullet3.Text = "label3";
            this.lblBullet3.Visible = false;
            this.lblBullet3.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblBullet4
            // 
            this.lblBullet4.Location = new System.Drawing.Point(243, 67);
            this.lblBullet4.Name = "lblBullet4";
            this.lblBullet4.Size = new System.Drawing.Size(25, 79);
            this.lblBullet4.TabIndex = 57;
            this.lblBullet4.Text = "label5";
            this.lblBullet4.Visible = false;
            this.lblBullet4.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(691, 365);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 58;
            this.btnAttack.TabStop = false;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // BossHealth
            // 
            this.BossHealth.Location = new System.Drawing.Point(618, 30);
            this.BossHealth.Name = "BossHealth";
            this.BossHealth.Size = new System.Drawing.Size(148, 23);
            this.BossHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BossHealth.TabIndex = 59;
            this.BossHealth.Visible = false;
            // 
            // tmrBossEnter
            // 
            this.tmrBossEnter.Interval = 20;
            this.tmrBossEnter.Tick += new System.EventHandler(this.BossEnter_Tick);
            // 
            // tmrBoss
            // 
            this.tmrBoss.Interval = 10;
            this.tmrBoss.Tick += new System.EventHandler(this.Boss_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 500;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // tmrBullets
            // 
            this.tmrBullets.Interval = 10;
            this.tmrBullets.Tick += new System.EventHandler(this.Bullets_Tick);
            // 
            // tmrAttack
            // 
            this.tmrAttack.Interval = 1000;
            this.tmrAttack.Tick += new System.EventHandler(this.Attack_Tick);
            // 
            // tmrWound
            // 
            this.tmrWound.Interval = 10;
            this.tmrWound.Tick += new System.EventHandler(this.Wound_Tick);
            // 
            // tmrStageMove
            // 
            this.tmrStageMove.Interval = 10;
            this.tmrStageMove.Tick += new System.EventHandler(this.StageMove_Tick);
            // 
            // tmrSet3
            // 
            this.tmrSet3.Interval = 10;
            this.tmrSet3.Tick += new System.EventHandler(this.Stage3_Tick);
            // 
            // tmrSet4
            // 
            this.tmrSet4.Interval = 10;
            this.tmrSet4.Tick += new System.EventHandler(this.Stage4_Tick);
            // 
            // lblObstacle1
            // 
            this.lblObstacle1.Location = new System.Drawing.Point(488, 136);
            this.lblObstacle1.Name = "lblObstacle1";
            this.lblObstacle1.Size = new System.Drawing.Size(12, 15);
            this.lblObstacle1.TabIndex = 61;
            this.lblObstacle1.Text = "label1";
            this.lblObstacle1.Visible = false;
            this.lblObstacle1.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblObsticle3
            // 
            this.lblObsticle3.Location = new System.Drawing.Point(704, 136);
            this.lblObsticle3.Name = "lblObsticle3";
            this.lblObsticle3.Size = new System.Drawing.Size(18, 15);
            this.lblObsticle3.TabIndex = 62;
            this.lblObsticle3.Text = "label1";
            this.lblObsticle3.Visible = false;
            this.lblObsticle3.Click += new System.EventHandler(this.Stage4_Tick);
            this.lblObsticle3.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblObsticle2
            // 
            this.lblObsticle2.Location = new System.Drawing.Point(252, 136);
            this.lblObsticle2.Name = "lblObsticle2";
            this.lblObsticle2.Size = new System.Drawing.Size(18, 15);
            this.lblObsticle2.TabIndex = 65;
            this.lblObsticle2.Text = "label1";
            this.lblObsticle2.Visible = false;
            // 
            // tmrCredits
            // 
            this.tmrCredits.Interval = 10;
            this.tmrCredits.Tick += new System.EventHandler(this.Credits_Tick);
            // 
            // lblCredits1
            // 
            this.lblCredits1.BackColor = System.Drawing.Color.DarkRed;
            this.lblCredits1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits1.ForeColor = System.Drawing.Color.Black;
            this.lblCredits1.Location = new System.Drawing.Point(235, 613);
            this.lblCredits1.Name = "lblCredits1";
            this.lblCredits1.Size = new System.Drawing.Size(502, 53);
            this.lblCredits1.TabIndex = 66;
            this.lblCredits1.Text = "Congratulations! You have completed Mouse Maze!";
            this.lblCredits1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCredits1.Visible = false;
            // 
            // lblCredits2
            // 
            this.lblCredits2.BackColor = System.Drawing.Color.DarkRed;
            this.lblCredits2.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits2.ForeColor = System.Drawing.Color.Black;
            this.lblCredits2.Location = new System.Drawing.Point(235, 679);
            this.lblCredits2.Name = "lblCredits2";
            this.lblCredits2.Size = new System.Drawing.Size(502, 53);
            this.lblCredits2.TabIndex = 67;
            this.lblCredits2.Text = "Thanks for playing!";
            this.lblCredits2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCredits2.Visible = false;
            // 
            // Hardcore10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.lblCredits2);
            this.Controls.Add(this.lblCredits1);
            this.Controls.Add(this.lblObsticle2);
            this.Controls.Add(this.lblObsticle3);
            this.Controls.Add(this.lblObstacle1);
            this.Controls.Add(this.picBoss);
            this.Controls.Add(this.lblBullet4);
            this.Controls.Add(this.lblBullet3);
            this.Controls.Add(this.lblBullet2);
            this.Controls.Add(this.lblBullet1);
            this.Controls.Add(this.BossHealth);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picDefeat);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hardcore10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "20";
            this.Text = "Hardcore10";
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBoss;
        private System.Windows.Forms.PictureBox picDefeat;
        private System.Windows.Forms.Label lblBullet1;
        private System.Windows.Forms.Label lblBullet2;
        private System.Windows.Forms.Label lblBullet3;
        private System.Windows.Forms.Label lblBullet4;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ProgressBar BossHealth;
        private System.Windows.Forms.Timer tmrBossEnter;
        private System.Windows.Forms.Timer tmrBoss;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Timer tmrBullets;
        private System.Windows.Forms.Timer tmrAttack;
        private System.Windows.Forms.Timer tmrWound;
        private System.Windows.Forms.Timer tmrStageMove;
        private System.Windows.Forms.Timer tmrSet3;
        private System.Windows.Forms.Timer tmrSet4;
        private System.Windows.Forms.Label lblObstacle1;
        private System.Windows.Forms.Label lblObsticle3;
        private System.Windows.Forms.Label lblObsticle2;
        private System.Windows.Forms.Timer tmrCredits;
        private System.Windows.Forms.Label lblCredits1;
        private System.Windows.Forms.Label lblCredits2;
    }
}