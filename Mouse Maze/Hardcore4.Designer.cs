namespace Mouse_Maze
{
    partial class Hardcore4
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
            this.lblStop2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblPad1 = new System.Windows.Forms.Label();
            this.tmrPad1 = new System.Windows.Forms.Timer(this.components);
            this.lblPad2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrPad2 = new System.Windows.Forms.Timer(this.components);
            this.lblStop1 = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "Level 4";
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
            this.btnFinish.Location = new System.Drawing.Point(425, 562);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 45;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblStop2
            // 
            this.lblStop2.BackColor = System.Drawing.Color.DarkRed;
            this.lblStop2.Location = new System.Drawing.Point(413, 541);
            this.lblStop2.Name = "lblStop2";
            this.lblStop2.Size = new System.Drawing.Size(100, 59);
            this.lblStop2.TabIndex = 44;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(426, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 41;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblPad1
            // 
            this.lblPad1.BackColor = System.Drawing.Color.DarkRed;
            this.lblPad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPad1.ForeColor = System.Drawing.Color.White;
            this.lblPad1.Location = new System.Drawing.Point(413, 61);
            this.lblPad1.Name = "lblPad1";
            this.lblPad1.Size = new System.Drawing.Size(101, 59);
            this.lblPad1.TabIndex = 46;
            this.lblPad1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPad1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // tmrPad1
            // 
            this.tmrPad1.Interval = 10;
            this.tmrPad1.Tick += new System.EventHandler(this.tmrPad1_Tick);
            // 
            // lblPad2
            // 
            this.lblPad2.BackColor = System.Drawing.Color.DarkRed;
            this.lblPad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPad2.ForeColor = System.Drawing.Color.White;
            this.lblPad2.Location = new System.Drawing.Point(173, 301);
            this.lblPad2.Name = "lblPad2";
            this.lblPad2.Size = new System.Drawing.Size(101, 59);
            this.lblPad2.TabIndex = 48;
            this.lblPad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPad2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            this.lblPad2.MouseEnter += new System.EventHandler(this.PadEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(264, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(399, 15);
            this.label7.TabIndex = 49;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // tmrPad2
            // 
            this.tmrPad2.Interval = 10;
            this.tmrPad2.Tick += new System.EventHandler(this.tmrPad2_Tick);
            // 
            // lblStop1
            // 
            this.lblStop1.BackColor = System.Drawing.Color.DarkRed;
            this.lblStop1.Location = new System.Drawing.Point(653, 301);
            this.lblStop1.Name = "lblStop1";
            this.lblStop1.Size = new System.Drawing.Size(100, 59);
            this.lblStop1.TabIndex = 50;
            this.lblStop1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // Hardcore4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblStop2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.Controls.Add(this.lblStop1);
            this.Controls.Add(this.lblPad1);
            this.Controls.Add(this.lblPad2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hardcore4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "14";
            this.Text = "Hardcore4";
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
        private System.Windows.Forms.Label lblStop2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblPad1;
        private System.Windows.Forms.Timer tmrPad1;
        private System.Windows.Forms.Label lblPad2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmrPad2;
        private System.Windows.Forms.Label lblStop1;
    }
}