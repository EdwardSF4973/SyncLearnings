using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class Attendance
    {

        private int _workingDays;

        private int _leaveTaken;

        private int _permision;



       
        
       public Attendance(int workingDays, int leaveTaken, int permission)
        {
            _workingDays = workingDays;
            _leaveTaken = leaveTaken;
            _permision =  permission;
        }

        public static Attendance operator +(Attendance a,Attendance b)
        {
            Attendance result = new Attendance(0,0,0);
            result._workingDays = a._workingDays+b._workingDays;
            result._leaveTaken=a._leaveTaken+b._leaveTaken;
            result._permision=a._permision+b._permision;
            return result;
        }

       

        public string Display()
        {
            return $"{_workingDays} WorkingDays , {_leaveTaken} TakenLeave, {_permision} Permission Taken";
        }

        public double calculate()
        {
            int days = _workingDays-_leaveTaken;
            return days*500;
        }
        
    }
}
/*
1.	Salary Calculation application
a.	Create a class named Attendance
b.	 Properties: TotalWorkingDaysInMonth, NumberOfLeavesTaken, NumberOfPermissionsTaken.
c.	Method : CalculateSalary
d.	Create objects month1, month 2, month3
e.	Calculate the three months total working days, number of leaves taken, and number of permissions taken using operator overloading method
f.	calculate the total salary by number of days worked * 500 Rs.  


*/