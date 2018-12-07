using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableProperties
{
    public class PropertiesLogin
    {
        string username, password;

        public string UserName
        {
            set { username = value; }
            get { return username; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
    }
}
