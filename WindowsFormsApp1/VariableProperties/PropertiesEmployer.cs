using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableProperties
{
    public class PropertiesEmployer
    {
        string Name, RegistrationNumber, ContactPerson, Phone, Email, AddressLocation;

        public string _Name
        {
            set { Name = value; }
            get { return Name; }
        }
        public string _RegistrationNumber
        {
            set { RegistrationNumber = value; }
            get { return RegistrationNumber; }
        }
        public string _ContactPerson
        {
            set { ContactPerson = value; }
            get { return ContactPerson; }
        }
        public string _Phone
        {
            set { Phone = value; }
            get { return Phone; }
        }
        public string _Email
        {
            set { Email = value; }
            get { return Email; }
        }
        public string _AddressLocation
        {
            set { AddressLocation = value; }
            get { return AddressLocation; }
        }
    }
}
