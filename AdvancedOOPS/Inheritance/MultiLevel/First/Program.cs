using System;
using System.Runtime.ConstrainedExecution;

namespace First;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person = new ("Edward","George","75239541","asdfghjk",new DateTime(2002,11,19),"male");
        System.Console.WriteLine(person.DisplayPersonalInfo());

        StudentDetails student = new(123,"Eleventh","CSE",2025,"Leeba","Ebinezer","856325863","aqwsdftyhgfds",new DateTime(2006,02,10),"Female");
        System.Console.WriteLine(student.DispalyStudent());
        
        HSCDetails sheet = new(90,85,56,123,456,"Eight","Cse",2022,"Naveen","Sekar","65as46","sdafs",new DateTime(2015,04,22),"male");
        System.Console.WriteLine(sheet.DisplayHSC());

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