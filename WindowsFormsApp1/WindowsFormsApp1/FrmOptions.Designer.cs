namespace WindowsFormsApp1
{
    partial class FrmOptions
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
            this.LnLblCandidates = new System.Windows.Forms.LinkLabel();
            this.LnLblEmployers = new System.Windows.Forms.LinkLabel();
            this.LnLblMatches = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LnLblCandidates
            // 
            this.LnLblCandidates.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblCandidates.AutoSize = true;
            this.LnLblCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblCandidates.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblCandidates.Location = new System.Drawing.Point(205, 105);
            this.LnLblCandidates.Name = "LnLblCandidates";
            this.LnLblCandidates.Size = new System.Drawing.Size(112, 25);
            this.LnLblCandidates.TabIndex = 0;
            this.LnLblCandidates.TabStop = true;
            this.LnLblCandidates.Text = "Candidates";
            this.LnLblCandidates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblCandidates_LinkClicked);
            // 
            // LnLblEmployers
            // 
            this.LnLblEmployers.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblEmployers.AutoSize = true;
            this.LnLblEmployers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblEmployers.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblEmployers.Location = new System.Drawing.Point(205, 163);
            this.LnLblEmployers.Name = "LnLblEmployers";
            this.LnLblEmployers.Size = new System.Drawing.Size(104, 25);
            this.LnLblEmployers.TabIndex = 0;
            this.LnLblEmployers.TabStop = true;
            this.LnLblEmployers.Text = "Employers";
            this.LnLblEmployers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblEmployers_LinkClicked);
            // 
            // LnLblMatches
            // 
            this.LnLblMatches.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblMatches.AutoSize = true;
            this.LnLblMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblMatches.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblMatches.Location = new System.Drawing.Point(205, 224);
            this.LnLblMatches.Name = "LnLblMatches";
            this.LnLblMatches.Size = new System.Drawing.Size(87, 25);
            this.LnLblMatches.TabIndex = 0;
            this.LnLblMatches.TabStop = true;
            this.LnLblMatches.Text = "Matches";
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LnLblMatches);
            this.Controls.Add(this.LnLblEmployers);
            this.Controls.Add(this.LnLblCandidates);
            this.Name = "FrmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnLblCandidates;
        private System.Windows.Forms.LinkLabel LnLblEmployers;
        private System.Windows.Forms.LinkLabel LnLblMatches;
    }
}