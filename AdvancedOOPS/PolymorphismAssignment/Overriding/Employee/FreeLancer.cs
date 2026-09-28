using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Employee
{
    public class FreeLancer : PersonDetails
    {
        public string ProfileID { get; set; }

        public string Role { get; set; }

        public double SalaryAmount { get; set; }

        public int NoOfWorkingDays { get; set; }

        public FreeLancer(string pID,string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            ProfileID = pID;
            Role = role;
            NoOfWorkingDays = noOfWorkingDays;
        }

        public virtual void CalculateSalary()
        {
            SalaryAmount = NoOfWorkingDays*500;
            System.Console.WriteLine($"Your Salary is {SalaryAmount}");
        }
        
    }
}

