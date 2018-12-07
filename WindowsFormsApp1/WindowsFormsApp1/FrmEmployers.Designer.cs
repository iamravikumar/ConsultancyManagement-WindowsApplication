namespace WindowsFormsApp1
{
    partial class FrmEmployers
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
            this.LnLblEmployerView = new System.Windows.Forms.LinkLabel();
            this.LnLblEmployerRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LnLblEmployerView
            // 
            this.LnLblEmployerView.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblEmployerView.AutoSize = true;
            this.LnLblEmployerView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblEmployerView.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblEmployerView.Location = new System.Drawing.Point(256, 155);
            this.LnLblEmployerView.Name = "LnLblEmployerView";
            this.LnLblEmployerView.Size = new System.Drawing.Size(142, 25);
            this.LnLblEmployerView.TabIndex = 1;
            this.LnLblEmployerView.TabStop = true;
            this.LnLblEmployerView.Text = "Employer View";
            this.LnLblEmployerView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblEmployerView_LinkClicked);
            // 
            // LnLblEmployerRegistration
            // 
            this.LnLblEmployerRegistration.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnLblEmployerRegistration.AutoSize = true;
            this.LnLblEmployerRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnLblEmployerRegistration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnLblEmployerRegistration.Location = new System.Drawing.Point(256, 97);
            this.LnLblEmployerRegistration.Name = "LnLblEmployerRegistration";
            this.LnLblEmployerRegistration.Size = new System.Drawing.Size(201, 25);
            this.LnLblEmployerRegistration.TabIndex = 2;
            this.LnLblEmployerRegistration.TabStop = true;
            this.LnLblEmployerRegistration.Text = "Employer Registration";
            this.LnLblEmployerRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnLblEmployerRegistration_LinkClicked);
            // 
            // FrmEmployers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LnLblEmployerView);
            this.Controls.Add(this.LnLblEmployerRegistration);
            this.Name = "FrmEmployers";
            this.Text = "FrmEmployers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnLblEmployerView;
        private System.Windows.Forms.LinkLabel LnLblEmployerRegistration;
    }
}