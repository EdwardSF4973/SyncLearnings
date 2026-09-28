using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionClasses
{
    public class TCS : EmployeeDetails
    {
        public override string EmployeeDesignaion {set; get;}

        public TCS(string employeeId, string employeeName,string employeeDesignation):base(employeeId,employeeName)
        {   
            EmployeeDesignaion = employeeDesignation;
        }
        
    }
}