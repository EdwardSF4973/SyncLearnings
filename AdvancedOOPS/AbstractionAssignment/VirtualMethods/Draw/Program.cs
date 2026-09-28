using System;

namespace Draw;

class Program
{
    public static void Main(string[] args)
    {

        Draw line = new();
        line.Drawing();

        Draw triangle = new Pyramid();
        triangle.Drawing();

        Draw star = new Star();
        star.Drawing();
    }
}
/*
3.	Create an application for shape drawing application

Class Draw:
Method: virtual Draw - > Form a line of string and return it 

Class DrawPyramid inherit Draw
Method:  override Draw -> Form a * pyramid using string and return it

Class Drawstar  inherit Draw
Method: override draw ->  Draw Star using string

Requirements :  Create object for draw class -> call draw line method and print the line in Program.cs
Create object for DrawPyramid -> call Draw method and show returned pyramid in Program.cs
Create object for DrawStar - > call DrawStar method and show the returned star in Program.cs


*/