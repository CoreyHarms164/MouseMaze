namespace Mouse_Maze
{
    partial class Level10
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
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMili = new System.Windows.Forms.Label();
            this.tmrPad = new System.Windows.Forms.Timer(this.components);
            this.lblPad = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.tmrTyper = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Blue;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(81, 37);
            this.lblBack.TabIndex = 19;
            this.lblBack.Tag = "";
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblBack.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(441, 255);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 18;
            this.btnFinish.TabStop = false;
            this.btnFinish.Tag = "remove";
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(429, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 59);
            this.label3.TabIndex = 17;
            this.label3.Tag = "remove";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(59, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.TabStop = false;
            this.btnStart.Tag = "remove";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(46, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 59);
            this.label1.TabIndex = 14;
            this.label1.Tag = "remove";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(216, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Tag = "remove";
            this.lblTitle.Text = "Level 10";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(427, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 34);
            this.label4.TabIndex = 22;
            this.label4.Tag = "remove";
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Blue;
            this.lblSec.Location = new System.Drawing.Point(365, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(70, 32);
            this.lblSec.TabIndex = 21;
            this.lblSec.Tag = "remove";
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMili
            // 
            this.lblMili.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMili.ForeColor = System.Drawing.Color.Blue;
            this.lblMili.Location = new System.Drawing.Point(446, 9);
            this.lblMili.Name = "lblMili";
            this.lblMili.Size = new System.Drawing.Size(70, 32);
            this.lblMili.TabIndex = 20;
            this.lblMili.Tag = "remove";
            this.lblMili.Text = "00";
            this.lblMili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPad
            // 
            this.tmrPad.Interval = 50;
            this.tmrPad.Tick += new System.EventHandler(this.Pad_Tick);
            // 
            // lblPad
            // 
            this.lblPad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPad.Location = new System.Drawing.Point(46, 234);
            this.lblPad.Name = "lblPad";
            this.lblPad.Size = new System.Drawing.Size(100, 59);
            this.lblPad.TabIndex = 23;
            this.lblPad.Tag = "remove";
            this.lblPad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.Font = new System.Drawing.Font("Buxton Sketch", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.Blue;
            this.lblCredits.Location = new System.Drawing.Point(24, 76);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(528, 380);
            this.lblCredits.TabIndex = 24;
            this.lblCredits.Tag = "remove";
            this.lblCredits.Visible = false;
            // 
            // tmrTyper
            // 
            this.tmrTyper.Tick += new System.EventHandler(this.tmrTyper_Tick);
            // 
            // Level10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(595, 469);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMili);
            this.Controls.Add(this.lblPad);
            this.Controls.Add(this.lblCredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "10";
            this.Text = "Level10";
            this.Load += new System.EventHandler(this.Level_Load);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Timer tmrPad;
        private System.Windows.Forms.Label lblPad;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Timer tmrTyper;
    }
}