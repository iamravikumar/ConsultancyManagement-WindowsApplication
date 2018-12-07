using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VariableProperties;
using Intermediary;


namespace WindowsFormsApp1
{
    public partial class FrmCandidateRegistration : Form
    {
        public FrmCandidateRegistration()
        {
            InitializeComponent();
        }

        PropertiesJobSeeker pjobSeeker;
        IntJobSeeker intJobSeeker;

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            pjobSeeker = new PropertiesJobSeeker();
            intJobSeeker = new IntJobSeeker();
            if (TxtFName.Text != string.Empty && TxtLName.Text != string.Empty && TxtAge.Text != string.Empty && TxtGender.Text != string.Empty && TxtMobile.Text != string.Empty && TxtQualification.Text != string.Empty)
            {
                pjobSeeker.FName = TxtFName.Text;
                pjobSeeker.LName = TxtLName.Text;
                pjobSeeker.CAge = Convert.ToInt32(TxtAge.Text);
                pjobSeeker.CGender = TxtGender.Text;
                pjobSeeker.CEmail = TxtEmail.Text;
                pjobSeeker.CMobile = TxtMobile.Text;
                pjobSeeker.CQualification = TxtQualification.Text;
                intJobSeeker.AddCandidate(pjobSeeker);
                MessageBox.Show("Record Added");
            }
            else
            {
                MessageBox.Show("Enter all values");
            }
        }
    }
}
