using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentcounselling
{
    public interface IUGInfo : IPersonalInfo
    {
        public int UGMarksheetNumber { get; set; }

        public double Sem1Mark { get; set; }
        public double Sem2Mark { get; set; }
        public double Sem3Mark { get; set; }
        public double Sem4Mark { get; set; }

        public double UGTotal { get; set; }

        public double UGPercentage { get; set; }

        public double Total();

        public double Percentage();
        
    }
}
