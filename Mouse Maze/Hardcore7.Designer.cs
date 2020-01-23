namespace Mouse_Maze
{
    partial class Hardcore7
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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMili = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.tmrPad = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "Level 7";
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
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(425, 533);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 45;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(413, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 59);
            this.label3.TabIndex = 44;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(426, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 41;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(413, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 59);
            this.label1.TabIndex = 40;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(453, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 168);
            this.label5.TabIndex = 46;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.DarkRed;
            this.lblLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.White;
            this.lblLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLeft.Location = new System.Drawing.Point(411, 283);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(50, 59);
            this.lblLeft.TabIndex = 47;
            this.lblLeft.Tag = "Left";
            this.lblLeft.Text = "<--";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.lblLeft.MouseEnter += new System.EventHandler(this.Pad_Enter);
            // 
            // lblRight
            // 
            this.lblRight.BackColor = System.Drawing.Color.DarkRed;
            this.lblRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.ForeColor = System.Drawing.Color.White;
            this.lblRight.Location = new System.Drawing.Point(459, 283);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(50, 59);
            this.lblRight.TabIndex = 48;
            this.lblRight.Tag = "Right";
            this.lblRight.Text = "  -->";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.lblRight.MouseEnter += new System.EventHandler(this.Pad_Enter);
            // 
            // tmrPad
            // 
            this.tmrPad.Interval = 10;
            this.tmrPad.Tick += new System.EventHandler(this.Pad_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(833, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 226);
            this.label2.TabIndex = 50;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.label2.MouseEnter += new System.EventHandler(this.Trigger_Enter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(537, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 15);
            this.label7.TabIndex = 51;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(81, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 15);
            this.label6.TabIndex = 52;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(78, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 226);
            this.label8.TabIndex = 53;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.label8.MouseEnter += new System.EventHandler(this.Trigger_Enter);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(375, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(506, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 55;
            // 
            // Hardcore7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hardcore7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "17";
            this.Text = "Hardcore7";
            this.Load += new System.EventHandler(this.Level_Load);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Timer tmrPad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}