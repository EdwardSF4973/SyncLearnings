using System;

namespace SingleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        BirthRegistration br = new BirthRegistration("John","Doe","11/11/2002","19/11/2002","male");
        Console.WriteLine(br.DisplayBirthRegistration());


        AadharRegistration ar = new AadharRegistration(1234,"Ravi","chandran","01/01/2022","01/01/2020","male","123mainstreet");
        Console.WriteLine(ar.DisplayAadharRegistration());



    }
}
