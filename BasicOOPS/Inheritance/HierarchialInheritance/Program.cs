using System;

namespace HierarchialInheritance;

class Program
{
    public static void Main(string[] args)
    {
        BirthRegistration br = new BirthRegistration("John","Doe","11/11/2002","19/11/2002","male");
        Console.WriteLine(br.DisplayBirthRegistration());


        AadharRegistration ar = new AadharRegistration(1234,"Ravi","chandran","01/01/2022","01/01/2020","male","123mainstreet");
        Console.WriteLine(ar.DisplayAadharRegistration());

        StudentDetails student = new StudentDetails(1234,1456,"Edward","George","21/11/2002","19/11/2002","male","Chennai","JOB");
        Console.WriteLine(student.DisplayStudentDetails());

        VoteRegistration voter = new VoteRegistration(1234,4567,"Dayalan","Loganathan","18/08/2002","15/08/2002","male","Kancheepuram","Kanchi");
        Console.WriteLine(voter.DisplayVoterDetails());



    }
}
