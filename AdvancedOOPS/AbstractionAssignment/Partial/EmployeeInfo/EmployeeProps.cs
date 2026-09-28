using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeDetails
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string DOB { get; set; }

        public string Mobile { get; set; }

        partial void Update(string temp);

        public partial void MobileUpdate(string a);

        
    }
}
