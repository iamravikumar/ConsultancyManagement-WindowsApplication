namespace WindowsFormsApp1
{
    partial class FrmCandidateView
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
            this.dGVCandidateView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abcdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCandidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCandidateView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(437, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate List";
            // 
            // dGVCandidateView
            // 
            this.dGVCandidateView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dGVCandidateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCandidateView.Location = new System.Drawing.Point(119, 83);
            this.dGVCandidateView.Name = "dGVCandidateView";
            this.dGVCandidateView.Size = new System.Drawing.Size(796, 373);
            this.dGVCandidateView.TabIndex = 1;
            this.dGVCandidateView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCandidateView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abcdToolStripMenuItem,
            this.candidatesToolStripMenuItem,
            this.employersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abcdToolStripMenuItem
            // 
            this.abcdToolStripMenuItem.Name = "abcdToolStripMenuItem";
            this.abcdToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.abcdToolStripMenuItem.Text = "Abcd";
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCandidatesToolStripMenuItem,
            this.addCandidateToolStripMenuItem});
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            // 
            // viewCandidatesToolStripMenuItem
            // 
            this.viewCandidatesToolStripMenuItem.Name = "viewCandidatesToolStripMenuItem";
            this.viewCandidatesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewCandidatesToolStripMenuItem.Text = "View Candidates";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addCandidateToolStripMenuItem.Text = "Add Candidate";
            // 
            // employersToolStripMenuItem
            // 
            this.employersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployersToolStripMenuItem,
            this.addEmployerToolStripMenuItem});
            this.employersToolStripMenuItem.Name = "employersToolStripMenuItem";
            this.employersToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.employersToolStripMenuItem.Text = "Employers";
            // 
            // viewEmployersToolStripMenuItem
            // 
            this.viewEmployersToolStripMenuItem.Name = "viewEmployersToolStripMenuItem";
            this.viewEmployersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewEmployersToolStripMenuItem.Text = "View Employers";
            // 
            // addEmployerToolStripMenuItem
            // 
            this.addEmployerToolStripMenuItem.Name = "addEmployerToolStripMenuItem";
            this.addEmployerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addEmployerToolStripMenuItem.Text = "Add Employer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmCandidateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGVCandidateView);
            this.Controls.Add(this.label1);
            this.Name = "FrmCandidateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCandidateView";
            this.Load += new System.EventHandler(this.FrmCandidateView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCandidateView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVCandidateView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abcdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCandidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}