using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient
{
    public class DoctorInfo : PatientInfo
    {
        public string DoctorID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }
        
    }
}

/*
2.	Create an application for patient detail manipulation
Sealed Class PatientInfo:
Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
Method: UpdateInfo

Class DoctorInfo: Inherit PatientInfo
Properties: DoctorID, Name, FatherName
Methods: UpdateInfo
Requirement :
•	Create a patient object and display his info
•	Create a doctor object and display info
•	Check PatientInfo class is inheritable

*/