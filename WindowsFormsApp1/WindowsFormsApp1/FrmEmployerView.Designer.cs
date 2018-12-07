namespace WindowsFormsApp1
{
    partial class FrmEmployerView
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
            this.label2 = new System.Windows.Forms.Label();
            this.dGVEmployerView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abcdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCandidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployerView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(551, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employer View";
            // 
            // dGVEmployerView
            // 
            this.dGVEmployerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVEmployerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployerView.Location = new System.Drawing.Point(219, 85);
            this.dGVEmployerView.Name = "dGVEmployerView";
            this.dGVEmployerView.Size = new System.Drawing.Size(838, 406);
            this.dGVEmployerView.TabIndex = 5;
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
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
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
            // FrmEmployerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1240, 491);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGVEmployerView);
            this.Controls.Add(this.label2);
            this.Name = "FrmEmployerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployerView";
            this.Load += new System.EventHandler(this.FrmEmployerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployerView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVEmployerView;
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