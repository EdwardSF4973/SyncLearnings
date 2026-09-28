using System;

namespace Shapes;

class Program
{
    public static void Main(string[] args)
    {
        Line line =new();
        line.DrawShape();

        Square square = new();
        square.DrawShape();

        Rectangle rectangle = new();
        rectangle.DrawShape();
    }
}
/*
1.	Shapes drawing application

a.	Create an abstract class Name Shape 

b.	That have an abstract method double return type DrawShape

c.	Create class Line and override method DrawShape and Draw line as string.

d.	Create class Square and override method DrawShape and Draw Square as string.

e.	Create class Rectangle and override method DrawShape and Draw rectangle as string.

f.	
Requirement: Declare an object for Shape. Create objects for the  Line and assign it to Shape’s object and call method DrawShape and show the result. Likewise repeat assigning Square, Rectangle to shape object and draw the corresponding shapes by calling method DrawShape.

*/