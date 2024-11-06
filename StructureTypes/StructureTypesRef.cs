using System;

public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}


class Program
{
    static void Main()
    {
        Coords point = new Coords(3.5, 7.2);

        Console.WriteLine(point);  
    }
}

