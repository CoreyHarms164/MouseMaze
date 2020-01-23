namespace Mouse_Maze
{
    partial class Hardcore1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPad1 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPads = new System.Windows.Forms.Timer(this.components);
            this.lblPad2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Red;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(81, 37);
            this.lblBack.TabIndex = 24;
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
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Level 1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(870, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 34);
            this.label4.TabIndex = 27;
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
            this.lblSec.TabIndex = 26;
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
            this.lblMili.TabIndex = 25;
            this.lblMili.Text = "00";
            this.lblMili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(806, 539);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 29;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(793, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 59);
            this.label1.TabIndex = 28;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(88, 98);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 31;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(76, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 59);
            this.label3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(79, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(721, 15);
            this.label2.TabIndex = 32;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(79, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 253);
            this.label5.TabIndex = 33;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(79, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 34;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(618, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 35;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblPad1
            // 
            this.lblPad1.BackColor = System.Drawing.Color.DarkRed;
            this.lblPad1.Location = new System.Drawing.Point(253, 283);
            this.lblPad1.Name = "lblPad1";
            this.lblPad1.Size = new System.Drawing.Size(66, 58);
            this.lblPad1.TabIndex = 36;
            this.lblPad1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrPads
            // 
            this.tmrPads.Interval = 40;
            this.tmrPads.Tick += new System.EventHandler(this.tmrPads_Tick);
            // 
            // lblPad2
            // 
            this.lblPad2.BackColor = System.Drawing.Color.DarkRed;
            this.lblPad2.Location = new System.Drawing.Point(851, 283);
            this.lblPad2.Name = "lblPad2";
            this.lblPad2.Size = new System.Drawing.Size(66, 58);
            this.lblPad2.TabIndex = 37;
            this.lblPad2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(223, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(634, 20);
            this.label9.TabIndex = 38;
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(169, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 39;
            // 
            // Hardcore1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPad2);
            this.Controls.Add(this.lblPad1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hardcore1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "11";
            this.Text = "Hardcore1";
            this.Load += new System.EventHandler(this.Level_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPad1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrPads;
        private System.Windows.Forms.Label lblPad2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}