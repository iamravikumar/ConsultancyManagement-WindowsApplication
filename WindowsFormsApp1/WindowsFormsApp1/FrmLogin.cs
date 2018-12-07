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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        PropertiesLogin PLogin;
        IntLogin ILogin;
        
        private FrmOptions fro;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            PLogin = new PropertiesLogin();
            ILogin = new IntLogin();
            
            fro = new FrmOptions();

            if (TxtUsername.Text != string.Empty && TxtPassword.Text != string.Empty)
            {                
                PLogin.UserName = TxtUsername.Text;
                PLogin.Password = TxtPassword.Text;
                int fl = ILogin.IntChkLogin(PLogin);
                if (fl == 1)
                {
                    //MessageBox.Show("Login Successful");                    
                    this.Hide();
                    fro.Show();
                }
                else
                {
                    MessageBox.Show("Access denied");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
