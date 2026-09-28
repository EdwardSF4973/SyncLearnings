using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class AvailableSlotDetails
    {
        public string DoctorID { get; set; }

        private static int s_slotID = 300;
        public string SlotID { get; set; }
 
        public string SlotTime { get; set; }

        public AvailableSlotDetails(){}

        public AvailableSlotDetails(string doctorID,string slotTime)
        {
            SlotID = $"SL{++s_slotID}";
            DoctorID = doctorID;
            SlotTime = slotTime;
        }
 
 
 
 
 
 
    }


}