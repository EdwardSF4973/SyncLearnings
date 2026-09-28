using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public class SBI : Bank
    {
        public override double GetIntresetInfo()
        {
            return 7.5;
        }

    }
}
/*
2.	Banking Appliacation

a.	 Create an abstract class Name Bank 

b.	That have an abstract method double return type GetIntresetInfo

c.	Create a class SBI and override GetIntresetInfo method and return 7.5%.

d.	Create a class ICICI and override GetIntresetInfo method and return 7.5%.

e.	Create a class HDFC and override GetIntresetInfo method and return 7.5%.

f.	Create a class IDBI and override GetIntresetInfo method and return 7.5%.
•	Declare object for bank class
•	Assign SBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
•	Assign ICICI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
•	Assign HDFC class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
•	Assign IDBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
Requirement: Create objects for the above classes and call GetIntrestInfo methods and display the results 

*/