using System;


namespace MultipleInheritance
{
    public class VoteRegistration : AadharRegistration
    {
        private static int s_voterId = 0;

        public int VoterID { get; }

        public string AssemblyConstituency { get; set; }

        public VoteRegistration(){}

        public VoteRegistration(int birthRegistrationID,int aadharID,string name, string fatherName, string registrationDate,string birthDate,string gender,string address,string assemblyConstituency):base(birthRegistrationID,aadharID,name,fatherName,registrationDate,birthDate,gender,address)
        {
            s_voterId++;
            VoterID = s_voterId;
            AssemblyConstituency = assemblyConstituency;
        }

        public string DisplayVoterDetails()
        {
            return $"Voter ID: {VoterID} , {DisplayAadharRegistration()},AssemblyConstituency : {AssemblyConstituency}";
        }


        
    }
}