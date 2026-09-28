using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class HSCDetails : StudentDetails
    {
        private static int s_hscMarksheetID = 4000;
        public int HSCMarksheetID { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public int Total { get{return TotalMark();} }

        public int Percentage{ get{return PercentageOfMark();}}

        public HSCDetails(){}

        public HSCDetails(int physics,int chemistry,int maths,int registrationID,int userID,string standard,string branch, int acadamicYear, string name, string fatherName, string mobileNumber, string mailID, DateTime dob, string gender):base(registrationID,userID,standard,branch,acadamicYear,name,fatherName,mobileNumber,mailID,dob,gender)

        {
            HSCMarksheetID = ++s_hscMarksheetID;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
        public int TotalMark()
        {
            return Physics+Chemistry+Maths; 
        }
        public int PercentageOfMark()
        {
            return TotalMark()/300;
        }
        public string DisplayHSC()
        {
            return $"HSCMarksheetID : {HSCMarksheetID}, PhysicsMark : {Physics}, ChemistryMark : {Chemistry}, MathsMark : {Maths},Total : {Total}, Percentage: {Percentage}, {DispalyStudent()}, \n\n{DisplayPersonalInfo()}";
        }
    }

    
}
/*
1.	Program for getting showing student details:

Class PersonalInfo:
Properties: UserID, Name, FatherName,Phone,Mail, dob,Gender
Constructor to assign values

Class StudentInfo: inherits PersonalInfo
Propeties: RegistrationID, Standard, Branch, AcadamicYear


Class HSCDetails: Inherits StudentInfo
Properties: HSCMarksheetID, Physics, Chemistry, Maths, Total, Percentage marks
Methods:  Calculate – Total and percentage.
Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details and have to calculate total and percentage and have to display the details.

*/