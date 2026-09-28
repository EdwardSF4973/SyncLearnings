using System;

namespace LibraryManagement;

class Program
{
    public static void Main(string[] args)
    {
        EEE stu = new("Edward","BatMan","Subin",55550);

        stu.SetBookInfo();

        CSE stu1 = new("Unni","Red Dead","Shyam",55562);
        stu1.SetBookInfo(); 
    }
}
