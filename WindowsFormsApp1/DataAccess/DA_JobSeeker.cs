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
    public class DA_JobSeeker
    {
        public string CnStr = ConfigurationManager.ConnectionStrings["DUCATPROJECT_CONSULTANCY_ERPConnectionString"].ConnectionString;
                
        public void InsertCandidate(PropertiesJobSeeker jobSeeker)
        {
            SqlConnection conn = new SqlConnection(CnStr);
            string qry = "SP_INSERT_JOBSEEKER";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = qry;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FNAME", jobSeeker.FName);
            cmd.Parameters.AddWithValue("@LNAME", jobSeeker.LName);
            cmd.Parameters.AddWithValue("@AGE", jobSeeker.CAge);
            cmd.Parameters.AddWithValue("@GENDER", jobSeeker.CGender);
            cmd.Parameters.AddWithValue("@EMAIL", jobSeeker.CEmail);
            cmd.Parameters.AddWithValue("@MOBILE", jobSeeker.CMobile);
            cmd.Parameters.AddWithValue("@HQLF", jobSeeker.CQualification);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public  DataTable FillGrid()
        {
            SqlConnection conn = new SqlConnection(CnStr);
            string qry = "SELECT * FROM JOB_SEEKER_DETAILS";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
