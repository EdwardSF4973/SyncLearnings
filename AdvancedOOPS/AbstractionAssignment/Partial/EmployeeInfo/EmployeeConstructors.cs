using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeDetails
    {
        public EmployeeDetails()
        {

        }
        public EmployeeDetails(int empID,string name,string gender,string dob,string mobile)
        {
            EmployeeID = empID;
            Name = name;
            Gender = gender;
            DOB =dob;
            Mobile = mobile;
        }
    }
}
