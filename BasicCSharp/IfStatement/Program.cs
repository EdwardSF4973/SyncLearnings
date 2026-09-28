using System;

namespace IfStatement;

class Project{
    static void Main(string[] args)
    {
        //getting marks
        int mark = Convert.ToInt32(Console.ReadLine());
        

        //checking condition
        // Grade A if mark  > 80
        if(mark>=0 && mark <= 100)
        {
            if(mark > 80)
            {
                Console.WriteLine("Your grade is A");
            }
            else if(mark>= 61 && mark<=80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if(mark>=36 && mark<=60)
            {
                Console.WriteLine("Your grade is C");
            }
            else if(mark < 36)
            {
                Console.WriteLine("Your grade is D");
            }
            else{
                Console.WriteLine("Invalid Input");
            }

        }
        else{
            Console.WriteLine("Invalid Input");

        }
        

    }
}
