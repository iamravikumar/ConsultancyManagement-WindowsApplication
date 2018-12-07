namespace WindowsFormsApp1
{
    partial class FrmEmployerRegistration
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
            this.PnlCandUpdDel = new System.Windows.Forms.Panel();
            this.rTxtAddress = new System.Windows.Forms.RichTextBox();
            this.BtnEmpReg = new System.Windows.Forms.Button();
            this.LblEmpAddress = new System.Windows.Forms.Label();
            this.TxtEmpPhone = new System.Windows.Forms.TextBox();
            this.LblEmpPhone = new System.Windows.Forms.Label();
            this.TxtEmpEmail = new System.Windows.Forms.TextBox();
            this.TxtEmpContactPerson = new System.Windows.Forms.TextBox();
            this.LblEmpEmail = new System.Windows.Forms.Label();
            this.LblEmpContactPerson = new System.Windows.Forms.Label();
            this.TxtEmpRegistrationNumber = new System.Windows.Forms.TextBox();
            this.LblEmpRegistrationNumber = new System.Windows.Forms.Label();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.LblEmpFName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abcdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCandidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlCandUpdDel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(237, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employer Registration";
            // 
            // PnlCandUpdDel
            // 
            this.PnlCandUpdDel.Controls.Add(this.rTxtAddress);
            this.PnlCandUpdDel.Controls.Add(this.label2);
            this.PnlCandUpdDel.Controls.Add(this.BtnEmpReg);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpAddress);
            this.PnlCandUpdDel.Controls.Add(this.TxtEmpPhone);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpPhone);
            this.PnlCandUpdDel.Controls.Add(this.TxtEmpEmail);
            this.PnlCandUpdDel.Controls.Add(this.TxtEmpContactPerson);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpEmail);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpContactPerson);
            this.PnlCandUpdDel.Controls.Add(this.TxtEmpRegistrationNumber);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpRegistrationNumber);
            this.PnlCandUpdDel.Controls.Add(this.TxtEmpName);
            this.PnlCandUpdDel.Controls.Add(this.LblEmpFName);
            this.PnlCandUpdDel.Location = new System.Drawing.Point(244, 53);
            this.PnlCandUpdDel.Name = "PnlCandUpdDel";
            this.PnlCandUpdDel.Size = new System.Drawing.Size(741, 440);
            this.PnlCandUpdDel.TabIndex = 4;
            // 
            // rTxtAddress
            // 
            this.rTxtAddress.Location = new System.Drawing.Point(530, 194);
            this.rTxtAddress.Name = "rTxtAddress";
            this.rTxtAddress.Size = new System.Drawing.Size(183, 68);
            this.rTxtAddress.TabIndex = 4;
            this.rTxtAddress.Text = "";
            // 
            // BtnEmpReg
            // 
            this.BtnEmpReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpReg.Location = new System.Drawing.Point(171, 323);
            this.BtnEmpReg.Name = "BtnEmpReg";
            this.BtnEmpReg.Size = new System.Drawing.Size(420, 64);
            this.BtnEmpReg.TabIndex = 2;
            this.BtnEmpReg.Text = "Add Employer";
            this.BtnEmpReg.UseVisualStyleBackColor = true;
            this.BtnEmpReg.Click += new System.EventHandler(this.BtnEmpReg_Click);
            // 
            // LblEmpAddress
            // 
            this.LblEmpAddress.AutoSize = true;
            this.LblEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpAddress.Location = new System.Drawing.Point(413, 197);
            this.LblEmpAddress.Name = "LblEmpAddress";
            this.LblEmpAddress.Size = new System.Drawing.Size(59, 16);
            this.LblEmpAddress.TabIndex = 0;
            this.LblEmpAddress.Text = "Address";
            // 
            // TxtEmpPhone
            // 
            this.TxtEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpPhone.Location = new System.Drawing.Point(530, 145);
            this.TxtEmpPhone.Name = "TxtEmpPhone";
            this.TxtEmpPhone.Size = new System.Drawing.Size(183, 22);
            this.TxtEmpPhone.TabIndex = 1;
            // 
            // LblEmpPhone
            // 
            this.LblEmpPhone.AutoSize = true;
            this.LblEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpPhone.Location = new System.Drawing.Point(413, 148);
            this.LblEmpPhone.Name = "LblEmpPhone";
            this.LblEmpPhone.Size = new System.Drawing.Size(47, 16);
            this.LblEmpPhone.TabIndex = 0;
            this.LblEmpPhone.Text = "Phone";
            // 
            // TxtEmpEmail
            // 
            this.TxtEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpEmail.Location = new System.Drawing.Point(171, 194);
            this.TxtEmpEmail.Name = "TxtEmpEmail";
            this.TxtEmpEmail.Size = new System.Drawing.Size(183, 22);
            this.TxtEmpEmail.TabIndex = 1;
            // 
            // TxtEmpContactPerson
            // 
            this.TxtEmpContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpContactPerson.Location = new System.Drawing.Point(171, 142);
            this.TxtEmpContactPerson.Name = "TxtEmpContactPerson";
            this.TxtEmpContactPerson.Size = new System.Drawing.Size(183, 22);
            this.TxtEmpContactPerson.TabIndex = 1;
            // 
            // LblEmpEmail
            // 
            this.LblEmpEmail.AutoSize = true;
            this.LblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpEmail.Location = new System.Drawing.Point(30, 197);
            this.LblEmpEmail.Name = "LblEmpEmail";
            this.LblEmpEmail.Size = new System.Drawing.Size(42, 16);
            this.LblEmpEmail.TabIndex = 0;
            this.LblEmpEmail.Text = "Email";
            // 
            // LblEmpContactPerson
            // 
            this.LblEmpContactPerson.AutoSize = true;
            this.LblEmpContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpContactPerson.Location = new System.Drawing.Point(30, 145);
            this.LblEmpContactPerson.Name = "LblEmpContactPerson";
            this.LblEmpContactPerson.Size = new System.Drawing.Size(99, 16);
            this.LblEmpContactPerson.TabIndex = 0;
            this.LblEmpContactPerson.Text = "Contact Person";
            // 
            // TxtEmpRegistrationNumber
            // 
            this.TxtEmpRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpRegistrationNumber.Location = new System.Drawing.Point(530, 95);
            this.TxtEmpRegistrationNumber.Name = "TxtEmpRegistrationNumber";
            this.TxtEmpRegistrationNumber.Size = new System.Drawing.Size(183, 22);
            this.TxtEmpRegistrationNumber.TabIndex = 1;
            // 
            // LblEmpRegistrationNumber
            // 
            this.LblEmpRegistrationNumber.AutoSize = true;
            this.LblEmpRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpRegistrationNumber.Location = new System.Drawing.Point(413, 98);
            this.LblEmpRegistrationNumber.Name = "LblEmpRegistrationNumber";
            this.LblEmpRegistrationNumber.Size = new System.Drawing.Size(104, 16);
            this.LblEmpRegistrationNumber.TabIndex = 0;
            this.LblEmpRegistrationNumber.Text = "Registration No.";
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpName.Location = new System.Drawing.Point(171, 98);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(183, 22);
            this.TxtEmpName.TabIndex = 1;
            // 
            // LblEmpFName
            // 
            this.LblEmpFName.AutoSize = true;
            this.LblEmpFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpFName.Location = new System.Drawing.Point(30, 101);
            this.LblEmpFName.Name = "LblEmpFName";
            this.LblEmpFName.Size = new System.Drawing.Size(45, 16);
            this.LblEmpFName.TabIndex = 0;
            this.LblEmpFName.Text = "Name";
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
            this.menuStrip1.TabIndex = 5;
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
            this.viewCandidatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCandidatesToolStripMenuItem.Text = "View Candidates";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.viewEmployersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewEmployersToolStripMenuItem.Text = "View Employers";
            // 
            // addEmployerToolStripMenuItem
            // 
            this.addEmployerToolStripMenuItem.Name = "addEmployerToolStripMenuItem";
            this.addEmployerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEmployerToolStripMenuItem.Text = "Add Employer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmEmployerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1240, 505);
            this.Controls.Add(this.PnlCandUpdDel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEmployerRegistration";
            this.Text = "FrmEmployerAddUpdDel";
            this.PnlCandUpdDel.ResumeLayout(false);
            this.PnlCandUpdDel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlCandUpdDel;
        private System.Windows.Forms.Button BtnEmpReg;
        private System.Windows.Forms.Label LblEmpAddress;
        private System.Windows.Forms.TextBox TxtEmpPhone;
        private System.Windows.Forms.Label LblEmpPhone;
        private System.Windows.Forms.TextBox TxtEmpEmail;
        private System.Windows.Forms.TextBox TxtEmpContactPerson;
        private System.Windows.Forms.Label LblEmpEmail;
        private System.Windows.Forms.Label LblEmpContactPerson;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.Label LblEmpFName;
        private System.Windows.Forms.TextBox TxtEmpRegistrationNumber;
        private System.Windows.Forms.Label LblEmpRegistrationNumber;
        private System.Windows.Forms.RichTextBox rTxtAddress;
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