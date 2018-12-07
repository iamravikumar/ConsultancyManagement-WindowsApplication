using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using VariableProperties;

namespace DataAccess
{
    public class DA_Login
    {
        
        int flag;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        

        public int CheckLogin(PropertiesLogin PL)
        {
            flag = 0;
            ConnectionSetting();
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if(PL.UserName==ds.Tables[0].Rows[i][0].ToString() && PL.Password == ds.Tables[0].Rows[i][1].ToString())
                {
                    flag = 1;                    
                }                
            }
            return flag;
        }

        public void ConnectionSetting()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["DUCATPROJECT_CONSULTANCY_ERPConnectionString"].ConnectionString;
            string qry = "SELECT * FROM LOGIN_DETAILS";
            conn = new SqlConnection(ConnString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qry;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
        }
    }
}
