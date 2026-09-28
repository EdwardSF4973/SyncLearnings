using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emplouyee
{
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public string Mail { get; set; }

        public string Gender { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name,string fatherName,string mobile,string gender,string mail)
        {
            Name =name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail = mail;
            Gender=gender;

        }

        public void UpdateInfo(string a)
        {
            Mobile=a;
        }
    }
}
