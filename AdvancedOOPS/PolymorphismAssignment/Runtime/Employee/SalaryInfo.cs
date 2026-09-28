using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    public class SalaryInfo : EmployeeInfo
    {
        private static int s_salaryID =90;

        public string SalaryID { get; set; }

        public int NumberOfDaysWorked { get; set; }

        public SalaryInfo(){}

        public SalaryInfo(string empID,string name,string fatherName,string mobileNumber,string gender,string officeLocation,int now):base(empID,name,fatherName,mobileNumber,gender,officeLocation)
        {
            NumberOfDaysWorked=now;
        }

        public override void Update(string a)
        {
            OfficeLocation=a;
        }

        public double CalculatedSalary()
        {
            return NumberOfDaysWorked*500;
        }
    }
}
