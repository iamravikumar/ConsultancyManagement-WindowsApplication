using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using VariableProperties;
using DataAccess;

namespace Intermediary
{
    public class IntEmployer
    {
        public void AddEmployer(PropertiesEmployer propertiesEmployer)
        {
            DA_Employer dA_Employer = new DA_Employer();
            dA_Employer.InsertEmployer(propertiesEmployer);
        }

        public DataTable ViewEmployerGrid()
        {
            DA_Employer dA_Employer = new DA_Employer();
            DataTable dt = dA_Employer.ViewEmployer();
            return dt;
        }
    }
}
