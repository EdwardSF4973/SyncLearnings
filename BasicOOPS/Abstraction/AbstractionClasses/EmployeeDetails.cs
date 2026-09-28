using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionClasses
{
    public abstract class EmployeeDetails
    {
        private static int s_employeeID =1000;//normal field

        public string EmployeeID {get; set;}//normal property

        public string EmployeeName { get; set; }//normal property

        public abstract string EmployeeDesignation { get; set; }

        public EmployeeDetails(string employeeID, string employeeName)
        {
            
            EmployeeID=$"EID{++s_employeeID}";
            EmployeeName=employeeName;
        }

    }
}