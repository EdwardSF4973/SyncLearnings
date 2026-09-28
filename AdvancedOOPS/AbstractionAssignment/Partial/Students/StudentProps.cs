using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public partial class StudentInfo
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string DOB { get; set; }

        public string MobileNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        partial void CalculatedTotal();

        partial void Percentage();

        public partial void Total();
        public partial void TotalPercentage();
        

        partial void Update(string a);

        public partial void DisUpdate(string a); 

    }
}
