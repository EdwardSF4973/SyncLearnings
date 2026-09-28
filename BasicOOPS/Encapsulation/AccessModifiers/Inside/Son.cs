using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    //default internal
    public class Son : Parent
    {
        //default is private

        public int PublicNumber = 10;

        private int PrivateNumber = 20;


        public int PrivateOutNumber
        {
            get{return PrivateNumber;}
        }

        /*public int PrivateParentOutNumber
        {
            get{return PrivateParentNumber;}
        }*/

        public int ProtectedParentOutNumber
        {
            get{return protectedParentNumber;}
        }
        
    }
}