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
    public partial class FrmEmployers : Form
    {
        public FrmEmployers()
        {
            InitializeComponent();
        }

        private void LnLblEmployerRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmEmployerRegistration frmEmployerRegistration = new FrmEmployerRegistration();
            frmEmployerRegistration.Show();
        }

        private void LnLblEmployerView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmEmployerView frmEmployerView = new FrmEmployerView();
            frmEmployerView.Show();
        }
    }
}
