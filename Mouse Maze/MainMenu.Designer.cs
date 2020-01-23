namespace Mouse_Maze
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Maze";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Blue;
            this.lblStart.Location = new System.Drawing.Point(87, 93);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(126, 37);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            this.lblStart.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblStart.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblScores
            // 
            this.lblScores.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Blue;
            this.lblScores.Location = new System.Drawing.Point(99, 139);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(104, 26);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScores.Click += new System.EventHandler(this.lblScores_Click);
            this.lblScores.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblScores.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Blue;
            this.lblExit.Location = new System.Drawing.Point(109, 222);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(83, 33);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(99, 182);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(104, 26);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            this.lblInfo.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblInfo.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Blue;
            this.lblInformation.Location = new System.Drawing.Point(39, 67);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(244, 210);
            this.lblInformation.TabIndex = 5;
            this.lblInformation.Text = "Welcome to Mouse Maze!  Navigate your cursor through the maze without touching th" +
    "e sides.  Do not click the mouse button while going through the maze.  Good Luck" +
    "!";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformation.Visible = false;
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Blue;
            this.lblBack.Location = new System.Drawing.Point(120, 277);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(83, 33);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Visible = false;
            this.lblBack.Click += new System.EventHandler(this.label2_Click);
            this.lblBack.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblBack.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(327, 314);
            this.ControlBox = false;
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Maze";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblBack;
    }
}

