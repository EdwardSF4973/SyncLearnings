using System;
using System.Reflection.Metadata;

namespace JobApplication;

class Program
{
    public static void Main(string[] args)
    {
        UGInfo info1 = new(1234,"BE","gt","edwad","male","8523","t6gr","ergerg","rfgvsef","ergerg",[45,66,33,99,88,55],[11,22,33,44,55,66],[85,96,4,23,66,55],[44,55,22,33,66,11]);
        System.Console.WriteLine(info1.GetUGMarksheetData());
        System.Console.WriteLine(info1.IsEligibility());

        RegisterApplication reg1 = new (1231223,45,"Data",8569,"BE","CSE","Edward","Edward","19/11/2002","7305541054","George","Hepsiba","Chennai",[75,65,33,99,44,55],[88,99,52,44,66,0],[44,65,56,33,44,77],[74,52,63,41,96,45]);
        System.Console.WriteLine(reg1.DispalyDetails());
        System.Console.WriteLine(reg1.IsEligibility());
        System.Console.WriteLine(reg1.GetUGMarksheetData());
        
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