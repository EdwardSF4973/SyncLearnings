using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient
{
    public sealed class PatientInfo
    {
        public string PatientID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string BedNo { get; set; }

        public string NativePlace { get; set; }

        public string AdmittedFor { get; set; }

        

        public PatientInfo(string pID,string name,string fName,string bN,string nativePlace,string addmitteddFor)
        {
            PatientID=pID;
            Name = name;
            FatherName=fName;
            BedNo=bN;
            NativePlace=nativePlace;
            AdmittedFor=addmitteddFor;
        }

        public void UpdateInfo(string a)
        {
            AdmittedFor=a;
        }

        public void Display()
        {
            System.Console.WriteLine($"PatientID : {PatientID}, Name : {Name}, FatherName : {FatherName}, BEDNO : {BedNo}, Native Place : {NativePlace}");
        }
    }
}
