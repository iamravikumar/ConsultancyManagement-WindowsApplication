using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DataAccess;
using VariableProperties;

namespace Intermediary
{
    public class IntJobSeeker
    {
        public void AddCandidate(PropertiesJobSeeker jobSeeker)
        {
            DA_JobSeeker dA_JobSeeker = new DA_JobSeeker();
            dA_JobSeeker.InsertCandidate(jobSeeker);
        }

        public DataTable ViewData()
        {
            DA_JobSeeker dA_JobSeeker = new DA_JobSeeker();
            DataTable dt = dA_JobSeeker.FillGrid();
            return dt;
        }
    }
    
}
