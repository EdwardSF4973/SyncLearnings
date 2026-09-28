using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        int Physics{get;set;}
        int Chemistry{get;set;}
        int Maths{get;set;}
        public void GetMarks(int physics,int chemistry,int maths);
        public string ShowMarks();
    }
}