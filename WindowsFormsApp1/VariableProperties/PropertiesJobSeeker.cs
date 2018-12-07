using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableProperties
{
    public class PropertiesJobSeeker
    {
        public string FirstName, LastName, Gender, Email, Mobile, Qualification;
        public int Age;

        public string FName
        {
            set { FirstName = value; }
            get { return FirstName; }
        }
        public string LName
        {
            set { LastName = value; }
            get { return LastName; }
        }
        public string CGender
        {
            set { Gender = value; }
            get { return Gender; }
        }
        public string CEmail
        {
            set { Email = value; }
            get { return Email; }
        }
        public string CMobile
        {
            set { Mobile = value; }
            get { return Mobile; }
        }
        public string CQualification
        {
            set { Qualification = value; }
            get { return Qualification; }
        }
        public int CAge
        {
            set { Age = value; }
            get { return Age; }
        }
    }
}
