namespace MathLib;

public class Class1
{

    protected internal double PI = 3.14;

    internal double _g = 9.8;

    public double CalculatedWeight(double mass)
    {

        return mass * _g;
    }
}
