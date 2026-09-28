using System;
using System.Runtime.ConstrainedExecution;

namespace CarModel;

class Program
{
    public static void Main(string[] args)
    {   
        ShiftDezire car1 = new (12,456987,46531,"Suzuki","Sedan","petrol",4,"red",15,500);
        System.Console.WriteLine(car1.Display());

        Eco car2 = new(456,45662,6541,"Ford","Suv","Diesel",5,"Black",35,845);
        System.Console.WriteLine(car2.Display());
    }
}




