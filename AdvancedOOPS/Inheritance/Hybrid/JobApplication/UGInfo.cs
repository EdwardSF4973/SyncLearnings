using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication
{
    public class UGInfo :PersonalInfo,IMarkDetails
    {
        public int UGMarksheetNumber { get; set; }

        public string Degree { get; set; }

        public string Branch { get; set; }
        public int[] Sem1{get;set;}

        public int[] Sem2 { get; set; }

        public int[] Sem3 { get; set; }

        public int[] Sem4 { get; set; } 

        // public UGInfo(){}
        public UGInfo(int ugMarkNumber,string degree,string branch,string name,string gender,string dob,string mobile,string fatherName,string motherName,string permanentAddress,int[] sem1,int[] sem2,int[] sem3,int[]sem4):base(name,gender,dob,mobile,fatherName,motherName,permanentAddress)
        {
            UGMarksheetNumber = ugMarkNumber;
            Degree=degree;
            Branch = branch;
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;

        
        }
        // public UGInfo(int ugMarkNumber,string degree,string branch,string name,string gender,string dob,string mobile,string fatherName,string motherName,string permanentAddress,int[] sem1,int[] sem2,int[] sem3,int[]sem4):base(name,gender,dob,mobile,fatherName,motherName,permanentAddress)
        // {
        //     UGMarksheetNumber = ugMarkNumber;
        //     Degree=degree;
        //     Branch = branch;
        //     Sem1 = sem1;
        //     Sem2 = sem2;
        //     Sem3 = sem3;
        //     Sem4 = sem4;

        
        // }
        public double Total(int[] a)
        {
            double sum = 0;
            foreach(int num in a)
            {
                sum+=num;
            }
            return sum;
        }
        public double Percentage(int [] a)
        {
            double sum = 0;
            foreach(int num in a)
            {
                sum+=num;
            }
            sum =  sum/600;
            return sum*100;
        }







        public string IsEligibility()
        {
            bool temp;
            if(Percentage(Sem1)>=75 && Percentage(Sem2)>=75 && Percentage(Sem3)>=75 && Percentage(Sem4)>=75 )
            {
                temp= true;
            }
            temp= false;
            if(temp)
            {
                return "you're Eligible";
            }
            return "You're not Eligible";
            
        }
        public string GetUGMarksheetData()
        {
            return $"UGMarkSheetNumber : {UGMarksheetNumber}, Name : {Name}, FatherName : {FatherName}, MotherName : {MotherName}\nDegree : {Degree},ISEligibility : {IsEligibility()} \nAddress : {PermanantAddress}, Gender : {Gender}";
        }


        
    }
}

/*3.	Create a program to implement Job Application Portal Create 2 registration for this application.

Interface IFamilyInfo:
Properties: FatherName,MotherName, PermanantAddress

Class: PersonalInfo : IFamilyInfo
Properties: Name, Gender, DOB, phone, mobile

Interface IMarkDetails
Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.

Class UGInfo: Inhertis PersonalInfo, IMarkDetails
Properties: UGMarksheet Num, Degree, Branch, Sem1[], Sem2[], Sem3[], Sem4[] Marks
Method: GetUGMarksheetData, CheckEligiblity ->75% and above in all semester

Class RegisterApplication inherits UGInfo
Properties: RegisterNumber, Experience in Months, FieldOfIntrest
Methods: Show Details
*/