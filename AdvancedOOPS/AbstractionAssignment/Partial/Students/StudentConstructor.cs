using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public partial class StudentInfo
    {
        public StudentInfo()
        {

        }
        public StudentInfo(int studID,string name,string gender,string dob,string mobile,int phy, int che,int mat)
        {
            StudentID = studID;
            Name = name;
            Gender = gender;
            DOB = dob;
            MobileNumber = mobile;
            Physics = phy;
            Chemistry = che;
            Maths = mat;
        }
    }
}
