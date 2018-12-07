using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Intermediary;

namespace WindowsFormsApp1
{
    public partial class FrmCandidateView : Form
    {
        public FrmCandidateView()
        {
            InitializeComponent();
        }

        private void FrmCandidateView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dUCATPROJECT_CONSULTANCY_ERPDataSet.JOB_SEEKER_DETAILS' table. You can move, or remove it, as needed.
            //this.jOB_SEEKER_DETAILSTableAdapter.Fill(this.dUCATPROJECT_CONSULTANCY_ERPDataSet.JOB_SEEKER_DETAILS);

            IntJobSeeker intJobSeeker = new IntJobSeeker();
            DataTable dt = intJobSeeker.ViewData();
            if (dt.Rows.Count > 0)
            {
                dGVCandidateView.DataSource = dt;
                
            }

            //dGVCandidateView.AutoResizeColumns(dGVCandidateView.ColumnHeader);
        }
    }
}
