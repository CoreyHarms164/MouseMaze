namespace Mouse_Maze
{
    partial class Hardcore2
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
            this.lblPad1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPad2 = new System.Windows.Forms.Label();
            this.lblPad3 = new System.Windows.Forms.Label();
            this.lblPad4 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPad1 = new System.Windows.Forms.Timer(this.components);
            this.tmrPad2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblPad5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "Level 2";
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
            // lblPad1
            // 
            this.lblPad1.BackColor = System.Drawing.Color.Black;
            this.lblPad1.Location = new System.Drawing.Point(207, 125);
            this.lblPad1.Name = "lblPad1";
            this.lblPad1.Size = new System.Drawing.Size(15, 40);
            this.lblPad1.TabIndex = 37;
            this.lblPad1.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(123, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 25);
            this.label2.TabIndex = 36;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(42, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 35;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(29, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 59);
            this.label1.TabIndex = 34;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(41, 500);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 39;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(29, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 59);
            this.label3.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(518, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 131);
            this.label6.TabIndex = 40;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblPad2
            // 
            this.lblPad2.BackColor = System.Drawing.Color.Black;
            this.lblPad2.Location = new System.Drawing.Point(268, 125);
            this.lblPad2.Name = "lblPad2";
            this.lblPad2.Size = new System.Drawing.Size(15, 40);
            this.lblPad2.TabIndex = 41;
            this.lblPad2.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblPad3
            // 
            this.lblPad3.BackColor = System.Drawing.Color.Black;
            this.lblPad3.Location = new System.Drawing.Point(331, 125);
            this.lblPad3.Name = "lblPad3";
            this.lblPad3.Size = new System.Drawing.Size(15, 40);
            this.lblPad3.TabIndex = 42;
            this.lblPad3.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // lblPad4
            // 
            this.lblPad4.BackColor = System.Drawing.Color.Black;
            this.lblPad4.Location = new System.Drawing.Point(398, 125);
            this.lblPad4.Name = "lblPad4";
            this.lblPad4.Size = new System.Drawing.Size(15, 40);
            this.lblPad4.TabIndex = 43;
            this.lblPad4.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrPad1
            // 
            this.tmrPad1.Interval = 50;
            this.tmrPad1.Tick += new System.EventHandler(this.Pad1_Tick);
            // 
            // tmrPad2
            // 
            this.tmrPad2.Interval = 35;
            this.tmrPad2.Tick += new System.EventHandler(this.Pad2_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(518, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 171);
            this.label5.TabIndex = 44;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblPad5
            // 
            this.lblPad5.BackColor = System.Drawing.Color.DarkRed;
            this.lblPad5.Location = new System.Drawing.Point(554, 298);
            this.lblPad5.Name = "lblPad5";
            this.lblPad5.Size = new System.Drawing.Size(21, 60);
            this.lblPad5.TabIndex = 45;
            this.lblPad5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(170, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 25);
            this.label7.TabIndex = 46;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(122, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 47;
            // 
            // Hardcore2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPad5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPad4);
            this.Controls.Add(this.lblPad3);
            this.Controls.Add(this.lblPad2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPad1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hardcore2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "12";
            this.Text = "Hardcore2";
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
        private System.Windows.Forms.Label lblPad1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPad2;
        private System.Windows.Forms.Label lblPad3;
        private System.Windows.Forms.Label lblPad4;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrPad1;
        private System.Windows.Forms.Timer tmrPad2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPad5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}