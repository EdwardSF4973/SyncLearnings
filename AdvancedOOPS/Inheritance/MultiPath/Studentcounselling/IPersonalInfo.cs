using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentcounselling
{
    public interface IPersonalInfo
    {
        public int AadharNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Phone { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }
        
    }
}
