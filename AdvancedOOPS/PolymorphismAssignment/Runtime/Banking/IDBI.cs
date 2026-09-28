using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public class IDBI : SBI
    {
        public override double GetIntresetInfo()
        {
            return 7.5;
        }
    }
}