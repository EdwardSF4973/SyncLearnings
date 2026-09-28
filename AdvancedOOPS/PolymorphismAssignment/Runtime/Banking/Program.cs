using System;

namespace Banking;

class Program
{
    public static void Main(string[] args)
    {
        Bank bank1 = new SBI();
        System.Console.WriteLine(bank1.GetIntresetInfo());

        Bank bank2 = new ICICI();
        System.Console.WriteLine(bank2.GetIntresetInfo());


        Bank bank3 = new HDFC();
        System.Console.WriteLine(bank3.GetIntresetInfo());


        Bank bank4 = new IDBI();
        System.Console.WriteLine(bank4.GetIntresetInfo());
    }
}