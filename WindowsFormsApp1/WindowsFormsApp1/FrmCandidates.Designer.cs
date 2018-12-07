namespace WindowsFormsApp1
{
    partial class FrmCandidates
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
            this.LnLblCandidateRegistration = new System.Windows.Forms.LinkLabel();
            this.LnLblCandidateView = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LnLblCandidateRegistration
            // 
            this.LnLblCandidateRegistration.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblCandidateRegistration.AutoSize = true;
            this.LnLblCandidateRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblCandidateRegistration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblCandidateRegistration.Location = new System.Drawing.Point(217, 96);
            this.LnLblCandidateRegistration.Name = "LnLblCandidateRegistration";
            this.LnLblCandidateRegistration.Size = new System.Drawing.Size(209, 25);
            this.LnLblCandidateRegistration.TabIndex = 0;
            this.LnLblCandidateRegistration.TabStop = true;
            this.LnLblCandidateRegistration.Text = "Candidate Registration";
            this.LnLblCandidateRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblCandidateRegistration_LinkClicked);
            // 
            // LnLblCandidateView
            // 
            this.LnLblCandidateView.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblCandidateView.AutoSize = true;
            this.LnLblCandidateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblCandidateView.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblCandidateView.Location = new System.Drawing.Point(217, 167);
            this.LnLblCandidateView.Name = "LnLblCandidateView";
            this.LnLblCandidateView.Size = new System.Drawing.Size(150, 25);
            this.LnLblCandidateView.TabIndex = 0;
            this.LnLblCandidateView.TabStop = true;
            this.LnLblCandidateView.Text = "Candidate View";
            this.LnLblCandidateView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblCandidateView_LinkClicked);
            // 
            // FrmCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LnLblCandidateView);
            this.Controls.Add(this.LnLblCandidateRegistration);
            this.Name = "FrmCandidates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LnLblCandidateRegistration;
        private System.Windows.Forms.LinkLabel LnLblCandidateView;
    }
}