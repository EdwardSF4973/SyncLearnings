using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class Parent: GrandParent
    {
        private int PrivateParentNumber = 30;

        protected int protectedParentNumber =40; 

        internal int internalParentNumber =50;

        /*public int GrandParentInternalOut
        {
            get{return InternalGrandParentNumber;}
        }*/

        public int ProtectedInternalOut
        {
            get{return ProtectedInternalNumber;}
        }
    }
}