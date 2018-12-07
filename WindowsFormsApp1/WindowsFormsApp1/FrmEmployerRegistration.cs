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
    public partial class FrmEmployerRegistration : Form
    {
        public FrmEmployerRegistration()
        {
            InitializeComponent();
        }

        private void BtnEmpReg_Click(object sender, EventArgs e)
        {
            IntEmployer intEmployer = new IntEmployer();
            PropertiesEmployer propertiesEmployer = new PropertiesEmployer();
            if (TxtEmpName.Text != string.Empty && TxtEmpRegistrationNumber.Text != string.Empty && TxtEmpContactPerson.Text != string.Empty && TxtEmpPhone.Text != string.Empty && TxtEmpEmail.Text != string.Empty && rTxtAddress.Text != string.Empty)
            {
                propertiesEmployer._Name = TxtEmpName.Text;
                propertiesEmployer._RegistrationNumber = TxtEmpRegistrationNumber.Text;
                propertiesEmployer._ContactPerson = TxtEmpContactPerson.Text;
                propertiesEmployer._Phone = TxtEmpPhone.Text;
                propertiesEmployer._Email = TxtEmpEmail.Text;
                propertiesEmployer._AddressLocation = rTxtAddress.Text;
                intEmployer.AddEmployer(propertiesEmployer);
                MessageBox.Show("Record added.");
            }
            else
            {
                MessageBox.Show("No values should be empty.");
            }
        }
    }
}
