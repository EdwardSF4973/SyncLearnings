using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentcounselling
{
    public interface IHSCInfo : IPersonalInfo
    {
        public int HSCMarksheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public double HSCTotal { get; set; }

        public double HSCPercentage { get; set; }

        public double HSCMarkTotal();

        public double HSCMarkPercentage();
        
        
    }
}
