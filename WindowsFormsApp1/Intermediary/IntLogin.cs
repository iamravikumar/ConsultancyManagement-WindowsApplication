using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using VariableProperties;

namespace Intermediary
{
    
    public class IntLogin
    {
        DA_Login dLogin;
        public int IntChkLogin(PropertiesLogin propertiesLogin)
        {
            dLogin = new DA_Login();
            int flg = dLogin.CheckLogin(propertiesLogin);
            return flg;
        }
    }
}
