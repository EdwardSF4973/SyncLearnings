using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeDetails
    {
        partial void Update(string temp )
        {
            Mobile = temp;
            
        }
        public partial void MobileUpdate(string a)
        {
            Update(a);
        }
    }
}
