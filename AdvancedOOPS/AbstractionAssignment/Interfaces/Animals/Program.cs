using System;

namespace Animals;

class Program
{
    public static void Main(string[] args)
    {
        Dog sheperd = new("Jackie","Home","Chiken");
        Dog doberman = new("Coolie","Guard","All");
        System.Console.WriteLine(sheperd.Display());
        System.Console.WriteLine(doberman.Display());

        Duck duck1 = new ("coffee","lake","beans");
        Duck duck2 = new ("tea","road","nuts");

        System.Console.WriteLine(duck1.Display());
        System.Console.WriteLine(duck2.Display());

    }
}
