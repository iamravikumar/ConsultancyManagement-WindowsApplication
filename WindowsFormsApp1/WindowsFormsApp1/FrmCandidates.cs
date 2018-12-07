using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCandidates : Form
    {
        public FrmCandidates()
        {
            InitializeComponent();
        }

        private void LnLblCandidateRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCandidateRegistration candidateRegistration = new FrmCandidateRegistration();
            candidateRegistration.Show();
        }

        private void LnLblCandidateView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCandidateView candidateView = new FrmCandidateView();
            candidateView.Show();
        }
    }
}
