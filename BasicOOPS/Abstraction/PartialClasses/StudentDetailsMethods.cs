using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class StudentDetails
    {
        partial void ShowDetails()
        {
            System.Console.WriteLine("Name "+Name);
            System.Console.WriteLine("Age "+Age);
            System.Console.WriteLine("PhoneNumber "+PhoneNumber);

        }
        public partial void ShowStudentDetails()
        {
            ShowDetails();
            //System.Console.WriteLine("Name "+Name);
            //System.Console.WriteLine("Age "+Age);
            //System.Console.WriteLine("PhoneNumber "+PhoneNumber);
        }
    }
}