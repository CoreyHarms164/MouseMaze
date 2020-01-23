namespace Mouse_Maze
{
    partial class Scores
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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Blue;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(81, 37);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblBack.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblScores
            // 
            this.lblScores.Font = new System.Drawing.Font("Buxton Sketch", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Blue;
            this.lblScores.Location = new System.Drawing.Point(12, 117);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(571, 343);
            this.lblScores.TabIndex = 11;
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.ForeColor = System.Drawing.Color.Blue;
            this.lblReset.Location = new System.Drawing.Point(403, 9);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(180, 37);
            this.lblReset.TabIndex = 12;
            this.lblReset.Text = "Reset Scores";
            this.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReset.Click += new System.EventHandler(this.label1_Click);
            this.lblReset.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblReset.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Buxton Sketch", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.Color.Blue;
            this.lblPrompt.Location = new System.Drawing.Point(103, 117);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(363, 123);
            this.lblPrompt.TabIndex = 13;
            this.lblPrompt.Text = "This will reset all scores. Do you wish to continue?";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrompt.Visible = false;
            // 
            // lblYes
            // 
            this.lblYes.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.Blue;
            this.lblYes.Location = new System.Drawing.Point(158, 240);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(81, 37);
            this.lblYes.TabIndex = 14;
            this.lblYes.Text = "Yes";
            this.lblYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYes.Visible = false;
            this.lblYes.Click += new System.EventHandler(this.Reset_Click);
            this.lblYes.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblYes.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblNo
            // 
            this.lblNo.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Blue;
            this.lblNo.Location = new System.Drawing.Point(320, 240);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(81, 37);
            this.lblNo.TabIndex = 15;
            this.lblNo.Text = "No";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNo.Visible = false;
            this.lblNo.Click += new System.EventHandler(this.Reset_Click);
            this.lblNo.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblNo.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // lblOk
            // 
            this.lblOk.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOk.ForeColor = System.Drawing.Color.Blue;
            this.lblOk.Location = new System.Drawing.Point(245, 240);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(81, 37);
            this.lblOk.TabIndex = 16;
            this.lblOk.Text = "Ok";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOk.Visible = false;
            this.lblOk.Click += new System.EventHandler(this.Reset_Click);
            this.lblOk.MouseEnter += new System.EventHandler(this.lbl_Enter);
            this.lblOk.MouseLeave += new System.EventHandler(this.lbl_Leave);
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(595, 469);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.Scores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblOk;
    }
}