using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public partial class StudentInfo
    {
        partial void CalculatedTotal()
        {
            int total = Physics+Chemistry+Maths;
            System.Console.WriteLine(total);
        }
        partial void Percentage()
        {
            double total = Physics+Chemistry+Maths;
            total = (double)total/300;
            System.Console.WriteLine(total*100);

        }

        public partial void Total()
        {
            CalculatedTotal();
        }

        public partial void TotalPercentage()
        {
            Percentage();
        }



        partial void Update(string a)
        {
            MobileNumber = a;
        }

        public partial void DisUpdate(string a)
        {
            Update(a);
        }
    }
}
