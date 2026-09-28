using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public enum AppointmentStatus{Default,Booked,Cancelled}
    public class AppointmentDetails
    {

        private static int s_appointmentID = 500;

        public string AppointMantID { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string AppointmentSlot { get; set; }

        public AppointmentStatus AppointmentState { get; set; }

        public double Fees { get; set; }

        public AppointmentDetails(string pID,string dID,DateTime aD,string aS,AppointmentStatus apSt,double fees)
        {
            AppointMantID = $"AID{++s_appointmentID}";
            PatientID = pID;
            DoctorID = dID;
            AppointmentDate = aD;
            AppointmentSlot = aS;
            AppointmentState = apSt;
            Fees = fees;
        }
        
    }
}
