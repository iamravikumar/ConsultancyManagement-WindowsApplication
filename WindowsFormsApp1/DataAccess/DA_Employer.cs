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
    public class DA_Employer
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DUCATPROJECT_CONSULTANCY_ERPConnectionString"].ConnectionString;

        public void InsertEmployer(PropertiesEmployer propertiesEmployer)
        {
            SqlConnection connection = new SqlConnection(ConStr);
            string qry = "SP_INSERT_EMPLOYER";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = qry;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NAME", propertiesEmployer._Name);
            command.Parameters.AddWithValue("@REGISTRATION_NUMBER", propertiesEmployer._RegistrationNumber);
            command.Parameters.AddWithValue("@CONTACT_PERSON", propertiesEmployer._ContactPerson);
            command.Parameters.AddWithValue("@PHONE", propertiesEmployer._Phone);
            command.Parameters.AddWithValue("@EMAIL", propertiesEmployer._Email);
            command.Parameters.AddWithValue("@ADDRESS_LOCATION", propertiesEmployer._AddressLocation);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ViewEmployer()
        {
            SqlConnection conn = new SqlConnection(ConStr);
            string qry = "SELECT * FROM EMPLOYER_DETAILS";
            SqlCommand cmd = new SqlCommand(qry, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
