using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class DoctorDetails : PersonalDetails
    {
        private static int s_doctorID = 300;

        public string DoctorID { get; set; }

        public int Experience { get; set; }

        public string Specialization { get; set; }

        public double Fees { get; set; }


        

        public DoctorDetails(string name,string fatherName,Genders gender,string phone,int age,string bloodGroup,int exper,string special,double fees): base(name,fatherName,gender,phone,age,bloodGroup)
        {
            DoctorID = $"DID{++s_doctorID}";
            Experience=exper;
            Specialization = special;
            Fees=fees;
        }
        
    }
}
/*
•	DoctorID (Auto Increment – DID 300)
•	Experience
•	Specialization
•	Fees

*/