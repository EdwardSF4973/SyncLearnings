using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Studentcounselling
{
    public class PGCouncelling :IHSCInfo,IUGInfo
    {
        public int ApplicationID { get; set; }

        public string DateOfApplication { get; set; }

        private bool _feeStatus = false;

        public bool FeeStatus { get{return _feeStatus;} }

        public int HSCMarksheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public double HSCTotal { get; set; }

        public double HSCPercentage { get; set; }

        public int AadharNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Phone { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public int UGMarksheetNumber { get; set; }

        public double Sem1Mark { get; set; }
        public double Sem2Mark { get; set; }
        public double Sem3Mark { get; set; }
        public double Sem4Mark { get; set; }

        public double UGTotal { get; set; }

        public double UGPercentage { get; set; }

        public PGCouncelling(int applicationID, string doa,int hscMarksheetNumber,int physics,int chemistry,int maths,int aadharNumber,string name,string fatherName,string phone,string dob,string gender,int ugMarksheetNumber,double sem1Mark,double sem2Mark,double sem3Mark,double sem4Mark)
        {
            ApplicationID = applicationID;
            DateOfApplication = doa;
            HSCMarksheetNumber = hscMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            AadharNumber = aadharNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
            UGMarksheetNumber = ugMarksheetNumber;
            Sem1Mark = sem1Mark;
            Sem2Mark = sem2Mark;
            Sem3Mark = sem3Mark;
            Sem4Mark = sem4Mark;

        }

        public double HSCMarkTotal()
        {
            double totalhsc =(double) Physics + Chemistry + Maths;
            HSCTotal = totalhsc;
            return totalhsc;

        }

        public double HSCMarkPercentage()
        {
            double percent = (double)(HSCTotal/300)*100;
            HSCPercentage = percent;
            return percent;
        }
        public double Total()
        {
            double total = (double)Sem1Mark+Sem2Mark+Sem3Mark+Sem4Mark;
            UGTotal = total;
            return total;
        }
        public double Percentage()
        {
            double percent = (double)UGTotal/400;
            UGPercentage = (double)percent*100;
            return percent*100;


        }

        public void Payfees(string ask)
        {
            if(ask.ToUpper() == "YES")
            {
                _feeStatus = true;
            }
        }
        
    }
}
/*
1.	Create an application to handle student Counselling information
 
Interface IPersonalInfo:
Properties: AadharNumber, Name, FatherName, Phone, DOB, Gender

Interface IHSCInfo: Inherits IPersonalInfo
Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, HSCTotal, HSCPercentage
Methods: CalculateHSC -> Total, percentage.

Interface IUGInfo: Inhertis IPersonalInfo
Properties: UGMarksheetNumber, Sem1Mark, Sem2Mark, Sem3Mark, Sem4Mark, UGTotal and UGPercentage
Methods: CalculateUG -> Total, percentage.

Class PGCouncelling inherits IHSCInfo, IUGInfo
Properties: ApplicationID, DateOfApplication, FeeStatus (bool).
Method: PayFees ->500 Rs. 


 Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details calculate Total and Percentage using CalculateUG. Have to get fees and using PayFee method check the fees given is 500rs if yes then set FeeStatus.

*/