using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class StudentDetails
    {
        public StudentDetails()
        {

        }
        public StudentDetails(string name, int age, string phoneNumber)
        {
            Name =name;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}