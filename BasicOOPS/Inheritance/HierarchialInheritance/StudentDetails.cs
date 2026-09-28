using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HierarchialInheritance
{
    public class StudentDetails : AadharRegistration
    {
        private static int s_studentID=0;

        public int StudentID { get;  }

        public string Standard { get; set; }

        public StudentDetails(){}

        public StudentDetails(int birthRegistrationID, int aadharID, string name , string fatherName, string registrationDate, string birthDate, string gender, string address, string standard) : base(birthRegistrationID,aadharID, name,fatherName, registrationDate,birthDate,gender,address)   
        {
            s_studentID++;
            StudentID = s_studentID;
            Standard = standard;
        }

        public string DisplayStudentDetails()
        {
            return $"Student ID: {StudentID},{DisplayAadharRegistration()},Standard : {Standard}";
        }
    }
}