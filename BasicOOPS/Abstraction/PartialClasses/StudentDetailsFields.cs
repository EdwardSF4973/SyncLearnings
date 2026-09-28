using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class StudentDetails
    {
        private static int s_studentID=1000;

        private static double _balance;

        partial void ShowDetails();
        
        public partial void ShowStudentDetails();
    }
}