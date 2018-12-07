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
    public partial class FrmEmployerView : Form
    {
        public FrmEmployerView()
        {
            InitializeComponent();
        }

        private void FrmEmployerView_Load(object sender, EventArgs e)
        {
            IntEmployer intEmployer = new IntEmployer();
            DataTable dt = intEmployer.ViewEmployerGrid();
            if (dt.Rows.Count > 0)
            {
                dGVEmployerView.DataSource = dt;
            }
        }
    }
}
